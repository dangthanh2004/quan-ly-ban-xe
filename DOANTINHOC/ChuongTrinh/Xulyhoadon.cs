using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANTINHOC.ChuongTrinh
{
    internal class Xulyhoadon
    {
        private List<CHoaDon> listhoadon;

        internal List<CHoaDon> DSHD { get => listhoadon; set => listhoadon = value; }
        public Xulyhoadon()
        {
            DSHD =new List<CHoaDon>();
        }
        public List<CHoaDon> dshd()
        {
            return DSHD.ToList();
        }
        public CHoaDon tim(string ma)
        {
            foreach (var choaDon in DSHD)
            {
                if (choaDon.Madon == ma)
                { return choaDon; }
            }
            return null;
        }

        public CHoaDon timTheoMaXe(string ma)
        {
            foreach (var choaDon in DSHD)
            {
                if (choaDon.Maxe == ma)
                { return choaDon; }
            }
            return null;
        }
        public bool them(CHoaDon hd)
        {
            CHoaDon c = tim(hd.Madon);
            if(c != null)return false;
            DSHD.Add(hd);
            fileGhi(listhoadon, "HoaDon.txt");
            return true;
        }
        public bool sua(CHoaDon hd)
        {
            CHoaDon c = tim(hd.Madon);
            if(c==null) return false;
            return true;
        }
        public bool xoa(string ma)
        {
            CHoaDon c = tim(ma);
            if (ma == null) return false;
            DSHD.Remove(c);
            fileGhi(DSHD, "HoaDon.txt");
            return true;
        }
        public bool fileGhi(List<CHoaDon> dshd, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                foreach (CHoaDon hd in dshd)
                {
                    string line = hd.Madon + "|" + hd.Maxe + "|" + hd.Maloai + "|" + hd.Tenxe + "|" + hd.Tenloai + "|" + hd.Tenkh + "|" + hd.Giaban + "|" + hd.Ngayban;
                    sw.WriteLine(line);
                }
                sw.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;//xuatloi
            }
        }
        public List<CHoaDon> fileDoc(string path)
        {
            List<CHoaDon> dshd = new List<CHoaDon>();
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split('|');
                    if (arr.Length == 8)
                    {
                        CHoaDon hd= new CHoaDon();
                        hd.Madon = arr[0];
                        hd.Maxe = arr[1];
                        hd.Maloai = arr[2];
                        hd.Tenxe = arr[3];
                        hd.Tenloai = arr[4];
                        hd.Tenkh = arr[5];
                        //hd.Ngayban = DateTime.Parse(arr[4]);
                        //CultureInfo provider = CultureInfo.InvariantCulture;

                        //hd.Ngayban = DateTime.ParseExact(arr[3], "dd/MM/yyyy hh:mm:ss tt",CultureInfo.InvariantCulture);
                        hd.Giaban = arr[6];
                        hd.Ngayban = DateTime.Parse(arr[7]);
                        dshd.Add(hd);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dshd;
        }


    }
}
