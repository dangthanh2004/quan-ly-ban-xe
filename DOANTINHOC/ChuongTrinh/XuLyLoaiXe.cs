using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DOANTINHOC
{
    internal class XuLyLoaiXe
    {
        public List<LoaiXe> dslx;

        public List<LoaiXe> Ds { get => dslx; set => dslx = value; }

        public XuLyLoaiXe()
        {
            Ds = new List<LoaiXe>();
        }
        public List<LoaiXe> dssp()
        {
            //get=> dssp.ToList();
            return Ds.ToList();
        }
        public LoaiXe tim(string ma)
        {
            foreach (LoaiXe s in Ds)
            {
                if (s.Maloai == ma)
                    return s;
            }
            return null;
        }
        public bool them(LoaiXe spx)
        {
            LoaiXe sp = tim(spx.Maloai);
            if (sp != null) return false;
            Ds.Add(spx);
            fileLuu(dslx, "loaixe.txt");
            return true;
        }
        public bool sua(LoaiXe spx)
        {
            LoaiXe sp = tim(spx.Maloai);
            if (sp == null) return false;
            sp.Maloai = spx.Maloai;
            sp.Tenloai = spx.Tenloai;
            fileLuu(dslx, "loaixe.txt");
            return true;
        }
        public bool xoa(string ma)
        {
            LoaiXe sp = tim(ma);
            if (sp != null)
            {
                Ds.Remove(sp);
                fileLuu(dslx, "loaixe.txt");
                return true;
            }
            return false;
        }
        //public bool docFile(string mapt)
        //{
        //    if (!File.Exists(mapt)) return false;
        //    else
        //    {
        //        FileStream fs = new FileStream(mapt, FileMode.Open);
        //        BinaryFormatter bf = new BinaryFormatter();
        //        Ds = (List<LoaiXe>)bf.Deserialize(fs);
        //        fs.Close();
        //        return true;
        //    }
        //}
        //public bool ghiFile(string mapt)
        //{
        //    try
        //    {
        //        FileStream fs = new FileStream(mapt, FileMode.Create);
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
        public bool fileLuu(List<LoaiXe> dslx, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                foreach (LoaiXe x in dslx)
                {
                    string line = x.Maloai + "|" + x.Tenloai;
                    sw.WriteLine(line);
                }
                sw.Close();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public List<LoaiXe> fileDoc(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split('|');
                    if (arr.Length == 2)
                    {
                        LoaiXe lx = new LoaiXe {
                            Maloai = arr[0],
                            Tenloai = arr[1]
                        };
                        Ds.Add(lx);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ds;
        }
    }
}
