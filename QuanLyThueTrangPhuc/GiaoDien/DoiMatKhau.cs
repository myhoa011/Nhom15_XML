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
    public partial class DoiMatKhau : Form
    {
        Dangnhap dn = new Dangnhap();
        MatKhau dmk = new MatKhau();
        public DoiMatKhau()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void bt_LuuThayDoi_Click(object sender, EventArgs e)
        {
            if (LoadDuLieu())
            {
                if (MessageBox.Show("Bạn có chắc muốn đổi mật khẩu không?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dmk.Doi(tb_MatKhauMoi.Text);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    Close();
                }
            }

        }

        bool LoadDuLieu()
        {
            if (!dmk.KiemTraMK(tb_MatKhauCu.Text))
            {
                MessageBox.Show("Nhập sai mật khẩu cũ");
                return false;
            }
            if (!tb_MatKhauMoi.Text.Equals(tb_NhaplaiPass.Text))
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp");
                return false;
            }
            return true;
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
