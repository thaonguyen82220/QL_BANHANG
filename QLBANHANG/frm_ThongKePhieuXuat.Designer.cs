namespace QLBANHANG
{
    partial class frm_ThongKePhieuXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongkephieubanhangTableAdapter1 = new QLBANHANG.DataSet1TableAdapters.THONGKEPHIEUBANHANGTableAdapter();
            this.thongkephieunhapTableAdapter1 = new QLBANHANG.DataSet1TableAdapters.THONGKEPHIEUNHAPTableAdapter();
            this.thongkephieunhapTableAdapter2 = new QLBANHANG.DataSet1TableAdapters.THONGKEPHIEUNHAPTableAdapter();
            this.thongkephieubanhangTableAdapter2 = new QLBANHANG.DataSet1TableAdapters.THONGKEPHIEUBANHANGTableAdapter();
            this.tbl_KhachHangTableAdapter1 = new QLBANHANG.DataSet1TableAdapters.tbl_KhachHangTableAdapter();
            this.tableAdapterManager1 = new QLBANHANG.DataSet1TableAdapters.TableAdapterManager();
            this.phieubanhangTableAdapter1 = new QLBANHANG.DataSet1TableAdapters.PHIEUBANHANGTableAdapter();
            this.dataSet11 = new QLBANHANG.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(711, 436);
            this.reportViewer1.TabIndex = 0;
            // 
            // thongkephieubanhangTableAdapter1
            // 
            this.thongkephieubanhangTableAdapter1.ClearBeforeFill = true;
            // 
            // thongkephieunhapTableAdapter1
            // 
            this.thongkephieunhapTableAdapter1.ClearBeforeFill = true;
            // 
            // thongkephieunhapTableAdapter2
            // 
            this.thongkephieunhapTableAdapter2.ClearBeforeFill = true;
            // 
            // thongkephieubanhangTableAdapter2
            // 
            this.thongkephieubanhangTableAdapter2.ClearBeforeFill = true;
            // 
            // tbl_KhachHangTableAdapter1
            // 
            this.tbl_KhachHangTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbl_KhachHangTableAdapter = this.tbl_KhachHangTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = QLBANHANG.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // phieubanhangTableAdapter1
            // 
            this.phieubanhangTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_ThongKePhieuXuat
            // 
            this.ClientSize = new System.Drawing.Size(711, 436);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Name = "frm_ThongKePhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Phiếu Xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ThongKePhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1TableAdapters.THONGKEPHIEUBANHANGTableAdapter thongkephieubanhangTableAdapter1;
        private DataSet1TableAdapters.THONGKEPHIEUNHAPTableAdapter thongkephieunhapTableAdapter1;
        private DataSet1TableAdapters.THONGKEPHIEUNHAPTableAdapter thongkephieunhapTableAdapter2;
        private DataSet1TableAdapters.THONGKEPHIEUBANHANGTableAdapter thongkephieubanhangTableAdapter2;
        private DataSet1TableAdapters.tbl_KhachHangTableAdapter tbl_KhachHangTableAdapter1;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private DataSet1TableAdapters.PHIEUBANHANGTableAdapter phieubanhangTableAdapter1;
        private DataSet1 dataSet11;
    }
}