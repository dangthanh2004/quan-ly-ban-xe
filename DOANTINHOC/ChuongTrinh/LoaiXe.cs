using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANTINHOC
{ 
    public class LoaiXe
    {
        private string m_maloai;
        private string m_tenloai;

        public string Maloai
        {
            get => m_maloai;
            set => m_maloai = value;
        }
        public string Tenloai
        {
            get => m_tenloai;
            set => m_tenloai = value;
        }
        public LoaiXe()
        {
            m_maloai = null;
            m_tenloai = null;
        }
        public LoaiXe(string maloai, string tenloai)
        {
            Maloai = maloai;
            Tenloai = tenloai;
        }
    }
}
