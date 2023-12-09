using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace QuanLyThueTrangPhuc.Model
{
    class ConnectFile
    {
        string Conn = @"Data Source=localhost; Initial Catalog = dbQUANLYTHUETRANGPHUC; Integrated Security=true";
        public DataTable HienThi(string file)
        {
            DataTable dt = new DataTable();
            string FilePath = Application.StartupPath + "\\" + file;
            if (File.Exists(FilePath))
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(FilePath);
                dt = dataSet.Tables[0];
            }
            else
            {
                MessageBox.Show("File XML '" + file + "' không tồn tại");
            }

            return dt;
        }
        /* public DataTable GhiFile(string file)
         {
             DataTable dt = new DataTable();
             string FilePath = Application.StartupPath + "\\" + file;
             if (File.Exists(FilePath))
             {
                 FileStream fsWriteXML = new FileStream(FilePath, FileMode.Open);
                 dt.WriteXml(fsWriteXML);
                 fsWriteXML.Close();
             }
             else
             {
                 MessageBox.Show("File XML '" + file + "' không tồn tại");
             }

             return dt;
         }*/
        public void TaoXML(string bang)
        {
            SqlConnection con = new SqlConnection(Conn);
            con.Open();
            string sql = "SELECT ( SELECT * FROM " + bang + " FOR XML PATH('" + bang + "'), TYPE)";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable("'" + bang + "'");
            ad.Fill(dt);
            string xml = "<?xml version='1.0'?><" + bang + "s>";
            xml += dt.Rows[0].ItemArray[0].ToString() + "</" + bang + "s>";
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.LoadXml(xml);
            XmlDoc.Save(bang + ".xml");
        }
        public void Them(string duongDan, string noiDung)
        {
            XmlTextReader reader = new XmlTextReader(duongDan);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();
            XmlNode currNode;
            XmlDocumentFragment docFrag = doc.CreateDocumentFragment();
            docFrag.InnerXml = noiDung;
            currNode = doc.DocumentElement;
            currNode.InsertAfter(docFrag, currNode.LastChild);
            doc.Save(duongDan);
        }
        public void Xoa(string duongDan, string tenFileXML, string xoaTheoTruong, string giaTriTruong)
        {
            string fileName = Application.StartupPath + "\\" + duongDan;
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode nodeCu = doc.SelectSingleNode("//" + tenFileXML + "[" + xoaTheoTruong + "='" + giaTriTruong + "']");
            doc.DocumentElement.RemoveChild(nodeCu);
            doc.Save(fileName);
        }

        public void Sua(string duongDan, string tenFile, string suaTheoTruong, string giaTriTruong, string noiDung)
        {

            XmlTextReader reader = new XmlTextReader(duongDan);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();
            XmlNode oldHang;
            XmlElement root = doc.DocumentElement;
            oldHang = root.SelectSingleNode("//" + tenFile + "[" + suaTheoTruong + "='" + giaTriTruong + "']");
            XmlElement newhang = doc.CreateElement(tenFile);
            newhang.InnerXml = noiDung;
            root.ReplaceChild(newhang, oldHang);
            doc.Save(duongDan);

        }
        public string LayGiaTri(string duongDan, string truongA, string giaTriA, string truongB)
        {
            string giatriB = "";
            DataTable dt = new DataTable();
            dt = HienThi(duongDan);
            int soDongNhanVien = dt.Rows.Count;
            for (int i = 0; i < soDongNhanVien; i++)
            {
                if (dt.Rows[i][truongA].ToString().Trim().Equals(giaTriA))
                {
                    giatriB = dt.Rows[i][truongB].ToString();
                    return giatriB;
                }
            }
            return giatriB;
        }
        public void DoiMatKhau(string nguoiDung, string matKhau)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(Application.StartupPath + "\\NhanVien.xml");
            XmlNode node1 = doc1.SelectSingleNode("//NhanVien[MaNV = '" + nguoiDung + "']");
            if (node1 != null)
            {
                node1.ChildNodes[1].InnerText = matKhau;
                doc1.Save(Application.StartupPath + "\\NhanVien.xml");
            }
        }
        public void TimKiemXSLT(string data, string tenFileXML, string tenfileXSLT)
        {

            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("\\" + tenfileXSLT + ".xslt");
            // Create the XsltArgumentList.
            XsltArgumentList argList = new XsltArgumentList();
            // Calculate the discount date.
            argList.AddParam("Data", "", data);
            // Create an XmlWriter to write the output.             
            XmlWriter writer = XmlWriter.Create("\\" + tenFileXML + ".html");
            // Transform the file.
            xslt.Transform(new XPathDocument("\\" + tenFileXML + ".xml"), argList, writer);
            writer.Close();
            Process.Start("\\" + tenFileXML + ".html");


        }
        public void InsertOrUpDateSQL(string sql)
        {
            SqlConnection con = new SqlConnection(Conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
