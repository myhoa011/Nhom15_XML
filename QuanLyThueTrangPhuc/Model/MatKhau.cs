using BAITAPCUOIKY.Class;
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
        DangNhap dn = new DangNhap();
        ConnectFile FileXML = new ConnectFile();
        public bool KiemTraMK(string matKhauCu)
        {
            //dn.kiemtraTTDN("TaiKhoan.xml", QuanLyChung.tenDNMain, matKhauCu);
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
