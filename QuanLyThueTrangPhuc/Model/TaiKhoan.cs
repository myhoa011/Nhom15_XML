using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuanLyThueTrangPhuc.Model
{
    class TaiKhoan
    {
        ConnectFile Fxml = new ConnectFile();

        public bool kiemtra(string mataikhoan)
        {
            XmlTextReader reader = new XmlTextReader("TaiKhoan.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaNV";
            reader.Close();
            int index = dv.Find(mataikhoan);
            if (index == -1)
            {
                return false;
            }
            return true;
        }

        public void themNV(string maTaiKhoan, string matkhau, string quyen)
        {
            string noiDung = "<TaiKhoan>" +
                    "<MaNV>" + maTaiKhoan + "</MaNV>" +
                    "<MatKhau>" + "Abc123!@#" + "</MatKhau>" +
                    "<Quyen>" + quyen + "</Quyen>" +
                    "</TaiKhoan>";
            Fxml.Them("TaiKhoan.xml", noiDung);
        }

        public void suaNV(string maTaiKhoan, string matkhau, string quyen)
        {
            string noiDung = "<MaNV>" + maTaiKhoan + "</MaNV>" +
                    "<MatKhau>" + matkhau + "</MatKhau>" +
                    "<Quyen>" + quyen + "</Quyen>";
            Fxml.Sua("TaiKhoan.xml", "TaiKhoan", "MaNV", maTaiKhoan, noiDung);
        }

        internal void xoaNV(string maTaiKhoan)
        {
            Fxml.Xoa("TaiKhoan.xml", "TaiKhoan", "MaNV", maTaiKhoan);
        }
    }
}
