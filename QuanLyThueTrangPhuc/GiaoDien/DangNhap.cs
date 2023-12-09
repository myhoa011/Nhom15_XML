using QuanLyThueTrangPhuc.GiaoDien;
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

namespace QuanLyThueTrangPhuc
{
    public partial class DangNhap : Form
    {
        HeThong ht = new HeThong();
        Dangnhap dn = new Dangnhap();
        public XDocument doc;
        public string path = "./TaiKhoan.xml";
        public DangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            if (tb_TaiKhoan.Text.Equals("") || tb_MatKhau.Text.Equals(""))
            {
                MessageBox.Show("Không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tb_TaiKhoan.Focus();
            }
            else
            {

                if (dn.kiemtraTTDN("TaiKhoan.xml", tb_TaiKhoan.Text, tb_MatKhau.Text))
                {
                    doc = XDocument.Load(path);
                    var list = doc.Descendants("TaiKhoan");
                    string group;
                    foreach (XElement node in list)
                    {
                        group = node.Element("MaNV").Value;
                        if (tb_TaiKhoan.Text == group)
                        {
                            QuanLyChung.quyen = node.Element("Quyen").Value;
                        }
                    }
                    QuanLyChung.tenDNMain = tb_TaiKhoan.Text;
                    QuanLyChung frm = new QuanLyChung();
                    frm.Show();
                    frm.QuyenDangNhap(true);
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_TaiKhoan.Text = "";
                    tb_MatKhau.Text = "";
                    tb_TaiKhoan.Focus();
                }
            }
        }

        private void cb_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_HienMatKhau.Checked)
                tb_MatKhau.UseSystemPasswordChar = false;
            else
                tb_MatKhau.UseSystemPasswordChar = true;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
