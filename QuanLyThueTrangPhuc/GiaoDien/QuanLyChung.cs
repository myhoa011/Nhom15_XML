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

namespace QuanLyThueTrangPhuc.GiaoDien
{
    public partial class QuanLyChung : Form
    {
        public static string tenDNMain = "";
        public static string quyen = "";
        Chung chung = new Chung();
        HeThong HT = new HeThong();
        ConnectFile Fxml = new ConnectFile();
        private MenuStrip sharedMenuStrip;
        public QuanLyChung()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void QuanLyChung_Load(object sender, EventArgs e)
        {
            sharedMenuStrip = menuStrip.CreateMenuStrip();
            Controls.Add(sharedMenuStrip);


        }

        private void pictureBoxHoadon_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon hd = new QuanLyHoaDon();
            hd.Show();
            this.Visible = false;
        }

        private void pictureBoxSanpham_Click(object sender, EventArgs e)
        {
            QuanLyTrangPhuc sp = new QuanLyTrangPhuc();
            sp.Show();
            this.Visible = false;
        }

        private void pictureBoxNhanvien_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien nv = new QuanLyNhanVien();
            nv.Show();
            this.Visible = false;
        }

        private void pictureBoxDanhMuc_Click(object sender, EventArgs e)
        {
            QuanLyDanhMuc dm = new QuanLyDanhMuc();
            dm.Show();
            this.Visible = false;
        }

        private void pictureBoxTaikhoan_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan tk = new QuanLyTaiKhoan();
            tk.Show();
            this.Visible = false;
        }
        void ThongTinDangNhap()
        {

            lblTen.Text = "Họ tên: ";
            lblTen.Text = lblTen.Text + chung.HoTen(tenDNMain);
        }
        public void QuyenDangNhap(bool e)
        {
            lblChucVu.Visible = e;
            lblTen.Visible = e;
            lblChucVu.Text = "Chức vụ: ";
            if (quyen.Equals("2"))
            {
                lblChucVu.Visible = e;
                lblTen.Visible = e;
                lblChucVu.Text = lblChucVu.Text + "Quản Trị Viên";
            }
            else
            {
                lblChucVu.Text = lblChucVu.Text + "Nhân Viên";
                pictureBoxNhanvien.Visible = false;
                pictureBoxTaikhoan.Visible = false;
                label5.Visible = false;
                label4.Visible = false;
                menuStrip.HideToolStripMenuItemByName(sharedMenuStrip, "QuanLyTK");
                menuStrip.HideToolStripMenuItemByName(sharedMenuStrip, "QuanLyNV");
            }
            if (e) ThongTinDangNhap();
        }

    }
}
