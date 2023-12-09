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
    public partial class QuanLyDanhMuc : Form
    {
        ConnectFile Fxml = new ConnectFile();
        DanhMuc dm = new DanhMuc();
        string MaDM, TenDM;
        string query = "";
        private MenuStrip sharedMenuStrip;

        private void QuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            GV_DanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hienThiDanhMuc();
            sharedMenuStrip = menuStrip.CreateMenuStrip();
            Controls.Add(sharedMenuStrip);
            menuStrip.ktQuyenDN(sharedMenuStrip);
        }

        private void hienThiDanhMuc()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("DanhMuc.xml");
            GV_DanhMuc.DataSource = dt;
        }

        private void GV_DanhMuc_SelectionChanged(object sender, EventArgs e)
        {
            dgvRowSelected();
        }

        private void dgvRowSelected()
        {
            int row = GV_DanhMuc.CurrentRow.Index;
            tb_MaDanhMuc.Text = GV_DanhMuc.Rows[row].Cells[0].Value.ToString();
            tb_TenDanhMuc.Text = GV_DanhMuc.Rows[row].Cells[1].Value.ToString();
        }

        private void bt_TKDanhMuc_Click(object sender, EventArgs e)
        {
            if (!tb_TK.Text.Equals(""))
            {
                XmlTextReader reader = new XmlTextReader("DanhMuc.xml");
                DataSet ds = new DataSet();
                ds.ReadXml(reader);
                DataView dv = new DataView(ds.Tables[0]);
                dv.Sort = "MaDM";
                reader.Close();
                int index = dv.Find(tb_TK.Text);
                if (index == -1)
                {
                    MessageBox.Show("Không tìm thấy");
                    tb_TK.Focus();
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Mã danh mục");
                    dt.Columns.Add("Tên danh mục");
                    object[] list = { dv[index]["MaDM"], dv[index]["TenDM"] };
                    dt.Rows.Add(list);
                    GV_DanhMuc.DataSource = dt;
                    tb_TK.Text = "";
                }
            }
        }

        private void bt_LMoiDanhMuc_Click(object sender, EventArgs e)
        {
            hienThiDanhMuc();
        }

        private void bt_ThemDM_Click(object sender, EventArgs e)
        {
            query = "insert";
            tb_MaDanhMuc.Select();
            tb_MaDanhMuc.Enabled = true;
            tb_TenDanhMuc.Enabled = true;
            bt_ThemDM.Enabled = false;
            bt_LuuDM.Visible = true;
            bt_HuyDM.Visible = true;
            bt_LuuDM.Enabled = true;
            bt_XoaDM.Enabled = false;
            bt_SuaDM.Enabled = false;
            tb_MaDanhMuc.Text = tb_TenDanhMuc.Text = "";
        }

        private void bt_LuuDM_Click(object sender, EventArgs e)
        {
            MaDM = tb_MaDanhMuc.Text;
            TenDM = tb_TenDanhMuc.Text;
            if (!string.IsNullOrEmpty(MaDM.Trim()) || !string.IsNullOrEmpty(TenDM.Trim()))
            {
                switch (query)
                {
                    case "insert":
                        if (dm.kiemtra(MaDM) == true)
                        {
                            MessageBox.Show("Mã danh mục đã tồn tại");
                        }
                        else
                        {
                            dm.themDM(MaDM, TenDM);
                            MessageBox.Show("Đã thêm thành công");
                            bt_ThemDM.Enabled = true;
                            bt_LuuDM.Visible = false;
                            bt_HuyDM.Visible = false;
                            tb_MaDanhMuc.Enabled = false;
                            tb_TenDanhMuc.Enabled = false;
                            bt_SuaDM.Enabled = true;
                            bt_XoaDM.Enabled = true;
                            query = "";
                        }
                        break;
                    case "update":
                        dm.suaDM(MaDM, TenDM);
                        tb_MaDanhMuc.Enabled = true;
                        bt_SuaDM.Enabled = true;
                        bt_LuuDM.Visible = false;
                        bt_HuyDM.Visible = false;
                        tb_MaDanhMuc.Enabled = false;
                        tb_TenDanhMuc.Enabled = false;
                        bt_ThemDM.Enabled = true;
                        bt_XoaDM.Enabled = true;
                        query = "";
                        break;
                }
                hienThiDanhMuc();
            }
            else
            {
                MessageBox.Show("Không được bỏ trống!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tb_MaDanhMuc.Focus();
                tb_MaDanhMuc.Text = tb_TenDanhMuc.Text = "";
            }
        }

        private void bt_XoaDM_Click(object sender, EventArgs e)
        {
            MaDM = tb_MaDanhMuc.Text;
            if (MaDM == "")
            {
                MessageBox.Show("Chọn 1 danh mục để xóa");
            }
            else
            {
                dm.xoaDM(MaDM);
                hienThiDanhMuc();
            }
        }

        private void bt_HuyDM_Click(object sender, EventArgs e)
        {
            bt_HuyDM.Visible = false;
            bt_LuuDM.Visible = false;
            bt_ThemDM.Enabled = true;
            bt_SuaDM.Enabled = true;
            bt_XoaDM.Enabled = true;
            tb_MaDanhMuc.Enabled = false;
            tb_TenDanhMuc.Enabled = false;
            query = "";
            dgvRowSelected();
        }

        private void bt_SuaDM_Click(object sender, EventArgs e)
        {
            tb_TenDanhMuc.Enabled = true;
            bt_SuaDM.Enabled = false;
            bt_LuuDM.Visible = true;
            bt_HuyDM.Visible = true;
            bt_ThemDM.Enabled = false;
            bt_XoaDM.Enabled = false;
            query = "update";
        }

        public QuanLyDanhMuc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
