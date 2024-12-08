using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANTINHOC.ChuongTrinh
{
    [Serializable]
    internal class CHoaDon
    {
        private string m_madon;
        private string m_maxe;
        private string m_tenxe;
        private string m_maloai;
        private string m_tenloai;
        private string m_tenkh;
        private string m_giaban;
        private DateTime m_ngayban;
        public string Madon { get => m_madon; set => m_madon = value; }
        public string Maxe { get => m_maxe; set => m_maxe = value; }

        public string Maloai { get => m_maloai; set=> m_maloai = value; }
        public string Tenxe { get => m_tenxe; set => m_tenxe = value; }
        public string Tenloai { get => m_tenloai; set => m_tenloai = value; }
        public string Tenkh { get => m_tenkh; set => m_tenkh = value; }
        public string Giaban { get => m_giaban; set => m_giaban = value; }
        public DateTime Ngayban { get => m_ngayban; set => m_ngayban = value; }
        

        public CHoaDon()
        {
            m_madon = null;
            m_maxe = null;
            m_maloai = null; 
            m_tenxe=null;
            m_tenloai = null;
            m_tenkh = null;
            m_giaban = null;
            m_ngayban= DateTime.Now;
        }
        public CHoaDon(string madon, string maxe,string maloai,string tenxe,string tenloai,string tenkh, string giaban, DateTime ngayban)
        {
            Madon  = madon;
            Maxe = maxe;
            Maloai = maloai;
            Tenxe = tenxe;
            Tenloai = tenloai;
            Tenkh = tenkh;
            Giaban = giaban;
            Ngayban = ngayban;
        }
    }
}
