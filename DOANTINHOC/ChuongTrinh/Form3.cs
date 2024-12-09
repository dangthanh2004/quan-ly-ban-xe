using DOANTINHOC.ChuongTrinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANTINHOC
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private XuLyXe xlx = new XuLyXe();
        private void hienthi()
        {
            var dsXe = new List<Xe>();

            foreach (Xe xe in xlx.dsx())
            {
                if (xe.Cobixoahaykhong == 0)
                {
                    dsXe.Add(xe);
                }
            }

            dgv.DataSource = dsXe;
            dgv.Columns.Remove("Cobixoahaykhong");
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            string pathXe = Application.StartupPath + "\\CTxe.txt";
            xlx.Ds = xlx.fileDoc(pathXe, true);

            hienthi();
        }

        private void dgv_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaXe.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_TenXe.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_MaLoai.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbb_LoaiXe.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_GiaBan.Text = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtp.Text = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_sokhung.Text = dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_somay.Text = dgv.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_mau.Text = dgv.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_dungtich.Text = dgv.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_binhxang.Text = dgv.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_khoidong.Text = dgv.Rows[e.RowIndex].Cells[11].Value.ToString();
        }
        //chucnang------------------------------------------------------------------------
        public void Dangxuat()
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
        private void btn_DXuat_Click(object sender, EventArgs e)
        {
            Dangxuat();
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Xe x = xlx.tim(txt_MaXe.Text);
            if (x != null)
            {
                x.Maloai = txt_MaLoai.Text;
                x.Tenloai = cbb_LoaiXe.Text;
                x.Tenxe = txt_TenXe.Text;
                x.Ngaynhap = dtp.Value;
                x.Giaban = txt_GiaBan.Text;
                x.Sokhung = txt_sokhung.Text;
                x.Somay = txt_somay.Text;
                x.Mau = txt_mau.Text;
                x.Dungtich = txt_dungtich.Text;
                x.Binhxang = txt_binhxang.Text;
                x.Khoidong = txt_khoidong.Text;
                hienthi();
                MessageBox.Show("Sua thanh cong", "Thong bao");
            }
            else
            {
                hienthi();
                MessageBox.Show("Khong sua duoc!!!", "Thong bao");
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            Xe x = new Xe();
            if (xlx.tim(txt_MaXe.Text) != null)
                MessageBox.Show("Ma da ton tai", "thong bao");
            Xe xe = new Xe(txt_MaXe.Text, txt_TenXe.Text, txt_MaLoai.Text, cbb_LoaiXe.Text, txt_GiaBan.Text, dtp.Value,
            txt_sokhung.Text, txt_somay.Text, txt_mau.Text, txt_dungtich.Text, txt_binhxang.Text, txt_khoidong.Text);
            xlx.them(xe);
            //string pathXe = Application.StartupPath + "\\CTxe.txt";
            //xlx.fileLuu(xlx.Ds, pathXe);
            luufile();
            hienthi();
        }
        private void luufile()
        {
            string pathXe = Application.StartupPath + "\\CTxe.txt";
            xlx.fileLuu(xlx.Ds, pathXe);
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string k = txt_MaXe.Text;
            if (xlx.xoa(k))
            {
                hienthi();
            }
            else
            {
                MessageBox.Show("Ma khong ton tai");
            }
        }
        private void btn_LoaiXe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void btn_Tim_Click(object sender, EventArgs e) //tìm xe 
        {
            string ma = txt_MaXe.Text;
            var xe = xlx.tim(ma);

            if (xe != null)
            {
                List<DOANTINHOC.Xe> kq = new List<DOANTINHOC.Xe> { xe };

                dgv.DataSource = null;
                dgv.DataSource = kq;

                MessageBox.Show("Đã tìm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo");
            }
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.Font = new Font("Time new roman", 8);
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }


        private void txt_MaLoai_TextChanged(object sender, EventArgs e)
        {
            //string ma = txt_MaLoai.Text;
            //XuLyLoaiXe xuLyLoaiXe = new XuLyLoaiXe();
            //LoaiXe lx = new LoaiXe();
            //string path = Application.StartupPath + "\\loaixe.txt";
            //xuLyLoaiXe.fileDoc(path);
            //foreach (LoaiXe x in xuLyLoaiXe.Ds)
            //{
            //    if(x.Maloai != ma)
            //    {
            //        cbb_LoaiXe.Text = "";
            //    }
            //    else if (x.Maloai == ma)
            //    {
            //        cbb_LoaiXe.Text = x.Tenloai;
            //    }
              
            //}
        }

        private void txt_MaLoai_KeyUp(object sender, KeyEventArgs e)
        {
            string ma = txt_MaLoai.Text;
            XuLyLoaiXe xuLyLoaiXe = new XuLyLoaiXe();
            LoaiXe lx = new LoaiXe();
            string path = Application.StartupPath + "\\loaixe.txt";
            xuLyLoaiXe.fileDoc(path);         
            foreach (LoaiXe x in xuLyLoaiXe.Ds)
            {
                if (x.Maloai == ma)
                {
                    cbb_LoaiXe.Text = x.Tenloai;
                }
            }
        }

        

    }
}
