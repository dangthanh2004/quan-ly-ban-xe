using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANTINHOC
{
    [Serializable]

    internal class Xe
    {
        private string m_maxe;
        private string m_tenxe;
        private string m_maloai;
        private string m_tenloai;
        private string m_giaban;
        private DateTime m_ngaynhap;
        private string m_sokhung;
        private string m_somay;
        private string m_mau;
        private string m_dungtich;
        private string m_binhxang;
        private string m_khoidong;
        private int m_cobixoahaykhong;
        public string Maxe { get => m_maxe; set => m_maxe = value; }
        public string Tenxe { get => m_tenxe; set => m_tenxe = value; }
        public string Maloai { get => m_maloai; set => m_maloai = value; }
        public string Tenloai { get => m_tenloai; set => m_tenloai = value; }
        public string Giaban { get => m_giaban; set => m_giaban = value; }
        public DateTime Ngaynhap { get => m_ngaynhap; set => m_ngaynhap = value; }
        public string Sokhung { get => m_sokhung; set => m_sokhung = value; }
        public string Somay { get => m_somay; set => m_somay = value; }
        public string Mau { get => m_mau; set => m_mau = value; }
        public string Dungtich { get => m_dungtich; set => m_dungtich = value; }
        public string Binhxang { get => m_binhxang; set => m_binhxang = value; }
        public string Khoidong { get => m_khoidong; set => m_khoidong = value; }
        public int Cobixoahaykhong { get => m_cobixoahaykhong; set => m_cobixoahaykhong = value; }

        public Xe()
        {
            m_maxe = null;
            m_tenxe = null;
            m_maloai = null;
            m_tenloai = null;
            m_giaban = null;
            m_ngaynhap = DateTime.Now;
            m_sokhung = null;
            m_somay = null;
            m_mau = null;
            m_dungtich = null;
            m_binhxang = null;
            m_khoidong = null;
            m_cobixoahaykhong = 0;
        }
        public Xe(string maxe, string tenxe, string maloai, string tenloai, string giaban, DateTime ngaynhap, string sokhung, string somay, string mau, string dungtich, string binhxang, string khoidong, int cobixoahaykhong = 0)
        {
            Maxe = maxe;
            Tenxe = tenxe;
            Maloai = maloai;
            Tenloai = tenloai;
            Giaban = giaban;
            Ngaynhap = ngaynhap;
            Sokhung = sokhung;
            Somay = somay;
            Mau = mau;
            Dungtich = dungtich;
            Binhxang = binhxang;
            Khoidong = khoidong;
            Cobixoahaykhong = cobixoahaykhong;
        }
    }
}
