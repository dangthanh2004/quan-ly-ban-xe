using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANTINHOC
{
    public partial class Form1 : Form
    {
        List<TaiKhoan> listtaikhoan = XuLyDangNhap.Instance.flist;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtTentk.Select();
        }
        bool kiemTraDangNhap(string taikhoan, string matkhau)
        {
            for (int i = 0; i < listtaikhoan.Count; i++)
            {
                if (listtaikhoan[i].Tentaikhoan == taikhoan && listtaikhoan[i].Matkhau == matkhau)
                    return true;
            }
            return false;
        }
        private void btn_DangNhap_Click_1(object sender, EventArgs e)
        {
            if (kiemTraDangNhap(txtTentk.Text, txtMatKhau.Text))
            {
                this.Hide();
                Form2 frm2 = new Form2();
                Form3 frm3 = new Form3();
                frm2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Sai ten tai khoan hoac mat khau", "Thong bao");
                txtTentk.Clear();
                txtMatKhau.Clear();
                txtTentk.Select();
            }
        }
        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_DangNhap.Select();
            }
        }

        private void txtTentk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               txtMatKhau.Select();
            }
        }
    }
}
