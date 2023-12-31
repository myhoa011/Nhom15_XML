﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuanLyThueTrangPhuc.Model
{
    class DanhMuc
    {
        ConnectFile Fxml = new ConnectFile();
        public bool kiemtra(string MaDM)
        {
            XmlTextReader reader = new XmlTextReader("DanhMuc.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaDM";
            reader.Close();
            int index = dv.Find(MaDM);
            if (index == -1)
            {
                return false;
            }
            return true;
        }

        public void themDM(string MaDM, string TenDM)
        {
            string noiDung = "<DanhMuc>" +
                    "<MaDM>" + MaDM + "</MaDM>" +
                    "<TenDM>" + TenDM + "</TenDM>" +
                    "</DanhMuc>";
            Fxml.Them("DanhMuc.xml", noiDung);
        }

        public void suaDM(string MaDM, string TenDM)
        {
            string noiDung = "<MaDM>" + MaDM + "</MaDM>" +
                    "<TenDM>" + TenDM + "</TenDM>";
            Fxml.Sua("DanhMuc.xml", "DanhMuc", "MaDM", MaDM, noiDung);
        }
        public void xoaDM(string MaDM)
        {
            Fxml.Xoa("DanhMuc.xml", "DanhMuc", "MaDM", MaDM);
        }

        public bool checkEmpty(string MaDM, string TenDM)
        {
            if (string.IsNullOrEmpty(MaDM) || string.IsNullOrEmpty(TenDM))
            {
                return false;
            }
            return true;
        }

        public DataTable LoadMaDMP()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("DanhMuc.xml");
            return dt;
        }
    }
}
