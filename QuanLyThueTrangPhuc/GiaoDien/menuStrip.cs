using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueTrangPhuc.GiaoDien
{
    class menuStrip
    {
        public static MenuStrip CreateMenuStrip()
        {
            MenuStrip menuStrip = new MenuStrip();
            menuStrip.BackColor = System.Drawing.Color.Transparent;
            ToolStripMenuItem trgchu = new ToolStripMenuItem("Trang chủ", null, (sender, e) => OnMenuItemClick("TrangChu"));

            ToolStripMenuItem gioithieu = new ToolStripMenuItem("Giới thiệu", null, (sender, e) => OnMenuItemClick("GioiThieu"));
            // Add File Menu
            ToolStripMenuItem acc = new ToolStripMenuItem("Tài khoản");
            acc.DropDownItems.Add("Đổi mật khẩu", null, (sender, e) => OnMenuItemClick("DoiMatKhau"));

            // Add Edit Menu
            ToolStripMenuItem cddl = new ToolStripMenuItem("Dữ liệu");
            cddl.DropDownItems.Add("SQL-XML", null, (sender, e) => OnMenuItemClick("sqlxml"));
            cddl.DropDownItems.Add("XML-SQL", null, (sender, e) => OnMenuItemClick("xmlsql"));


            // Add menus to the MenuStrip
            menuStrip.Items.Add(trgchu);
            menuStrip.Items.Add(gioithieu);
            menuStrip.Items.Add(acc);
            menuStrip.Items.Add(cddl);

            return menuStrip;
        }

        private static void OnMenuItemClick(string itemName)
        {
            // Handle menu item click here
            Console.WriteLine($"Menu item clicked: {itemName}");

            // Open another form based on the menu item
            if (itemName == "TrangChu")
            {
                ontrangchuitemClick();


            }
            else if (itemName == "GioiThieu")
            {
                MessageBox.Show("Dương Thị Thuận - 21115053120151 \n Đỗ Thị Thanh Nương - 21115053120133 \n Đào Bảo Khuê - 21115053120121", "Thành viên nhóm");
            }
            else if (itemName == "DoiMatKhau")
            {
                Form.ActiveForm.Close();
                frmDoiMatKhau frm2 = new frmDoiMatKhau();
                frm2.Show();
            }
            else if (itemName == "sqlxml")
            {
                onxmlitemClick();

            }
            else if (itemName == "xmlsql")
            {
                onsqlitemclick();
            }
        }
        private static void ontrangchuitemClick()
        {
            Form.ActiveForm.Close();
            TrangChu frm2 = new TrangChu();
            frm2.Show();

        }
        private static void onxmlitemClick()
        {
            HeThong HT = new HeThong();
            try
            {
                HT.TaoXML();
                MessageBox.Show("Tạo XML thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        private static void onsqlitemclick()
        {
            HeThong HT = new HeThong();
            try
            {
                HT.CapNhapSQL();
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
}
