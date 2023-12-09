using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueTrangPhuc.Model
{
    class Chung
    {
        ConnectFile Fxml = new ConnectFile();
        public string HoTen(string MaNhanVien)
        {
            return Fxml.LayGiaTri("NhanVien.xml", "MaNV", MaNhanVien, "TenNV");
        }
        void CapNhapTungBang(string tenBang)
        {
            string duongDan = @"" + tenBang + ".xml";
            DataTable table = Fxml.HienThi(duongDan);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string sql = "insert into " + tenBang + " values(";
                for (int j = 0; j < table.Columns.Count - 1; j++)
                {
                    sql += "N'" + table.Rows[i][j].ToString().Trim() + "',";
                }
                sql += "N'" + table.Rows[i][table.Columns.Count - 1].ToString().Trim() + "'";
                sql += ")";
                //MessageBox.Show(sql);
                Fxml.InsertOrUpDateSQL(sql);
            }
        }


        public void CapNhapSQL()
        {
            //Xóa toàn bộ dữ liệu các bảng
            Fxml.InsertOrUpDateSQL("delete from NhanVien");
            Fxml.InsertOrUpDateSQL("delete from TaiKhoan");
            Fxml.InsertOrUpDateSQL("delete from HoaDon");
            Fxml.InsertOrUpDateSQL("delete from TrangPhuc");
            Fxml.InsertOrUpDateSQL("delete from ChiTietHoaDon");
            Fxml.InsertOrUpDateSQL("delete from DanhMuc");

            //Cập nhập toàn bộ dữ liệu các bảng
            CapNhapTungBang("NhanVien");
            CapNhapTungBang("TaiKhoan");
            CapNhapTungBang("HoaDon");
            CapNhapTungBang("TrangPhuc");
            CapNhapTungBang("ChiTietHoaDon");
            CapNhapTungBang("DanhMuc");
        }
    }
}
