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
    public partial class QuanLyTrangPhuc : Form
    {
        ConnectFile Fxml = new ConnectFile();
        TrangPhuc tp = new TrangPhuc();
        DanhMuc dm = new DanhMuc();
        string maTP, tenTP, donGia, soLuong, maDM;
        private MenuStrip sharedMenuStrip;
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            hienThiSanPham();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            query = "insert";
            tbMTP.Select();
            tbMTP.Enabled = true;
            tbTTP.Enabled = true;
            cbbDM.Enabled = true;
            tbDG.Enabled = true;
            tbSL.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            tbMTP.Text = tbTTP.Text = tbDG.Text = tbSL.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            maTP = tbMTP.Text.Trim();
            tenTP = tbTTP.Text.Trim();
            donGia = tbDG.Text.Trim();
            soLuong = tbSL.Text.Trim();
            maDM = cbbDM.SelectedValue.ToString().Trim();
            if (tp.checkEmpty(maTP, tenTP, donGia, soLuong, maDM))
            {
                switch (query)
                {
                    case "insert":
                        if (tp.kTraTonTai(maTP))
                        {
                            MessageBox.Show("Mã sản phẩm đã tồn tại");
                        }
                        else
                        {
                            tp.themTP(maTP, tenTP, donGia, soLuong, maDM);
                            MessageBox.Show("Thêm thành công!!!");
                            btnThem.Enabled = true;
                            btnLuu.Visible = false;
                            btnHuy.Visible = false;
                            tbMTP.Enabled = false;
                            tbTTP.Enabled = false;
                            cbbDM.Enabled = false;
                            tbDG.Enabled = false;
                            tbSL.Enabled = false;
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            query = "";
                        }
                        break;

                    case "update":
                        tp.suaTP(maTP, tenTP, donGia, soLuong, maDM);
                        tbMTP.Enabled = false;
                        btnSua.Enabled = true;
                        btnLuu.Visible = false;
                        btnHuy.Visible = false;
                        tbTTP.Enabled = false;
                        cbbDM.Enabled = false;
                        tbDG.Enabled = false;
                        tbSL.Enabled = false;
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        query = "";
                        break;
                }
                hienThiSanPham();
            }
            else
            {
                MessageBox.Show("Không được bỏ trống!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbMTP.Text == "")
            {
                MessageBox.Show("Chọn 1 trang phục để xóa");
            }
            else
            {
                tp.xoaTP(tbMTP.Text);
                hienThiSanPham();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Visible = false;
            btnLuu.Visible = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            tbMTP.Enabled = false;
            tbTTP.Enabled = false;
            cbbDM.Enabled = false;
            tbDG.Enabled = false;
            tbSL.Enabled = false;
            query = "";
            dgvRowSelected();
        }

        private void dgvTrangPhuc_SelectionChanged(object sender, EventArgs e)
        {
            dgvRowSelected();
        }
        private void dgvRowSelected()
        {
            int row = dgvTrangPhuc.CurrentRow.Index;
            tbMTP.Text = dgvTrangPhuc.Rows[row].Cells[0].Value.ToString();
            tbTTP.Text = dgvTrangPhuc.Rows[row].Cells[1].Value.ToString();
            tbDG.Text = dgvTrangPhuc.Rows[row].Cells[2].Value.ToString();
            tbSL.Text = dgvTrangPhuc.Rows[row].Cells[3].Value.ToString();
            cbbDM.SelectedValue = dgvTrangPhuc.Rows[row].Cells[4].Value.ToString();
        }

        private void QuanLyTrangPhuc_Load(object sender, EventArgs e)
        {
            cbbDM.DataSource = dm.LoadMaDMP();
            cbbDM.DisplayMember = "TenDM";
            cbbDM.ValueMember = "MaDM";
            dgvTrangPhuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hienThiSanPham();
            sharedMenuStrip = menuStrip.CreateMenuStrip();
            Controls.Add(sharedMenuStrip);
            menuStrip.ktQuyenDN(sharedMenuStrip);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tbMTP.Enabled = false;
            tbTTP.Enabled = true;
            cbbDM.Enabled = true;
            tbDG.Enabled = true;
            tbSL.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            query = "update";
        }

        private void hienThiSanPham()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("TrangPhuc.xml");
            dgvTrangPhuc.DataSource = dt;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!tbTK.Text.Equals(""))
            {
                XmlTextReader reader = new XmlTextReader("TrangPhuc.xml");
                DataSet ds = new DataSet();
                ds.ReadXml(reader);
                DataView dv = new DataView(ds.Tables[0]);
                dv.Sort = "MaTP";
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
                    dt.Columns.Add("Mã trang phục");
                    dt.Columns.Add("Tên trang phục");
                    dt.Columns.Add("Đơn giá");
                    dt.Columns.Add("Số lượng");
                    dt.Columns.Add("Mã danh mục");
                    object[] list = { dv[index]["MaTP"], dv[index]["TenTP"], dv[index]["DonGia"], dv[index]["SoLuong"], dv[index]["MaDM"] };
                    dt.Rows.Add(list);
                    dgvTrangPhuc.DataSource = dt;
                    tbTK.Text = "";
                }
            }
        }

        string query = "";
        public QuanLyTrangPhuc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
