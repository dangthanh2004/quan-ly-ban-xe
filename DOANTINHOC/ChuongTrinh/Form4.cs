using DOANTINHOC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace DOANTINHOC.ChuongTrinh
{
    public partial class Form4 : Form
    {
     
        public Form4()
        {
            InitializeComponent();
          

        }

        private Xulyhoadon xl = new Xulyhoadon();
        private XuLyXe xlx = new XuLyXe();

        private void hienthi()
        {
            dgv.DataSource = xl.dshd().ToList();
        }

        private void loadCombobox()
        {
            // Load danh sach xe
            string pathXe = Application.StartupPath + "\\CTxe.txt";
            xlx.Ds = xlx.fileDoc(pathXe);

            var dsMaXe = new List<string>();

            foreach (Xe xe in xlx.dsx())
            {
                dsMaXe.Add(xe.Maxe);
            }

            cbbMaXe.DataSource = dsMaXe;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            loadCombobox();
            // Load danh sach hoadon
            string pathHoaDon = Application.StartupPath + "\\HoaDon.txt";
            xl.DSHD = xl.fileDoc(pathHoaDon);
            dtpNgayBan.Value = DateTime.Now;
            hienthi();
        }
        private void luufile()
        {
            string pathHoaDon = Application.StartupPath + "\\HoaDon.txt";
            xl.fileGhi(xl.DSHD, pathHoaDon);
            string pathXe = Application.StartupPath + "\\CTxe.txt";
            xlx.Ds = xlx.fileDoc(pathXe);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime ngayBan = DateTime.Parse(dtpNgayBan.Value.ToString("dd/MM/yyyy"));
            CHoaDon hd = new CHoaDon(txtMaDon.Text, cbbMaXe.Text,txtMaLoai.Text,txtTenXe.Text,txtTenLoai.Text, txtTenKH.Text, txtGia.Text, ngayBan);
            if (xl.tim(hd.Madon) != null || xl.timTheoMaXe(hd.Maxe) != null)
            {
                MessageBox.Show("Da ton tai");
                return;
            }
            xl.them(hd);
            foreach (Xe x in xlx.dsx())
            {
                if (x.Maxe == hd.Maxe)
                {
                    x.Cobixoahaykhong = 1;
                    xlx.sua(x);
                    break;
                }    
            }    
           
            luufile();
            loadCombobox();
            hienthi();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDon.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbbMaXe.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMaLoai.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTenXe.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTenLoai.Text = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTenKH.Text = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtGia.Text = dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
            String ngayBanStr = dgv.Rows[e.RowIndex].Cells[7].Value.ToString();
            dtpNgayBan.Text = DateTime.Parse(ngayBanStr).ToString("dd/MM/yyyy");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CHoaDon hd = xl.tim(txtMaDon.Text);
            if (hd != null)
            {
                hd.Maxe = cbbMaXe.Text;
                hd.Maloai = txtMaLoai.Text;
                hd.Tenkh = txtTenKH.Text;
                hd.Tenloai = txtTenLoai.Text;
                hd.Tenxe = txtTenXe.Text;
                hd.Ngayban = dtpNgayBan.Value;
                hd.Giaban = txtGia.Text;
                xl.sua(hd);
                luufile();

                hienthi();
                MessageBox.Show("Sua thanh cong", "Thong bao");
            }
            else
            {
                hienthi();
                MessageBox.Show("Khong sua duoc!!!", "Thong bao");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaDon.Text;
            if (xl.xoa(ma))
            {
                hienthi();
            }
            else
            {
                MessageBox.Show("Ma khong ton tai");
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.ShowDialog();
        }

        private void cbbMaXe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string maXeDuocChon = (string)cbbMaXe.SelectedValue;

            foreach (Xe x in xlx.dsx())
            {
                if (x.Maxe == maXeDuocChon)
                {
                    txtGia.Text = x.Giaban;
                    txtTenXe.Text = x.Tenxe;
                    txtMaLoai.Text = x.Maloai;
                    txtTenLoai.Text = x.Tenloai;
                    break;
                }
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaDon.Text;
            string maXeCuaHoaDon = cbbMaXe.Text;
            if (xl.xoa(maHoaDon))
            {
                string pathXe = Application.StartupPath + "\\CTxe.txt";
                List<Xe> dsxe = xlx.fileDoc(pathXe,true);
                foreach (Xe x in dsxe.ToList())
                {
                    if(x.Maxe == maXeCuaHoaDon)
                    {
                        x.Cobixoahaykhong = 0;
                        xlx.sua(x);
                        xlx.fileLuu(dsxe,pathXe);
                        break;
                    }    
                }

                hienthi();
            }
          
        }
    }
}
