using QuanLyThueTrangPhuc.Model;
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
            menuStrip.BackColor = System.Drawing.Color.Beige;

            ToolStripMenuItem gioithieu = new ToolStripMenuItem("Giới thiệu", null, (sender, e) => OnMenuItemClick("GioiThieu"));
            // Add File Menu
            ToolStripMenuItem acc = new ToolStripMenuItem("Tài khoản");
            acc.DropDownItems.Add("Đổi mật khẩu", null, (sender, e) => OnMenuItemClick("DoiMatKhau"));
            acc.DropDownItems.Add("Đăng xuất", null, (sender, e) => OnMenuItemClick("DangXuat"));

            // Add Edit Menu
            ToolStripMenuItem cddl = new ToolStripMenuItem("Chuyển đổi dữ liệu");
            cddl.DropDownItems.Add("SQL sang XML", null, (sender, e) => OnMenuItemClick("sqlxml"));
            cddl.DropDownItems.Add("XML sang SQL", null, (sender, e) => OnMenuItemClick("xmlsql"));

            //Add Management
            ToolStripMenuItem ql = new ToolStripMenuItem("Quản lý");
            ql.DropDownItems.Add("Quản lý danh mục", null, (sender, e) => OnMenuItemClick("QuanLyDM"));
            ql.DropDownItems.Add("Quản lý sản phẩm", null, (sender, e) => OnMenuItemClick("QuanLySP"));
            ql.DropDownItems.Add("Quản lý hóa đơn", null, (sender, e) => OnMenuItemClick("QuanLyHD"));
            ql.DropDownItems.Add(new ToolStripMenuItem("Quản lý nhân viên", null, (sender, e) => OnMenuItemClick("QuanLyNV"))
            {
                Name = "QuanLyNV"
            }) ;
            ql.DropDownItems.Add(new ToolStripMenuItem("Quản lý tài khoản", null, (sender, e) => OnMenuItemClick("QuanLyTK"))
            {
                Name = "QuanLyTK"
            });


            // Add menus to the MenuStrip
            menuStrip.Items.Add(acc);
            menuStrip.Items.Add(cddl);
            menuStrip.Items.Add(ql);
            menuStrip.Items.Add(gioithieu);

            return menuStrip;
        }

        private static void OnMenuItemClick(string itemName)
        {
            // Handle menu item click here
            Console.WriteLine($"Menu item clicked: {itemName}");

            // Open another form based on the menu item
            if (itemName == "GioiThieu")
            {
                MessageBox.Show(" Đặng Thị Mỹ Hòa - 21115053120118 \n Nguyễn Thị Cẩm Ly - 21115053120226 \n Trương Thị Bích Trâm - 21115053120353", "Thành viên nhóm 15");
            }
            else if (itemName == "DoiMatKhau")
            {
                DoiMatKhau frm2 = new DoiMatKhau();
                frm2.Show();
            }
            else if (itemName == "DangXuat")
            {
                Application.Restart();
            }
            else if (itemName == "sqlxml")
            {
                onxmlitemClick();

            }
            else if (itemName == "xmlsql")
            {
                onsqlitemclick();
            }
            else if (itemName == "QuanLyDM")
            {
                onQLDMclick();
            }
            else if (itemName == "QuanLySP")
            {
                onQLSPclick();
            }    
            else if (itemName == "QuanLyNV")
            {
                onQLNVclick();
            }    
            else if (itemName == "QuanLyTK")
            {
                onQLTKclick();
            }
            else if (itemName == "QuanLyHD")
            {
                onQLHDclick();
            }
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
            Chung chung = new Chung();
            try
            {
                chung.CapNhapSQL();
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private static void onQLDMclick()
        {
            Form.ActiveForm.Close();
            QuanLyDanhMuc frm = new QuanLyDanhMuc();
            frm.Show();
        }

        private static void onQLSPclick()
        {
            Form.ActiveForm.Close();
            QuanLyTrangPhuc frm = new QuanLyTrangPhuc();
            frm.Show();
        }

        private static void onQLNVclick()
        {
            Form.ActiveForm.Close();
            QuanLyNhanVien frm = new QuanLyNhanVien();
            frm.Show();
        }

        private static void onQLTKclick()
        {
            Form.ActiveForm.Close();
            QuanLyTaiKhoan frm = new QuanLyTaiKhoan();
            frm.Show();
        }

        private static void onQLHDclick()
        {
            Form.ActiveForm.Close();
            QuanLyHoaDon frm = new QuanLyHoaDon();
            frm.Show();
        }

        public static void HideToolStripMenuItemByName(MenuStrip menuStrip, string itemName)
        {
            foreach (var topLevelItem in menuStrip.Items.OfType<ToolStripMenuItem>())
            {
                foreach (var dropDownItem in topLevelItem.DropDownItems.OfType<ToolStripMenuItem>())
                {
                    if (dropDownItem.Name == itemName)
                    {
                        dropDownItem.Visible = false;
                        return;  // Stop searching after finding the first match
                    }
                }
            }
        }
        public static void ktQuyenDN(MenuStrip menuStrip)
        {
            if (QuanLyChung.quyen == "1")
            {
                HideToolStripMenuItemByName(menuStrip, "QuanLyTK");
                HideToolStripMenuItemByName(menuStrip, "QuanLyNV");
            }
        }
    }
}
