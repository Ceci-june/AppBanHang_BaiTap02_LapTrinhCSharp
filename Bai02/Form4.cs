using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bai02.DAO;
using Microsoft.Reporting.WinForms;

namespace Bai02
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadReport();
            this.reportViewer1.RefreshReport();
        }
        private void LoadReport()
        {
            //string query = "SELECT * FROM SHOPPINGPRODUCT";
            //DataProvider dp = new DataProvider();
            //DataTable dt = dp.ExecuteQuery(query);
            //DataSet ds = new DataSet();
            //ds.Tables.Add(dt);

            //reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    ReportDataSource rds = new ReportDataSource();
            //    rds.Name = "ShoppingDataset";
            //    rds.Value = ds.Tables[0];
            //    reportViewer1.LocalReport.DataSources.Clear();
            //    reportViewer1.LocalReport.DataSources.Add(rds);
            //    //reportViewer1.RefreshReport();
            //}
            LoadReportTest();
        }
        public void LoadReportTest()
        {
            
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "..//..//Report1.rdlc"; //để file report trong Debug của project

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "DataSet1"; //Đặt đúng tên khi đặt trong report -- có tên mặc định là DataSet1
            dts.Value = Form1.cart;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dts);

            ReportParameter para1 = new ReportParameter();
            para1.Name = "TenKH"; //Đặt đúng tên khi đặt trong report
            para1.Values.Add(Bai02.Custom.UserControl3.infor[2]);

            ReportParameter para2 = new ReportParameter();
            para2.Name = "DiaChi";
            para2.Values.Add(Bai02.Custom.UserControl3.infor[4]);
            ReportParameter para3 = new ReportParameter();
            para3.Name = "SoDT";
            para3.Values.Add(Bai02.Custom.UserControl3.infor[3]);
            ReportParameter para4 = new ReportParameter();
            para4.Name = "ThoiGian";
            para4.Values.Add(Bai02.Custom.UserControl3.infor[0]);
            ReportParameter para5 = new ReportParameter();
            para5.Name = "GioiTinh";
            para5.Values.Add(Bai02.Custom.UserControl3.infor[1]);
            ReportParameter para6 = new ReportParameter();
            para6.Name = "TongTien";
            para6.Values.Add(Bai02.Custom.UserControl3.infor[5]);
            ReportParameter para7 = new ReportParameter();
            para7.Name = "GiamGia";
            para7.Values.Add(Bai02.Custom.UserControl3.infor[6]);
            ReportParameter para8 = new ReportParameter();
            para8.Name = "ThanhToan";
            para8.Values.Add(Bai02.Custom.UserControl3.infor[7]);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { para1, para2, para3, para4,para5,para6,para7,para8 });
        }
    }
}
