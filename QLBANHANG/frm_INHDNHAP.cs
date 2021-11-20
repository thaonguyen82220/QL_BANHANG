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
    public partial class frm_INHDNHAP : DevComponents.DotNetBar.Office2007Form
    {
        public frm_INHDNHAP()
        {
            InitializeComponent();
        }
        public string MaHD { get; set; }
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        ConnectDB con = new ConnectDB();
        private void frm_INHDNHAP_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();

            string sql = @"SELECT        tbl_PhieuNhap.IDPN, tbl_NhaCungCap.TENNCC, tbl_PhieuNhap.TONGTIEN, tbl_PhieuNhap.NGAY, tbl_HANG.Ten, tbl_PhieuNhapChiTiet.SL, 
                         tbl_PhieuNhapChiTiet.DonGia, tbl_PhieuNhapChiTiet.SL * tbl_PhieuNhapChiTiet.DonGia AS thanhtien, tbl_PhieuNhapChiTiet.HANG
FROM            tbl_PhieuNhap INNER JOIN
                         tbl_PhieuNhapChiTiet ON tbl_PhieuNhap.IDPN = tbl_PhieuNhapChiTiet.ID_PN INNER JOIN
                         tbl_HANG ON tbl_PhieuNhapChiTiet.HANG = tbl_HANG.Ma INNER JOIN
                         tbl_NhaCungCap ON tbl_PhieuNhap.NCC = tbl_NhaCungCap.mancc where   tbl_PhieuNhap.IDPN='" + MaHD + "'";
            da = new SqlDataAdapter(sql, con.getcon());
            ds = new DataSet();
            da.Fill(ds);
            reportViewer1.Reset();

            dt = ds.Tables[0];
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLBANHANG.Report.rpt_PhieuNhaphang.rdlc";
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