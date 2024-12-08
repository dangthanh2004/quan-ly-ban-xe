using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANTINHOC
{
    internal class XuLyDangNhap
    {
        private static XuLyDangNhap instance;
        public static XuLyDangNhap Instance
        {
            get
            {
                if (instance == null)
                    instance = new XuLyDangNhap();
                return instance;
            }
            set => instance = value;
        }
        List<TaiKhoan> listDangNhap;
        public List<TaiKhoan> flist { get => listDangNhap; set => listDangNhap = value; }
        XuLyDangNhap()
        {
            listDangNhap = new List<TaiKhoan>();
            listDangNhap.Add(new TaiKhoan("chithanh", "123456"));
            listDangNhap.Add(new TaiKhoan("dangthanh", "123456"));
            listDangNhap.Add(new TaiKhoan("", ""));
        }
    }
}
