using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueTrangPhuc.Model
{
    class HeThong
    {
        ConnectFile connect = new ConnectFile();
        public void TaoXML()
        {
            connect.TaoXML("TaiKhoan");
            connect.TaoXML("NhanVien");
            connect.TaoXML("TrangPhuc");
            connect.TaoXML("HoaDon");
            connect.TaoXML("ChiTietHoaDon");
            connect.TaoXML("DanhMuc");
        }
    }
}
