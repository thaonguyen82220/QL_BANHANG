
namespace QLBANHANG
{
    partial class frm_DSDonHangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DSDonHangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gbChon = new System.Windows.Forms.GroupBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnTrove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.dpNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.dpNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvChitiet = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDanhsach = new System.Windows.Forms.DataGridView();
            this.IDPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoigiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(1045, 466);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 55);
            this.panel1.TabIndex = 202;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(20, 9);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 34);
            this.btnThem.TabIndex = 182;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(171, 9);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 34);
            this.btnSua.TabIndex = 183;
            this.btnSua.Text = "Chỉnh sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(299, 9);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 34);
            this.btnXoa.TabIndex = 184;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gbChon
            // 
            this.gbChon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbChon.Controls.Add(this.btnChon);
            this.gbChon.ForeColor = System.Drawing.Color.Coral;
            this.gbChon.Location = new System.Drawing.Point(1284, 41);
            this.gbChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbChon.Name = "gbChon";
            this.gbChon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbChon.Size = new System.Drawing.Size(200, 100);
            this.gbChon.TabIndex = 200;
            this.gbChon.TabStop = false;
            this.gbChon.Visible = false;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnChon.Enabled = false;
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChon.Location = new System.Drawing.Point(43, 31);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(127, 38);
            this.btnChon.TabIndex = 185;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Visible = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnTrove
            // 
            this.btnTrove.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrove.Image = ((System.Drawing.Image)(resources.GetObject("btnTrove.Image")));
            this.btnTrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrove.Location = new System.Drawing.Point(1357, 739);
            this.btnTrove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(127, 38);
            this.btnTrove.TabIndex = 199;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrove.UseVisualStyleBackColor = true;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(324, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 198;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(24, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 197;
            this.label1.Text = "Từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(451, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(555, 42);
            this.label5.TabIndex = 196;
            this.label5.Text = "DANH MỤC ĐƠN HÀNG NHẬP";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(629, 101);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(33, 25);
            this.btnTimkiem.TabIndex = 195;
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // dpNgayGiao
            // 
            this.dpNgayGiao.Location = new System.Drawing.Point(376, 101);
            this.dpNgayGiao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpNgayGiao.Name = "dpNgayGiao";
            this.dpNgayGiao.Size = new System.Drawing.Size(237, 22);
            this.dpNgayGiao.TabIndex = 194;
            // 
            // dpNgay
            // 
            this.dpNgay.Location = new System.Drawing.Point(70, 101);
            this.dpNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpNgay.Name = "dpNgay";
            this.dpNgay.Size = new System.Drawing.Size(244, 22);
            this.dpNgay.TabIndex = 193;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(24, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 201;
            this.label3.Text = "Chi tiết ";
            // 
            // dgvChitiet
            // 
            this.dgvChitiet.AllowUserToAddRows = false;
            this.dgvChitiet.AllowUserToDeleteRows = false;
            this.dgvChitiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvChitiet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.DonGia,
            this.id_pn,
            this.SL,
            this.DVT,
            this.ThanhTien});
            this.dgvChitiet.Location = new System.Drawing.Point(29, 532);
            this.dgvChitiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChitiet.Name = "dgvChitiet";
            this.dgvChitiet.ReadOnly = true;
            this.dgvChitiet.RowHeadersWidth = 51;
            this.dgvChitiet.RowTemplate.Height = 24;
            this.dgvChitiet.Size = new System.Drawing.Size(1455, 186);
            this.dgvChitiet.TabIndex = 191;
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSP.DataPropertyName = "Ma";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "Ten";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DONGIA";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // id_pn
            // 
            this.id_pn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_pn.DataPropertyName = "ID_PN";
            this.id_pn.HeaderText = "Id phieu";
            this.id_pn.MinimumWidth = 6;
            this.id_pn.Name = "id_pn";
            this.id_pn.ReadOnly = true;
            this.id_pn.Visible = false;
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // dgDanhsach
            // 
            this.dgDanhsach.AllowUserToAddRows = false;
            this.dgDanhsach.AllowUserToDeleteRows = false;
            this.dgDanhsach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPN,
            this.tennv,
            this.Ngay,
            this.tenncc,
            this.nguoigiao,
            this.sdt,
            this.tong,
            this.trangthai});
            this.dgDanhsach.Location = new System.Drawing.Point(29, 146);
            this.dgDanhsach.Name = "dgDanhsach";
            this.dgDanhsach.ReadOnly = true;
            this.dgDanhsach.RowHeadersWidth = 51;
            this.dgDanhsach.RowTemplate.Height = 24;
            this.dgDanhsach.Size = new System.Drawing.Size(1454, 294);
            this.dgDanhsach.TabIndex = 203;
            this.dgDanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Select);
            // 
            // IDPN
            // 
            this.IDPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDPN.DataPropertyName = "IDPN";
            this.IDPN.HeaderText = "Mã phiếu nhập";
            this.IDPN.MinimumWidth = 6;
            this.IDPN.Name = "IDPN";
            this.IDPN.ReadOnly = true;
            // 
            // tennv
            // 
            this.tennv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Nhân viên";
            this.tennv.MinimumWidth = 6;
            this.tennv.Name = "tennv";
            this.tennv.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày tạo";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // tenncc
            // 
            this.tenncc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenncc.DataPropertyName = "tenncc";
            this.tenncc.HeaderText = "Nhà cung cấp";
            this.tenncc.MinimumWidth = 6;
            this.tenncc.Name = "tenncc";
            this.tenncc.ReadOnly = true;
            // 
            // nguoigiao
            // 
            this.nguoigiao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nguoigiao.DataPropertyName = "NguoiGiao";
            this.nguoigiao.HeaderText = "Người giao hàng";
            this.nguoigiao.MinimumWidth = 6;
            this.nguoigiao.Name = "nguoigiao";
            this.nguoigiao.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdt.DataPropertyName = "Sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // tong
            // 
            this.tong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tong.DataPropertyName = "TONGTIEN";
            this.tong.HeaderText = "Tổng tiền";
            this.tong.MinimumWidth = 6;
            this.tong.Name = "tong";
            this.tong.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trangthai.DataPropertyName = "TrangThai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // frm_DSDonHangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1707, 788);
            this.Controls.Add(this.dgDanhsach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbChon);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.dpNgayGiao);
            this.Controls.Add(this.dpNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvChitiet);
            this.Name = "frm_DSDonHangNhap";
            this.Text = "Danh sách phiếu nhập";
            this.panel1.ResumeLayout(false);
            this.gbChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox gbChon;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnTrove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DateTimePicker dpNgayGiao;
        private System.Windows.Forms.DateTimePicker dpNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvChitiet;
        private System.Windows.Forms.DataGridView dgDanhsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoigiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tong;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}