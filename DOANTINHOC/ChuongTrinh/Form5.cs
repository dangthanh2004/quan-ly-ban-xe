using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANTINHOC.ChuongTrinh
{
    public partial class Form5 : Form
    {
        private Xulyhoadon xl = new Xulyhoadon();

        public Form5()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            string pathHoaDon = Application.StartupPath + "\\HoaDon.txt";
            xl.DSHD = xl.fileDoc(pathHoaDon);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThongKeTheoSoLuong_Click(object sender, EventArgs e)
        {
            chart1.Series["tong_tien_ban_theo_tung_ma_loai"].Points.Clear();
            chart1.Series["so_luong_ban_theo_tung_ma_loai"].Points.Clear();

            Dictionary<string, int> soluongBanTheoMaLoaiDic = new Dictionary<string, int>();

            foreach (CHoaDon hoadon in xl.dshd())
            {
                string key = hoadon.Maloai;
                if (soluongBanTheoMaLoaiDic.ContainsKey(key))
                {
                    soluongBanTheoMaLoaiDic[key] += 1;

                }
                else
                {
                    soluongBanTheoMaLoaiDic.Add(key, 1);
                }

            }

            foreach (KeyValuePair<string, int> keyValuePair in soluongBanTheoMaLoaiDic)
            {
                chart1.Series["so_luong_ban_theo_tung_ma_loai"].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
            }

            if (chart1.Titles.Count() > 0)
            {
                chart1.Titles.RemoveAt(0);
            }

            chart1.Titles.Add("Thống Kê Số Lượng Bán Theo Từng Mã Loại");
        }

        private void btnThongKeSoTienBan_Click(object sender, EventArgs e)
        {

            chart1.Series["tong_tien_ban_theo_tung_ma_loai"].Points.Clear();
            chart1.Series["so_luong_ban_theo_tung_ma_loai"].Points.Clear();


            Dictionary<string, int> tongTienTheoMaLoai = new Dictionary<string, int>();

            foreach (CHoaDon hoadon in xl.dshd())
            {
                string key = hoadon.Maloai;
                if (tongTienTheoMaLoai.ContainsKey(key))
                {
                    tongTienTheoMaLoai[key] += int.Parse(hoadon.Giaban);

                }
                else
                {
                    tongTienTheoMaLoai.Add(key, int.Parse(hoadon.Giaban));
                }

            }

            foreach (KeyValuePair<string, int> keyValuePair in tongTienTheoMaLoai)
            {
                chart1.Series["tong_tien_ban_theo_tung_ma_loai"].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
            }


            if (chart1.Titles.Count() > 0)
            {
                chart1.Titles.RemoveAt(0);
            }
            chart1.Titles.Add("Thống Kê Số Tiền Bán Theo Từng Mã Loại");
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.ShowDialog();
        }
    }
}
