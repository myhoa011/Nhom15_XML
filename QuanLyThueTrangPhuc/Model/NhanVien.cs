using BAITAPCUOIKY.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuanLyThueTrangPhuc.Model
{
    class NhanVien
    {
        ConnectFile Fxml = new ConnectFile();
        public bool kiemtra(string MaNhanVien)
        {
            XmlTextReader reader = new XmlTextReader("NhanVien.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaNV";
            reader.Close();
            int index = dv.Find(MaNhanVien);
            if (index == -1)
            {
                return false;
            }
            return true;
        }

        public void themNV(string MaNhanVien, string TenNhanVien, string DiaChi, string SDT, string Email)
        {
            string noiDung = "<NhanVien>" +
                    "<MaNV>" + MaNhanVien + "</MaNV>" +
                    "<TenNV>" + TenNhanVien + "</TenNV>" +
                    "<DiaChi>" + DiaChi + "</DiaChi>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<Email>" + Email + "</Email>" +
                    "</NhanVien>";
            Fxml.Them("NhanVien.xml", noiDung);
        }

        public void suaNV(string MaNhanVien, string TenNhanVien, string DiaChi, string SDT, string Email)
        {
            string noiDung = "<MaNV>" + MaNhanVien + "</MaNV>" +
                    "<TenNV>" + TenNhanVien + "</TenNV>" +
                    "<DiaChi>" + DiaChi + "</DiaChi>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<Email>" + Email + "</Email>";
            Fxml.Sua("NhanVien.xml", "NhanVien", "MaNV", MaNhanVien, noiDung);
        }
        public void xoaNV(string MaNhanVien)
        {
            /*
                        XDocument doc = XDocument.Load("NhanVien.xml");
                        foreach (XElement x in doc.Descendants("_x0027_NhanVien_x0027_"))
                        {
                            if (x.Element("maNV").Value.ToString().Equals(MaNhanVien))
                                x.Element("maNV").Remove();
                        }
                        doc.Save("NhanVien.xml");
            */
            Fxml.Xoa("NhanVien.xml", "NhanVien", "MaNV", MaNhanVien);
        }

        public bool checkEmpty(string MaNhanVien, string TenNhanVien, string DiaChi, string SDT, string Email)
        {
            if (string.IsNullOrEmpty(MaNhanVien) || string.IsNullOrEmpty(TenNhanVien) ||
                string.IsNullOrEmpty(SDT) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(DiaChi))
            {
                return false;
            }
            return true;
        }
    }
}
