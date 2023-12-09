using QuanLyThueTrangPhuc.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyThueTrangPhuc.GiaoDien
{
    public partial class ChiTietHoaDon : Form
    {
        TrangPhuc tp = new TrangPhuc();
        HoaDon hd = new HoaDon();
        public XDocument doc;
        public string path = "./TrangPhuc.xml";
        private MenuStrip sharedMenuStrip;
        public static int soluongcon;
        public ChiTietHoaDon()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void bt_themTP_Click(object sender, EventArgs e)
        {
            if (!hd.ktraTrungTP(tbMaHD.Text, cbb_tenTP.SelectedValue.ToString()))
            {
                MessageBox.Show("Sản Phẩm đã tồn tại");
            }
            else
            {
                hd.themCTHD(tbMaHD.Text, cbb_tenTP.SelectedValue.ToString(), tb_SoLuongThue.Text, tb_DonGia.Text);
                MessageBox.Show("Thêm sản phẩm thành công");
                string message = "Bạn Có muốn thêm sản phẩm mới vào hoá đơn?";
                string title = "Thêm sản phẩm";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    tbMaHD.Enabled = false;
                    tb_tenKH.Enabled = false;
                    hienThiChiTietHoaDon(tbMaHD.Text);
                }
                else
                {
                    clearTextBox();
                }
            }
        }

        public void clearTextBox()
        {
            tbMaHD.Text = tb_tenKH.Text = "";
            tb_SoLuongThue.Text = "0";
            bt_themTP.Visible = false;
            bt_HoaDonMoi.Visible = false;
            tbMaHD.Enabled = true;
            tb_tenKH.Enabled = true;
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            cbb_tenTP.DataSource = tp.LoadMaTP();
            cbb_tenTP.DisplayMember = "TenTP";
            cbb_tenTP.ValueMember = "MaTP";
            initDonGia(cbb_tenTP.SelectedValue.ToString());
            tb_MaNV.Text = QuanLyChung.tenDNMain;
            GV_ChiTietHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sharedMenuStrip = menuStrip.CreateMenuStrip();
            Controls.Add(sharedMenuStrip);
            menuStrip.ktQuyenDN(sharedMenuStrip);
        }
        private void initDonGia(String maTP)
        {
            doc = XDocument.Load(path);
            var list = doc.Descendants("TrangPhuc");
            string group;
            foreach (XElement node in list)
            {
                group = node.Element("MaTP").Value;
                if (maTP == group)
                {
                    tb_DonGia.Text = node.Element("donGia").Value;
                    soluongcon = Int32.Parse(node.Element("soLuong").Value);
                }
            }
        }

        private void cbb_tenTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            initDonGia(cbb_tenTP.SelectedValue.ToString());
        }
        public static int tongtien = 0;
        private void bt_LuuHD_Click(object sender, EventArgs e)
        {
            if (hd.CheckEmpty(tbMaHD.Text.Trim(), tb_tenKH.Text.Trim(), tb_SoLuongThue.Text.Trim()))
            {
                if (hd.kiemtraMaHoaDon(tbMaHD.Text) == true)
                {
                    MessageBox.Show("Mã phiếu đã tồn tại");
                }
                else
                {
                    DateTime dtTao = DateTime.Parse(dt_NgayTao.Text);
                    DateTime dtThue = DateTime.Parse(dt_NgayThue.Text);
                    DateTime dtTra = DateTime.Parse(dt_NgayTra.Text);
                    tongtien = Int32.Parse(tb_SoLuongThue.Text) * Int32.Parse(tb_DonGia.Text);
                    hd.themPN(tbMaHD.Text, tb_tenKH.Text, cbb_tenTP.SelectedValue.ToString(), tb_MaNV.Text, tb_SoLuongThue.Text, tb_DonGia.Text, dtTao.ToString(), dtThue.ToString(), dtTra.ToString(), tongtien);

                    string message = "Bạn Có muốn thêm trang phục mới vào hoá đơn?";
                    string title = "Thêm trang phục";
                    MessageBox.Show("Tạo Hoá Đơn Thành Công");
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        bt_LuuHD.Visible = false;
                        bt_themTP.Visible = true;
                        bt_HoaDonMoi.Visible = true;
                        tbMaHD.Enabled = false;
                        tb_tenKH.Enabled = false;
                        dt_NgayThue.Enabled = false;
                        dt_NgayTra.Enabled = false;
                    }
                    hienThiChiTietHoaDon(tbMaHD.Text);
                }
            }
            else
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin");
                tbMaHD.Text = "";
                tb_SoLuongThue.Text = "";
                tb_tenKH.Text = "";
                tbMaHD.Focus();
            }
        }

        private void hienThiChiTietHoaDon(string code)
        {
            initDgvChiTietHoaDon();
            XDocument doc = XDocument.Load("ChiTietHoaDon.xml");
            var list = doc.Descendants("ChiTietHoaDon");
            string maHD, maTP, soLuongDat, donGia;
            this.GV_ChiTietHD.Rows.Clear();
            foreach (XElement node in list)
            {
                maHD = node.Element("MaDH").Value.ToString();
                if (maHD == code)
                {
                    maTP = node.Element("MaTP").Value;
                    soLuongDat = node.Element("soLuongDat").Value;
                    donGia = node.Element("donGia").Value;
                    this.GV_ChiTietHD.Rows.Add(maHD, maTP, soLuongDat, donGia);
                }
            }
        }
        public void initDgvChiTietHoaDon()
        {
            this.GV_ChiTietHD.ColumnCount = 4;
            this.GV_ChiTietHD.Columns[0].Name = "Mã hóa đơn";
            this.GV_ChiTietHD.Columns[1].Name = "Mã trang phục";
            this.GV_ChiTietHD.Columns[2].Name = "Số lượng đặt";
            this.GV_ChiTietHD.Columns[3].Name = "Đơn giá";
        }


        private void bt_HoaDonMoi_Click(object sender, EventArgs e)
        {
            bt_LuuHD.Visible = true;
            clearTextBox();
        }

        private void ChiTietHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLyHoaDon frm = new QuanLyHoaDon();
            frm.Visible = true;
            this.Visible = false;
        }
    }
}
