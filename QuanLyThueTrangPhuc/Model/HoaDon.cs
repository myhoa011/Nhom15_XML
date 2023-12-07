using BAITAPCUOIKY.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace QuanLyThueTrangPhuc.Model
{
    class HoaDon
    {
        ConnectFile Fxml = new ConnectFile();
        public XDocument doc;
        public string path = "./HoaDon.xml";

        public bool CheckEmpty(string mahoadon, string tenkhachhang, string soluong)
        {
            if (string.IsNullOrEmpty(mahoadon) || string.IsNullOrEmpty(tenkhachhang) ||
                string.IsNullOrEmpty(soluong) || Int32.Parse(soluong) <= 0)
            {
                return false;
            }
            return true;
        }

        public bool kiemtraMaHoaDon(string MaHoaDon)
        {
            XmlTextReader reader = new XmlTextReader("HoaDon.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaHD";
            reader.Close();
            int index = dv.Find(MaHoaDon);
            if (index == -1)
            {
                return false;
            }
            return true;
        }

        public void themPN(string maHd, string tenKH, string maSP, string maNV, string soluong, string dongia, string ngaylap,string ngaythue, string ngaytra, int tongtien)
        {
            themCTHD(maHd, maSP, soluong, dongia);
            string HoaDon = "<HoaDon>" +
                    "<MaHD>" + maHd + "</MaHD>" +
                    "<MaNV>" + maNV + "</MaNV>" +
                    "<TenKH>" + tenKH + "</TenKH>" +
                    "<NgayTao>" + ngaylap + "</NgayTao>" +
                    "<NgayThue>" + ngaythue + "</NgayThue>" +
                    "<NgayTra>" + ngaytra + "</NgayTra>" +
                    "<TongTien>" + tongtien + "</TongTien>" +
                    "</HoaDon>";
            Fxml.Them("HoaDon.xml", HoaDon);
        }

        public void themCTHD(string maHd, string maSP, string soluong, string dongia)
        {
            int soluongSP = 0;
            if (soluongSP > 0)
            {
                soluong += soluongSP;
                capNhatSoLuongTP(maHd, Int32.Parse(soluong));
            }
            else
            {
                string ChiTietHoaDon = "<ChiTietHoaDon>" +
                        "<MaDH>" + maHd + "</MaDH>" +
                        "<MaTP>" + maSP + "</MaTP>" +
                        "<soLuongDat>" + soluong + "</soLuongDat>" +
                        "<donGia>" + dongia + "</donGia>" +
                        "</ChiTietHoaDon>";
                Fxml.Them("ChiTietHoaDon.xml", ChiTietHoaDon);
            }
            capNhatTongTien(maHd, soluong, dongia);
            capNhatSoluongCon(maSP, Int32.Parse(soluong));

        }

        public void capNhatSoLuongTP(string maHd, int soluong)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(Application.StartupPath + "\\HoaDon.xml");
            XmlNode node1 = doc1.SelectSingleNode("//HoaDon[MaHD = '" + maHd + "']");
            if (node1 != null)
            {
                node1.ChildNodes[2].InnerText = soluong.ToString();
                doc1.Save(Application.StartupPath + "\\HoaDon.xml");
            }
        }
        public Boolean ktraTrungTP(string maDH, string maTP)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Fxml.HienThi("ChiTietHoaDon.xml");
                dt.DefaultView.RowFilter = "maDH ='" + maDH + "' AND maTP ='" + maTP + "'";
                if (dt.DefaultView.Count > 0)
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public int tim_Tongtien(string maHD)
        {
            int tongtien = 0;
            doc = XDocument.Load(path);
            var list = doc.Descendants("HoaDon");
            string group;
            foreach (XElement node in list)
            {
                group = node.Element("MaHD").Value;
                if (maHD == group)
                {
                    tongtien = Int32.Parse(node.Element("TongTien").Value);
                }
            }
            return tongtien;
        }

        public void capNhatTongTien(string maHd, string soluong, string dongia)
        {
            int thanhtien = Int32.Parse(soluong) * Int32.Parse(dongia) + tim_Tongtien(maHd);
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(Application.StartupPath + "\\HoaDon.xml");
            XmlNode node1 = doc1.SelectSingleNode("//HoaDon[MaHD = '" + maHd + "']");
            if (node1 != null)
            {
                node1.ChildNodes[4].InnerText = thanhtien.ToString();
                doc1.Save(Application.StartupPath + "\\HoaDon.xml");
            }
        }

        public void capNhatSoluongCon(string maTP, int soluong)
        {
            // tìm số lượng sản phẩm còn
            int soluongcon = ChiTiet_HoaDon.soluongcon - soluong;
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(Application.StartupPath + "\\SanPham.xml");
            XmlNode node1 = doc1.SelectSingleNode("//TrangPhuc[maTP = '" + maTP + "']");
            if (node1 != null)
            {
                node1.ChildNodes[4].InnerText = soluongcon.ToString();
                doc1.Save(Application.StartupPath + "\\SanPham.xml");
            }
        }
    }
}
