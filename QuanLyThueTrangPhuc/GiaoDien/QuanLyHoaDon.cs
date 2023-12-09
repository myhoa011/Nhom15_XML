using QuanLyThueTrangPhuc.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace QuanLyThueTrangPhuc.GiaoDien
{
    public partial class QuanLyHoaDon : Form
    {
        ConnectFile Fxml = new ConnectFile();
        private MenuStrip sharedMenuStrip;
        public QuanLyHoaDon()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GV_HD_SelectionChanged(object sender, EventArgs e)
        {
            int d = GV_HD.CurrentRow.Index;
            string code = GV_HD.Rows[d].Cells[0].Value.ToString();
            hienThiChiTietHoaDon(code);
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            GV_HD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GV_ChitietHDQL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hienThiHoaDon();
            initDgvChiTietHoaDon();
            sharedMenuStrip = menuStrip.CreateMenuStrip();
            Controls.Add(sharedMenuStrip);
            menuStrip.ktQuyenDN(sharedMenuStrip);
        }

        private void hienThiChiTietHoaDon(string code)
        {

            initDgvChiTietHoaDon();
            XDocument doc = XDocument.Load("ChiTietHoaDon.xml");
            var list = doc.Descendants("ChiTietHoaDon");
            string maHD, maSP, soLuongDat, donGia;
            this.GV_ChitietHDQL.Rows.Clear();
            foreach (XElement node in list)
            {
                maHD = node.Element("MaDH").Value.ToString();
                if (maHD == code)
                {
                    maSP = node.Element("MaTP").Value;
                    soLuongDat = node.Element("soLuongDat").Value;
                    donGia = node.Element("donGia").Value;
                    this.GV_ChitietHDQL.Rows.Add(maHD, maSP, soLuongDat, donGia);
                }
            }
        }
        public void initDgvChiTietHoaDon()
        {
            this.GV_ChitietHDQL.ColumnCount = 4;
            this.GV_ChitietHDQL.Columns[0].Name = "Mã hóa đơn";
            this.GV_ChitietHDQL.Columns[1].Name = "Mã trang phục";
            this.GV_ChitietHDQL.Columns[2].Name = "Số lượng đặt";
            this.GV_ChitietHDQL.Columns[3].Name = "Đơn giá";
        }

        private void hienThiHoaDon()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("HoaDon.xml");
            GV_HD.DataSource = dt;
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("HoaDon.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaHD";
            reader.Close();
            int index = dv.Find(tbMaHD_search.Text.Trim());
            if (index == -1)
            {
                MessageBox.Show("Không tìm thấy");
                tbMaHD_search.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã hóa đơn");
                dt.Columns.Add("Mã nhân viên");
                dt.Columns.Add("Tên khách hàng");
                dt.Columns.Add("Ngày tạo");
                dt.Columns.Add("Ngày thuê");
                dt.Columns.Add("Ngày trả");
                dt.Columns.Add("Tổng tiền");
                object[] list = { dv[index]["MaHD"], dv[index]["MaNV"], dv[index]["TenKH"], dv[index]["NgayTao"], dv[index]["NgayThue"], dv[index]["NgayTra"], dv[index]["TongTien"] };
                dt.Rows.Add(list);
                GV_HD.DataSource = dt;
            }
        }

        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            hienThiHoaDon();
        }

        private void bt_TaoHD_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon frm = new ChiTietHoaDon();
            frm.Show();
            this.Visible = false;
        }

        XDocument xItem;
        private void inHoaDon()
        {

            string pathHTML = "HoaDon.html";
            xItem = XDocument.Load("./HoaDon.xml");
            var xI = xItem.Descendants("HoaDon");

            var html = new XElement("html", // Tạo cây HTML trong bộ nhớ
            new XElement("head",
                new XElement("link",
                    new XAttribute("rel", "stylesheet"),
                    new XAttribute("type", "text/css"),
                    new XAttribute("href", "css/bootstrap.min.css")),
            new XElement("style", "h1{color:#874312; text-align: center; margin-top: 50px}", "h2{text-align: center; margin-top:50px; margin-bottom: 20px}", "table{width: 55% !important; margin: 0 auto !important}")),
            new XElement("body",
            new XElement("h1", "CLOTHES STORE"),
            new XElement("h2", "Hoá Đơn"),
            new XElement("table",
                new XAttribute("class", "table table-responsive table-bordered table-hover table-striped"),
                new XElement("tr",
                    new XElement("td", new XAttribute("style", "background-color:#874312; color:white; text-align: center"), "Mã Hoá Đơn"),
                    new XElement("td", new XAttribute("style", "background-color:#874312; color:white; text-align: center"), "Mã Nhân Viên"),
                    new XElement("td", new XAttribute("style", "background-color:#874312; color:white; text-align: center"), "Tên Khách Hàng"),
                    new XElement("td", new XAttribute("style", "background-color:#874312; color:white; text-align: center"), "Ngày Tạo"),
                    new XElement("td", new XAttribute("style", "background-color:#874312; color:white; text-align: center"), "Ngày Thuê"),
                    new XElement("td", new XAttribute("style", "background-color:#874312; color:white; text-align: center"), "Ngày Trả"),
                    new XElement("td", new XAttribute("style", "background-color:#874312; color:white; text-align: center"), "Tổng tiền")),
            from el in xI
            select new XElement("tr",
                        new XElement("td", new XAttribute("style", "text-align: center"), el.Element("MaHD").Value),
                        new XElement("td", new XAttribute("style", "text-align: center"), el.Element("MaNV").Value),
                        new XElement("td", new XAttribute("style", "text-align: center"), el.Element("TenKH").Value),
                        new XElement("td", new XAttribute("style", "text-align: center"), el.Element("NgayTao").Value),
                        new XElement("td", new XAttribute("style", "text-align: center"), el.Element("NgayThue").Value),
                        new XElement("td", new XAttribute("style", "text-align: center"), el.Element("NgayTra").Value),
                        new XElement("td",
                            new XAttribute("style", "text-align:right"),
                            el.Element("TongTien").Value)))));
            html.Save(pathHTML);
            Process.Start(pathHTML);

        }

        private void bt_InHD_Click(object sender, EventArgs e)
        {
            inHoaDon();
        }
    }
}
