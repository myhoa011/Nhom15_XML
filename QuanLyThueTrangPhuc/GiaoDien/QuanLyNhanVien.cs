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
    public partial class QuanLyNhanVien : Form
    {
        ConnectFile Fxml = new ConnectFile();
        NhanVien nv = new NhanVien();
        string MaNhanVien, TenNhanVien, DiaChi, SDT, Email;
        private MenuStrip sharedMenuStrip;
        private void btnThem_Click(object sender, EventArgs e)
        {
            query = "insert";
            tbMNV.Select();
            tbMNV.Enabled = true;
            tbTNV.Enabled = true;
            tbDiaChi.Enabled = true;
            tbSDT.Enabled = true;
            tbEmail.Enabled = true;
            btnThem.Enabled = false;
            bt_Luu.Visible = true;
            bt_Huy.Visible = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            tbEmail.Text = tbMNV.Text = tbSDT.Text = tbTNV.Text = tbDiaChi.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("NhanVien.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaNV";
            reader.Close();
            int index = dv.Find(tbTK.Text);
            if (index == -1)
            {
                MessageBox.Show("Không tìm thấy");
                tbTK.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã nhân viên");
                dt.Columns.Add("Họ và tên");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("Số điện thoại");
                dt.Columns.Add("Email");
                object[] list = { dv[index]["MaNV"], dv[index]["TenNV"], dv[index]["DiaChi"], dv[index]["SDT"], dv[index]["Email"] };
                dt.Rows.Add(list);
                dgvNhanVien.DataSource = dt;
                tbTK.Text = "";
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            hienthiNhanVien();
        }
        public void hienthiNhanVien()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("NhanVien.xml");
            dgvNhanVien.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tbMNV.Enabled = false;
            tbTNV.Enabled = true;
            tbDiaChi.Enabled = true;
            tbSDT.Enabled = true;
            tbEmail.Enabled = true;
            btnSua.Enabled = false;
            bt_Luu.Visible = true;
            bt_Huy.Visible = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            query = "update";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MaNhanVien = tbMNV.Text;
            if (MaNhanVien == "")
            {
                MessageBox.Show("Chọn 1 nhân viên để xóa");
            }
            else
            {
                nv.xoaNV(MaNhanVien);
                hienthiNhanVien();
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            MaNhanVien = tbMNV.Text;
            TenNhanVien = tbTNV.Text;
            DiaChi = tbDiaChi.Text;
            SDT = tbSDT.Text;
            Email = tbEmail.Text;
            if (nv.checkEmpty(MaNhanVien.Trim(), TenNhanVien.Trim(), DiaChi.Trim(), SDT.Trim(), Email.Trim()))
            {
                switch (query)
                {
                    case "insert":
                        if (nv.kiemtra(MaNhanVien))
                        {
                            MessageBox.Show("Mã nhân viên đã tồn tại");
                        }
                        else
                        {
                            nv.themNV(MaNhanVien, TenNhanVien, DiaChi, SDT, Email);
                            MessageBox.Show("Đã thêm thành công");
                            btnThem.Enabled = true;
                            bt_Luu.Visible = false;
                            bt_Huy.Visible = false;
                            tbMNV.Enabled = false;
                            tbTNV.Enabled = false;
                            tbDiaChi.Enabled = false;
                            tbSDT.Enabled = false;
                            tbEmail.Enabled = false;
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            query = "";
                        }
                        break;
                    case "update":
                        nv.suaNV(MaNhanVien, TenNhanVien,DiaChi, SDT, Email);
                        tbMNV.Enabled = true;
                        btnSua.Enabled = true;
                        bt_Luu.Visible = false;
                        bt_Huy.Visible = false;
                        tbMNV.Enabled = false;
                        tbTNV.Enabled = false;
                        tbDiaChi.Enabled = false;
                        tbSDT.Enabled = false;
                        tbEmail.Enabled = false;
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        query = "";
                        break;
                }
                hienthiNhanVien();
            }
            else
            {
                MessageBox.Show("Không được bỏ trống!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            bt_Huy.Visible = false;
            bt_Luu.Visible = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            tbMNV.Enabled = false;
            tbTNV.Enabled = false;
            tbDiaChi.Enabled = false;
            tbSDT.Enabled = false;
            tbEmail.Enabled = false;
            query = "";
            dgvRowSelected();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            inNhanVien();
        }
        XDocument xItem;
        private void inNhanVien()
        {
            string pathHTML = "NhanVien.html";
            xItem = XDocument.Load("./NhanVien.xml");

            var xI = xItem.Descendants("NhanVien");
            var html = new XElement("html", // Tạo cây HTML trong bộ nhớ
            new XElement("head",
            new XElement("link",
                    new XAttribute("rel", "stylesheet"),
                    new XAttribute("type", "text/css"),
                    new XAttribute("href", "css/bootstrap.min.css")),
            new XElement("style", "h1{color:#874312; text-align: center; margin-top: 50px}", "h2{text-align: center; margin-top:50px; margin-bottom: 20px}", "table{width: 55% !important; margin: 0 auto !important}")),
            new XElement("body",
            new XElement("h1", "CLOTHES STORE"),
            new XElement("h2", "Danh sách nhân Viên"),
            new XElement("table",
                new XAttribute("class", "table table-responsive table-bordered table-hover table-striped"),
                new XElement("tr",
                    new XElement("td", new XAttribute("style", "background-color:#874312; color:white; text-align: center"), "Mã Nhân Viên"),
                    new XElement("td", new XAttribute("style", "background-color:#874312; color:white; text-align: center"), "Họ Tên"),
                    new XElement("td", new XAttribute("style", "background-color:#874312; color:white; text-align: center"), "Địa Chỉ"),
                    new XElement("td", new XAttribute("style", "background-color:#874312; color:white; text-align: center"), "Email"),
                    new XElement("td", new XAttribute("style", "background-color:#874312; color:white; text-align: center"), "Số Điện Thoại")),
            from el in xI
            select new XElement("tr",
                        new XElement("td", new XAttribute("style", "text-align: center"), el.Element("MaNV").Value),
                        new XElement("td", el.Element("TenNV").Value),
                        new XElement("td", el.Element("DiaChi").Value),
                        new XElement("td", el.Element("Email").Value),
                        new XElement("td",
                            new XAttribute("style", "text-align:right"),
                            el.Element("SDT").Value)))));
            html.Save(pathHTML);
            Process.Start(pathHTML);
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hienthiNhanVien();
            sharedMenuStrip = menuStrip.CreateMenuStrip();
            Controls.Add(sharedMenuStrip);
        }

        string query = "";
        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            dgvRowSelected();
        }

        private void dgvRowSelected()
        {
            int d = dgvNhanVien.CurrentRow.Index;
            tbMNV.Text = dgvNhanVien.Rows[d].Cells[0].Value.ToString();
            tbTNV.Text = dgvNhanVien.Rows[d].Cells[1].Value.ToString();
            tbDiaChi.Text = dgvNhanVien.Rows[d].Cells[2].Value.ToString();
            tbSDT.Text = dgvNhanVien.Rows[d].Cells[3].Value.ToString();
            tbEmail.Text = dgvNhanVien.Rows[d].Cells[4].Value.ToString();
        }

        public QuanLyNhanVien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
