
namespace QLBANHANG
{
    partial class frm_PhieuNhapHang
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
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.txtNguoiGiao = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnChitiet = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvChitiet = new System.Windows.Forms.DataGridView();
            this.IDPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoigiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpNgay = new System.Windows.Forms.DateTimePicker();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(134, 21);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(194, 22);
            this.txtMaPhieu.TabIndex = 0;
            // 
            // txtNguoiGiao
            // 
            this.txtNguoiGiao.Location = new System.Drawing.Point(134, 74);
            this.txtNguoiGiao.Name = "txtNguoiGiao";
            this.txtNguoiGiao.ReadOnly = true;
            this.txtNguoiGiao.Size = new System.Drawing.Size(194, 22);
            this.txtNguoiGiao.TabIndex = 1;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(821, 76);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.ReadOnly = true;
            this.txtSdt.Size = new System.Drawing.Size(194, 22);
            this.txtSdt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(727, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số điện thoại người giao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Người giao hàng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(19, 142);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 35);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(119, 142);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 35);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(218, 142);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 35);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(316, 142);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 35);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnChitiet
            // 
            this.btnChitiet.Location = new System.Drawing.Point(413, 142);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.Size = new System.Drawing.Size(82, 35);
            this.btnChitiet.TabIndex = 15;
            this.btnChitiet.Text = "Chi tiết";
            this.btnChitiet.UseVisualStyleBackColor = true;
            this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(895, 142);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(120, 35);
            this.btnThanhToan.TabIndex = 16;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // dgvChitiet
            // 
            this.dgvChitiet.AllowUserToAddRows = false;
            this.dgvChitiet.AllowUserToDeleteRows = false;
            this.dgvChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPN,
            this.Ngay,
            this.nguoigiao,
            this.sdt,
            this.tong,
            this.trangthai,
            this.ncc});
            this.dgvChitiet.Location = new System.Drawing.Point(19, 183);
            this.dgvChitiet.Name = "dgvChitiet";
            this.dgvChitiet.ReadOnly = true;
            this.dgvChitiet.RowHeadersWidth = 51;
            this.dgvChitiet.RowTemplate.Height = 24;
            this.dgvChitiet.Size = new System.Drawing.Size(996, 316);
            this.dgvChitiet.TabIndex = 10;
            this.dgvChitiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Select);
            this.dgvChitiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Select);
            // 
            // IDPN
            // 
            this.IDPN.DataPropertyName = "IDPN";
            this.IDPN.HeaderText = "Mã phiếu nhập";
            this.IDPN.MinimumWidth = 6;
            this.IDPN.Name = "IDPN";
            this.IDPN.ReadOnly = true;
            this.IDPN.Width = 125;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày nhập";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            this.Ngay.Width = 125;
            // 
            // nguoigiao
            // 
            this.nguoigiao.DataPropertyName = "NguoiGiao";
            this.nguoigiao.HeaderText = "Người giao hàng";
            this.nguoigiao.MinimumWidth = 6;
            this.nguoigiao.Name = "nguoigiao";
            this.nguoigiao.ReadOnly = true;
            this.nguoigiao.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "Sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 125;
            // 
            // tong
            // 
            this.tong.DataPropertyName = "TONGTIEN";
            this.tong.HeaderText = "Tổng tiền";
            this.tong.MinimumWidth = 6;
            this.tong.Name = "tong";
            this.tong.ReadOnly = true;
            this.tong.Width = 125;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "TrangThai";
            this.trangthai.HeaderText = "stt";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            this.trangthai.Visible = false;
            this.trangthai.Width = 125;
            // 
            // ncc
            // 
            this.ncc.DataPropertyName = "NCC";
            this.ncc.HeaderText = "ncc";
            this.ncc.MinimumWidth = 6;
            this.ncc.Name = "ncc";
            this.ncc.ReadOnly = true;
            this.ncc.Visible = false;
            this.ncc.Width = 125;
            // 
            // dpNgay
            // 
            this.dpNgay.Enabled = false;
            this.dpNgay.Location = new System.Drawing.Point(821, 20);
            this.dpNgay.Name = "dpNgay";
            this.dpNgay.Size = new System.Drawing.Size(194, 22);
            this.dpNgay.TabIndex = 17;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(512, 142);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 35);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frm_PhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 522);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dpNgay);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnChitiet);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvChitiet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtNguoiGiao);
            this.Controls.Add(this.txtMaPhieu);
            this.Name = "frm_PhieuNhapHang";
            this.Text = "Phiếu nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.TextBox txtNguoiGiao;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnChitiet;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvChitiet;
        private System.Windows.Forms.DateTimePicker dpNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoigiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tong;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncc;
        private System.Windows.Forms.Button btnHuy;
    }
}