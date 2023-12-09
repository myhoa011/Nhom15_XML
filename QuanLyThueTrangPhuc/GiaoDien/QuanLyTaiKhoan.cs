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
using System.Xml;

namespace QuanLyThueTrangPhuc.GiaoDien
{
    public partial class QuanLyTaiKhoan : Form
    {
        ConnectFile Fxml = new ConnectFile();
        TaiKhoan acc = new TaiKhoan();
        string MaNhanVien, Quyen, matKhau;
        string query = "";
        private MenuStrip sharedMenuStrip;
        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            dgvRowSelected();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hienThiTaiKhoan();
            sharedMenuStrip = menuStrip.CreateMenuStrip();
            Controls.Add(sharedMenuStrip);
        }

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!tbTK.Text.Equals(""))
            {
                XmlTextReader reader = new XmlTextReader("TaiKhoan.xml");
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
                    dt.Columns.Add("Mã Nhân Viên");
                    dt.Columns.Add("Mật Khẩu");
                    dt.Columns.Add("Quyền");
                    object[] list = { dv[index]["MaNV"], dv[index]["MatKhau"], dv[index]["Quyen"] };
                    dt.Rows.Add(list);
                    dgvTaiKhoan.DataSource = dt;
                    tbTK.Text = "";
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            hienThiTaiKhoan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            query = "insert";
            tbMNV.Select();
            tbMNV.Enabled = true;
            tbQuyen.Enabled = true;
            btnThem.Enabled = false;
            bt_Luu.Visible = true;
            bt_Huy.Visible = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            tbMNV.Text = tbQuyen.Text = "";
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            MaNhanVien = tbMNV.Text;
            Quyen = tbQuyen.Text;
            if (!string.IsNullOrEmpty(MaNhanVien.Trim()) || !string.IsNullOrEmpty(Quyen.Trim()))
            {
                switch (query)
                {
                    case "insert":
                        if (acc.kiemtra(MaNhanVien) == true)
                        {
                            MessageBox.Show("Mã nhân viên đã tồn tại");
                        }
                        else
                        {
                            acc.themNV(MaNhanVien, matKhau, Quyen);
                            MessageBox.Show("Đã thêm thành công");
                            btnThem.Enabled = true;
                            bt_Luu.Visible = false;
                            bt_Huy.Visible = false;
                            tbMNV.Enabled = false;
                            tbQuyen.Enabled = false;
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            query = "";
                        }
                        break;
                    case "update":
                        acc.suaNV(MaNhanVien, matKhau, Quyen);
                        tbMNV.Enabled = true;
                        btnSua.Enabled = true;
                        bt_Luu.Visible = false;
                        bt_Huy.Visible = false;
                        tbMNV.Enabled = false;
                        tbQuyen.Enabled = false;
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        query = "";
                        break;
                }
                hienThiTaiKhoan();
            }
            else
            {
                MessageBox.Show("Không được bỏ trống!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbMNV.Focus();
                tbMNV.Text = tbQuyen.Text = "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MaNhanVien = tbMNV.Text;
            if (MaNhanVien == "")
            {
                MessageBox.Show("Chọn 1 tài khoản để xóa");
            }
            else
            {
                acc.xoaNV(MaNhanVien);
                hienThiTaiKhoan();
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
            tbQuyen.Enabled = false;
            query = "";
            dgvRowSelected();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tbQuyen.Enabled = true;
            btnSua.Enabled = false;
            bt_Luu.Visible = true;
            bt_Huy.Visible = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            query = "update";
        }

        private void dgvRowSelected()
        {
            int row = dgvTaiKhoan.CurrentRow.Index;
            tbMNV.Text = dgvTaiKhoan.Rows[row].Cells[0].Value.ToString();
            matKhau = dgvTaiKhoan.Rows[row].Cells[1].Value.ToString();
            tbQuyen.Text = dgvTaiKhoan.Rows[row].Cells[2].Value.ToString();
        }
        private void hienThiTaiKhoan()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("TaiKhoan.xml");
            dgvTaiKhoan.DataSource = dt;
        }
    }
}
