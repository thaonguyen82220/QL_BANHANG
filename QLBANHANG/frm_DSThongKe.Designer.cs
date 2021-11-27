
namespace QLBANHANG
{
    partial class frm_DSThongKe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DSThongKe));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvKhachHang1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTongDon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.cmbNhanVien1 = new System.Windows.Forms.ComboBox();
            this.rdbMaKH1 = new System.Windows.Forms.RadioButton();
            this.txtMaKhoa1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdbMaNV1 = new System.Windows.Forms.RadioButton();
            this.cbTG = new System.Windows.Forms.CheckBox();
            this.tbDT = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchMaKhoa1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLoc1 = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HocPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HocPhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(977, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(614, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 37);
            this.label1.TabIndex = 130;
            this.label1.Text = "THỐNG KÊ ĐƠN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(732, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 120;
            this.label6.Text = "VND";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(502, 513);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(225, 26);
            this.txtTongTien.TabIndex = 119;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(369, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 118;
            this.label5.Text = "Tổng trị giá đơn hàng";
            // 
            // dgvKhachHang1
            // 
            this.dgvKhachHang1.AllowUserToAddRows = false;
            this.dgvKhachHang1.AllowUserToDeleteRows = false;
            this.dgvKhachHang1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKhachHang1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang1.Location = new System.Drawing.Point(5, 20);
            this.dgvKhachHang1.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhachHang1.Name = "dgvKhachHang1";
            this.dgvKhachHang1.ReadOnly = true;
            this.dgvKhachHang1.RowHeadersWidth = 62;
            this.dgvKhachHang1.RowTemplate.Height = 28;
            this.dgvKhachHang1.Size = new System.Drawing.Size(768, 479);
            this.dgvKhachHang1.TabIndex = 93;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvKhachHang1);
            this.groupBox2.Controls.Add(this.txtTongDon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(422, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 555);
            this.groupBox2.TabIndex = 129;
            this.groupBox2.TabStop = false;
            // 
            // txtTongDon
            // 
            this.txtTongDon.Location = new System.Drawing.Point(146, 521);
            this.txtTongDon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongDon.Multiline = true;
            this.txtTongDon.Name = "txtTongDon";
            this.txtTongDon.Size = new System.Drawing.Size(62, 26);
            this.txtTongDon.TabIndex = 117;
            this.txtTongDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(9, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "Tổng số đơn hàng";
            // 
            // dtpDen
            // 
            this.dtpDen.Location = new System.Drawing.Point(63, 65);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(220, 20);
            this.dtpDen.TabIndex = 121;
            // 
            // dtpTu
            // 
            this.dtpTu.Location = new System.Drawing.Point(63, 25);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(220, 20);
            this.dtpTu.TabIndex = 120;
            // 
            // cmbNhanVien1
            // 
            this.cmbNhanVien1.FormattingEnabled = true;
            this.cmbNhanVien1.Location = new System.Drawing.Point(110, 20);
            this.cmbNhanVien1.Name = "cmbNhanVien1";
            this.cmbNhanVien1.Size = new System.Drawing.Size(182, 21);
            this.cmbNhanVien1.TabIndex = 85;
            // 
            // rdbMaKH1
            // 
            this.rdbMaKH1.AutoSize = true;
            this.rdbMaKH1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaKH1.ForeColor = System.Drawing.Color.Black;
            this.rdbMaKH1.Location = new System.Drawing.Point(15, 66);
            this.rdbMaKH1.Name = "rdbMaKH1";
            this.rdbMaKH1.Size = new System.Drawing.Size(97, 21);
            this.rdbMaKH1.TabIndex = 125;
            this.rdbMaKH1.TabStop = true;
            this.rdbMaKH1.Text = "Khách hàng";
            this.rdbMaKH1.UseVisualStyleBackColor = true;
            // 
            // txtMaKhoa1
            // 
            this.txtMaKhoa1.Location = new System.Drawing.Point(110, 66);
            this.txtMaKhoa1.Name = "txtMaKhoa1";
            this.txtMaKhoa1.Size = new System.Drawing.Size(152, 20);
            this.txtMaKhoa1.TabIndex = 77;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dtpDen);
            this.panel4.Controls.Add(this.dtpTu);
            this.panel4.Location = new System.Drawing.Point(24, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 104);
            this.panel4.TabIndex = 121;
            // 
            // rdbMaNV1
            // 
            this.rdbMaNV1.AutoSize = true;
            this.rdbMaNV1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaNV1.ForeColor = System.Drawing.Color.Black;
            this.rdbMaNV1.Location = new System.Drawing.Point(15, 19);
            this.rdbMaNV1.Name = "rdbMaNV1";
            this.rdbMaNV1.Size = new System.Drawing.Size(89, 21);
            this.rdbMaNV1.TabIndex = 126;
            this.rdbMaNV1.TabStop = true;
            this.rdbMaNV1.Text = "Nhân Viên";
            this.rdbMaNV1.UseVisualStyleBackColor = true;
            // 
            // cbTG
            // 
            this.cbTG.AutoSize = true;
            this.cbTG.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTG.ForeColor = System.Drawing.Color.DarkRed;
            this.cbTG.Location = new System.Drawing.Point(22, 112);
            this.cbTG.Name = "cbTG";
            this.cbTG.Size = new System.Drawing.Size(154, 23);
            this.cbTG.TabIndex = 129;
            this.cbTG.Text = "Khoảng thời gian";
            this.cbTG.UseVisualStyleBackColor = true;
            // 
            // tbDT
            // 
            this.tbDT.AutoSize = true;
            this.tbDT.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDT.ForeColor = System.Drawing.Color.DarkRed;
            this.tbDT.Location = new System.Drawing.Point(24, 245);
            this.tbDT.Name = "tbDT";
            this.tbDT.Size = new System.Drawing.Size(102, 23);
            this.tbDT.TabIndex = 130;
            this.tbDT.Text = "Đối tượng";
            this.tbDT.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cmbNhanVien1);
            this.panel2.Controls.Add(this.rdbMaKH1);
            this.panel2.Controls.Add(this.txtMaKhoa1);
            this.panel2.Controls.Add(this.btnSearchMaKhoa1);
            this.panel2.Controls.Add(this.rdbMaNV1);
            this.panel2.Location = new System.Drawing.Point(24, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 104);
            this.panel2.TabIndex = 128;
            // 
            // btnSearchMaKhoa1
            // 
            this.btnSearchMaKhoa1.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMaKhoa1.Image")));
            this.btnSearchMaKhoa1.Location = new System.Drawing.Point(270, 65);
            this.btnSearchMaKhoa1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchMaKhoa1.Name = "btnSearchMaKhoa1";
            this.btnSearchMaKhoa1.Size = new System.Drawing.Size(22, 21);
            this.btnSearchMaKhoa1.TabIndex = 89;
            this.btnSearchMaKhoa1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.cbTG);
            this.groupBox1.Controls.Add(this.tbDT);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btnLoc1);
            this.groupBox1.Controls.Add(this.btnDonHang);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 620);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(24, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 34);
            this.button1.TabIndex = 135;
            this.button1.Text = "Chi tiết";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Maroon;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(261, 578);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 31);
            this.btnThoat.TabIndex = 131;
            this.btnThoat.Text = "Trở về";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnLoc1
            // 
            this.btnLoc1.BackColor = System.Drawing.Color.White;
            this.btnLoc1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc1.ForeColor = System.Drawing.Color.Black;
            this.btnLoc1.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc1.Image")));
            this.btnLoc1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc1.Location = new System.Drawing.Point(24, 386);
            this.btnLoc1.Name = "btnLoc1";
            this.btnLoc1.Size = new System.Drawing.Size(132, 46);
            this.btnLoc1.TabIndex = 123;
            this.btnLoc1.Text = "  Tạo báo cáo";
            this.btnLoc1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc1.UseVisualStyleBackColor = false;
            // 
            // btnDonHang
            // 
            this.btnDonHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDonHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDonHang.Image = ((System.Drawing.Image)(resources.GetObject("btnDonHang.Image")));
            this.btnDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonHang.Location = new System.Drawing.Point(205, 386);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(136, 46);
            this.btnDonHang.TabIndex = 122;
            this.btnDonHang.Text = "In báo cáo";
            this.btnDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDonHang.UseVisualStyleBackColor = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // HocPhanBindingSource
            // 
            this.HocPhanBindingSource.DataMember = "HocPhan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 643);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 145);
            this.dataGridView1.TabIndex = 133;
            // 
            // frm_DSThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1212, 799);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_DSThongKe";
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HocPhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvKhachHang1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTongDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.ComboBox cmbNhanVien1;
        private System.Windows.Forms.RadioButton rdbMaKH1;
        private System.Windows.Forms.TextBox txtMaKhoa1;
        private System.Windows.Forms.Button btnSearchMaKhoa1;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdbMaNV1;
        private System.Windows.Forms.Button btnLoc1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox cbTG;
        private System.Windows.Forms.CheckBox tbDT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource HocPhanBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}