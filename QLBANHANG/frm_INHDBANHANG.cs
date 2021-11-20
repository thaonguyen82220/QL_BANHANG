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
    public partial class frm_INHDBANHANG : DevComponents.DotNetBar.Office2007Form
    {
        public frm_INHDBANHANG()
        {
            InitializeComponent();
        }

        public string MaHD { get; set; }
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        ConnectDB con = new ConnectDB();
        private void frm_INHDBANHANG_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            string sql = @"SELECT        tbl_PhieuBanHang.IDPHIEU, tbl_KhachHang.tenkh, tbl_PhieuBanHang.NGAYLAP, tbl_NhanVien.tennv, tbl_PhieuBanHang.TongTien, tbl_HANG.Ten, 
                         tbl_PhieuBanChiTiet.SL, tbl_PhieuBanChiTiet.DonGia, tbl_PhieuBanChiTiet.SL * tbl_PhieuBanChiTiet.DonGia AS thanhtien, tbl_PhieuBanChiTiet.HANG
FROM            tbl_PhieuBanHang INNER JOIN
                         tbl_PhieuBanChiTiet ON tbl_PhieuBanHang.IDPHIEU = tbl_PhieuBanChiTiet.ID_PB INNER JOIN
                         tbl_NhanVien ON tbl_PhieuBanHang.MANV = tbl_NhanVien.manv INNER JOIN
                         tbl_HANG ON tbl_PhieuBanChiTiet.HANG = tbl_HANG.Ma INNER JOIN
                         tbl_KhachHang ON tbl_PhieuBanHang.MAKH = tbl_KhachHang.makh where tbl_PhieuBanHang.IDPHIEU='" + MaHD + "'";
            da = new SqlDataAdapter(sql,con.getcon());
            ds = new DataSet();
            da.Fill(ds);
            reportViewer1.Reset();

            dt = ds.Tables[0];
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLBANHANG.Report.rpt_HDBANHANG.rdlc";
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