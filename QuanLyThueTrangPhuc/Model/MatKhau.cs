using QuanLyThueTrangPhuc.GiaoDien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueTrangPhuc.Model
{
    class MatKhau
    {
        Dangnhap dn = new Dangnhap();
        ConnectFile FileXML = new ConnectFile();
        public bool KiemTraMK(string matKhauCu)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = FileXML.HienThi("TaiKhoan.xml");
                dt.DefaultView.RowFilter = "MaNV ='" + QuanLyChung.tenDNMain + "' AND MatKhau ='" + matKhauCu + "'";
                if (dt.DefaultView.Count > 0)
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }
        public void Doi(string matKhauMoi)
        {
            dn.DoiMatKhau(QuanLyChung.tenDNMain, matKhauMoi);
        }
    }
}
