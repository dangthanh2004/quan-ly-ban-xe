using DOANTINHOC.ChuongTrinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANTINHOC
{
    public partial class Form2 : Form
    {
        bool thoat = true;

        public Form2()
        {
            InitializeComponent();
        }
        private XuLyLoaiXe xl = new XuLyLoaiXe();
        private void hienthi()
        {
            dgv1.DataSource = xl.dssp().ToList();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\loaixe.txt";
            xl.Ds = xl.fileDoc(path);
            hienthi();
        }

        //private void btn_Luu_Click(object sender, EventArgs e)
        //{
        //    if (xl.ghiFile("sanphamxe.txt"))
        //    {
        //        MessageBox.Show("Luu thanh cong");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Luu khong thanh cong");

        //    }
        //}
        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            string maxe = txt_MaLoai.Text;
            LoaiXe kq = xl.tim(maxe);
            if (xl.sua(kq))
            {
                string tenloai = cbb_LoaiXe.Text; //gán 
                kq.Tenloai = tenloai;
                XuLyXe xuLyXe = new XuLyXe();
                string pathXe = Application.StartupPath + "\\CTxe.txt";
                xuLyXe.fileDoc(pathXe);
                foreach (Xe xe in xuLyXe.Ds)
                {
                    if (maxe == xe.Maloai)
                        xe.Tenloai = tenloai;
                }
                xuLyXe.fileDoc(pathXe);
                hienthi();
            }
            else
            {
                MessageBox.Show("Ma khong ton tai");
            }
            
        }
        private void dgv1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaLoai.Text = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbb_LoaiXe.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            LoaiXe lx = new LoaiXe(txt_MaLoai.Text, cbb_LoaiXe.Text);
            xl.them(lx);
            hienthi();
        }
        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            string kq = txt_MaLoai.Text;
            if (xl.xoa(kq))
            {
                hienthi();
            }
            else
            {
                MessageBox.Show("Ma khong ton tai");
            }
        }
        private void btn_Xe_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.Show();
        }
        private void btn_DXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

    }
}

