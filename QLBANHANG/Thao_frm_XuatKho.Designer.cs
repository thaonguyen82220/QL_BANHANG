﻿
namespace QLBANHANG
{
    partial class Thao_frm_XuatKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thao_frm_XuatKho));
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTG = new System.Windows.Forms.CheckBox();
            this.tbDT = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbNhanVien1 = new System.Windows.Forms.ComboBox();
            this.btnLoc1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.HocPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgDanhsach = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HocPhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(16, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 121;
            this.label7.Text = "Tình trạng";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 648);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 145);
            this.dataGridView1.TabIndex = 147;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.cbTG);
            this.groupBox1.Controls.Add(this.tbDT);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btnLoc1);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 620);
            this.groupBox1.TabIndex = 142;
            this.groupBox1.TabStop = false;
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
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbNhanVien1);
            this.panel2.Location = new System.Drawing.Point(24, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 57);
            this.panel2.TabIndex = 128;
            // 
            // cmbNhanVien1
            // 
            this.cmbNhanVien1.FormattingEnabled = true;
            this.cmbNhanVien1.Location = new System.Drawing.Point(110, 20);
            this.cmbNhanVien1.Name = "cmbNhanVien1";
            this.cmbNhanVien1.Size = new System.Drawing.Size(182, 21);
            this.cmbNhanVien1.TabIndex = 85;
            // 
            // btnLoc1
            // 
            this.btnLoc1.BackColor = System.Drawing.Color.White;
            this.btnLoc1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc1.ForeColor = System.Drawing.Color.Black;
            this.btnLoc1.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc1.Image")));
            this.btnLoc1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc1.Location = new System.Drawing.Point(209, 331);
            this.btnLoc1.Name = "btnLoc1";
            this.btnLoc1.Size = new System.Drawing.Size(132, 46);
            this.btnLoc1.TabIndex = 123;
            this.btnLoc1.Text = "Kiểm tra";
            this.btnLoc1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgDanhsach);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(408, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 512);
            this.groupBox2.TabIndex = 144;
            this.groupBox2.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(978, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(615, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 37);
            this.label1.TabIndex = 145;
            this.label1.Text = "QUẢN LÝ XUẤT KHO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Maroon;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1084, 813);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 34);
            this.btnThoat.TabIndex = 141;
            this.btnThoat.Text = "Trở về";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(408, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 34);
            this.button1.TabIndex = 143;
            this.button1.Text = "Chi tiết";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnDonHang
            // 
            this.btnDonHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDonHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDonHang.Image = ((System.Drawing.Image)(resources.GetObject("btnDonHang.Image")));
            this.btnDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonHang.Location = new System.Drawing.Point(920, 813);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(136, 34);
            this.btnDonHang.TabIndex = 140;
            this.btnDonHang.Text = "Xuất hàng";
            this.btnDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDonHang.UseVisualStyleBackColor = false;
            // 
            // HocPhanBindingSource
            // 
            this.HocPhanBindingSource.DataMember = "HocPhan";
            // 
            // dgDanhsach
            // 
            this.dgDanhsach.AllowUserToAddRows = false;
            this.dgDanhsach.AllowUserToDeleteRows = false;
            this.dgDanhsach.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.Column4,
            this.nhanvien,
            this.Column5,
            this.tongtien,
            this.trangthai});
            this.dgDanhsach.Location = new System.Drawing.Point(6, 21);
            this.dgDanhsach.Name = "dgDanhsach";
            this.dgDanhsach.ReadOnly = true;
            this.dgDanhsach.RowHeadersWidth = 51;
            this.dgDanhsach.Size = new System.Drawing.Size(766, 473);
            this.dgDanhsach.TabIndex = 177;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Mã hóa đơn";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Ngay";
            this.Column1.HeaderText = "Ngày tạo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "tenkh";
            this.Column4.HeaderText = "Khách hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // nhanvien
            // 
            this.nhanvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nhanvien.DataPropertyName = "tennv";
            this.nhanvien.HeaderText = "Nhân viên";
            this.nhanvien.MinimumWidth = 6;
            this.nhanvien.Name = "nhanvien";
            this.nhanvien.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "chungtu";
            this.Column5.HeaderText = "Chứng từ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // tongtien
            // 
            this.tongtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // Thao_frm_XuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 853);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDonHang);
            this.Name = "Thao_frm_XuatKho";
            this.Text = "Xuất kho";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HocPhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource HocPhanBindingSource;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTG;
        private System.Windows.Forms.CheckBox tbDT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbNhanVien1;
        private System.Windows.Forms.Button btnLoc1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.DataGridView dgDanhsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}