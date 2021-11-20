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
    public partial class frm_ThongKeTheTon : DevComponents.DotNetBar.Office2007Form
    {
        public frm_ThongKeTheTon()
        {
            InitializeComponent();
        }
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        ConnectDB con = new ConnectDB();
        private void frm_ThongKeTheTon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            string sql = @"SELECT     tbl_Hang.Ma, tbl_Hang.Ten, tbl_DVT.Ten as TenDVT, tbl_Loai.TenLoai as TenLoai, tbl_Hang.DONGIA, tbl_Hang.Soluong
FROM         tbl_Hang INNER JOIN
                     tbl_DVT ON tbl_Hang.DVT = tbl_DVT.ID INNER JOIN
                      tbl_Loai ON tbl_Hang.LOAI = tbl_Loai.Ma";
            da = new SqlDataAdapter(sql, con.getcon());
            ds = new DataSet();
            da.Fill(ds);
            reportViewer1.Reset();

            dt = ds.Tables[0];
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLBANHANG.Report.rpt_ThongKeTheTon.rdlc";
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