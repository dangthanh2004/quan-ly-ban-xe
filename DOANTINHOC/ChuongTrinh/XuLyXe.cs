using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANTINHOC
{
    internal class XuLyXe
    {
        private List<Xe> ds;

        internal List<Xe> Ds { get => ds; set => ds = value; }

        public XuLyXe()
        {
            Ds = new List<Xe>();
        }
        public List<Xe> dsx()
        {
            return Ds.ToList();
        }
        public Xe tim(string ma)
        {
            foreach (Xe x in Ds)
            {
                if (x.Maxe == ma)
                    return x;
            }
            return null;
        }
        
        public bool them(Xe x)
        {
            Xe xe = tim(x.Maxe);
            if (xe != null) return false;
            Ds.Add(x);
            fileLuu(ds,"CTxe.txt");
            return true;
        }
        public bool sua(Xe x)
        {
            Xe xe = tim(x.Maxe);
            if (xe == null) return false;
            fileLuu(ds, "CTxe.txt");
            return true;
        }
        public bool xoa(string x)
        {
            Xe xe = tim(x);
            if (xe == null) return false;
            Ds.Remove(xe);
            fileLuu(Ds, "CTxe.txt");
            return true;
        }
        //public bool ghifile(string ma)
        //{
        //    try
        //    {
        //        FileStream fs = new FileStream(ma, FileMode.Create);
        //        BinaryFormatter bf = new BinaryFormatter();
        //        bf.Serialize(fs, Ds);
        //        fs.Close();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        //public bool docFile(string ma)
        //{
        //    if(!File.Exists(ma)) return false;
        //    else
        //    {
        //        FileStream fs = new FileStream(ma,FileMode.Open);
        //        BinaryFormatter bf = new BinaryFormatter();
        //        Ds = (List<Xe>)bf.Deserialize(fs);
        //        fs.Close();
        //        return true;
        //    }
        //}
        public bool fileLuu(List<Xe> dsx, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                foreach (Xe x in dsx)
                {
                    string line = x.Maxe + "|" + x.Tenxe + "|" + x.Maloai + "|" + x.Tenloai + "|" + x.Giaban + "|" + x.Ngaynhap + "|" + x.Sokhung + "|" + x.Somay + "|" + x.Mau + "|" + x.Dungtich + "|" + x.Binhxang + "|" + x.Khoidong + "|" + x.Cobixoahaykhong.ToString();
                    sw.WriteLine(line);
                }
                sw.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;//xuatloi
            }
            return false;
        }

        public List<Xe> fileDoc(string path,bool getall = false)
        {
            List<Xe> dsX = new List<Xe>();
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split('|');
                    if (arr.Length == 13)
                    {
                        Xe lx = new Xe();
                        lx.Maxe = arr[0];
                        lx.Tenxe = arr[1];/*"MM/dd/yyyy h:mm:ss tt"02/12/2024 10:40 SA*/
                        lx.Maloai = arr[2];
                        lx.Tenloai = arr[3];
                        lx.Giaban = arr[4];
                        //lx.Ngaynhap = DateTime.ParseExact(arr[5], "dd/MM/yyyy h:mm tt ", CultureInfo.InvariantCulture);
                        lx.Ngaynhap = DateTime.Now;
                        lx.Sokhung = arr[6];
                        lx.Somay = arr[7];
                        lx.Mau=arr[8];
                        lx.Dungtich = arr[9];
                        lx.Binhxang = arr[10];
                        lx.Khoidong = arr[11];
                        lx.Cobixoahaykhong = Int32.Parse(arr[12]);
                        if (getall)
                        {
                            dsX.Add(lx);
                        }
                        else
                        {
                            if (lx.Cobixoahaykhong == 0)
                            {
                                dsX.Add(lx);
                            }

                        }     
                        
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsX;
        }
        //---------------------------------TImXeTheoMa----------------------------------
        public class XuLy
        {
            private List<DOANTINHOC.Xe> danhSachXe;

            public XuLy()
            {
                danhSachXe = new List<DOANTINHOC.Xe>();
            }

            public DOANTINHOC.Xe timXe(string ma)
            {
                return danhSachXe.FirstOrDefault(xe => xe.Maxe == ma);
            }
        }
        //-----------------------------rangbuoc--------------------------
       
    }
}
