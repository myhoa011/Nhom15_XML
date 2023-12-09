using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuanLyThueTrangPhuc.Model
{
    class TrangPhuc
    {
        ConnectFile Fxml = new ConnectFile();

        public bool checkEmpty(string v1, string v2, string v3, string v4, string v5)
        {
            if (string.IsNullOrEmpty(v1) || string.IsNullOrEmpty(v2) ||
                string.IsNullOrEmpty(v3) || string.IsNullOrEmpty(v4) ||
                string.IsNullOrEmpty(v5))
            {
                return false;
            }
            return true;
        }

        public bool kTraTonTai(string maSP)
        {
            XmlTextReader reader = new XmlTextReader("TrangPhuc.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaTP";
            reader.Close();
            int index = dv.Find(maSP);
            if (index == -1)
            {
                return false;
            }
            return true;
        }

        internal void themTP(string MaTP, string TenTP, string donGia, string soLuong, string MaDM)
        {
            string noiDung = "<TrangPhuc>" +
                    "<MaTP>" + MaTP + "</MaTP>" +
                    "<TenTP>" + TenTP + "</TenTP>" +
                    "<donGia>" + donGia + "</donGia>" +
                    "<soLuong>" + soLuong + "</soLuong>" +
                    "<MaDM>" + MaDM + "</MaDM>" +
                    "</TrangPhuc>";
            Fxml.Them("TrangPhuc.xml", noiDung);
        }

        public void suaTP(string maTP, string tenTP, string donGia, string soLuong, string MaDM)
        {
            string noiDung = "<MaTP>" + maTP + "</MaTP>" +
                    "<TenTP>" + tenTP + "</TenTP>" +
                    "<donGia>" + donGia + "</donGia>" +
                    "<soLuong>" + soLuong + "</soLuong>" +
                    "<MaDM>" + MaDM + "</MaDM>";
            Fxml.Sua("TrangPhuc.xml", "TrangPhuc", "MaTP", maTP, noiDung);
        }

        public void xoaTP(string maTP)
        {
            Fxml.Xoa("TrangPhuc.xml", "TrangPhuc", "MaTP", maTP);
        }

        public DataTable LoadMaTP()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("TrangPhuc.xml");
            return dt;
        }
    }
}
