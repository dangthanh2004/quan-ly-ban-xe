using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANTINHOC
{
    internal class TaiKhoan
    {
        private string m_tentaikhoan;
        private string m_matkhau;

        public string Tentaikhoan
        {
            get => m_tentaikhoan;
            set => m_tentaikhoan = value;
        }
        public string Matkhau
        {
            get => m_matkhau;
            set => m_matkhau = value;
        }
        public TaiKhoan()
        {
            m_tentaikhoan = null;
            m_matkhau = null;
        }
        public TaiKhoan(string tentaikhoan, string matkhau)
        {
            m_tentaikhoan = tentaikhoan;
            m_matkhau = matkhau;
        }
    }
}
