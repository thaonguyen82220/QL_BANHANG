using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;

namespace QLBANHANG
{
    public partial class frm_ThongKeKhachHang : DevComponents.DotNetBar.Office2007Form
    {
        public frm_ThongKeKhachHang()
        {
            InitializeComponent();
        }
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        ConnectDB con = new ConnectDB();
        private void frm_ThongKeKhachHang_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();

            string sql = @"SELECT        tbl_KhachHang.*
FROM            tbl_KhachHang";
            da = new SqlDataAdapter(sql, con.getcon());
            ds = new DataSet();
            da.Fill(ds);
            reportViewer1.Reset();

            dt = ds.Tables[0];
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLBANHANG.Report.rpt_ThongKeKhachHang.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource newDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(newDataSource);
            reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DisplayName = "Báo Cáo";
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomPercent = 50;
        }
    }
}