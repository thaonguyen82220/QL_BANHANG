
namespace QLBANHANG
{
    partial class frm_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoaDon));
            this.cbKhachhang = new System.Windows.Forms.ComboBox();
            this.cbNhanvien = new System.Windows.Forms.ComboBox();
            this.dpNgaylap = new System.Windows.Forms.DateTimePicker();
            this.btnThemkhach = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rbVidientu = new System.Windows.Forms.RadioButton();
            this.rbThe = new System.Windows.Forms.RadioButton();
            this.rbTienmat = new System.Windows.Forms.RadioButton();
            this.txtStk = new System.Windows.Forms.TextBox();
            this.txtChungtu = new System.Windows.Forms.TextBox();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.dgvChitiet = new System.Windows.Forms.DataGridView();
            this.IDPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtDanhan = new System.Windows.Forms.TextBox();
            this.txtTrakhach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.grStt = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTrangthai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbStt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKhachhang
            // 
            this.cbKhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhachhang.FormattingEnabled = true;
            this.cbKhachhang.Location = new System.Drawing.Point(209, 37);
            this.cbKhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKhachhang.Name = "cbKhachhang";
            this.cbKhachhang.Size = new System.Drawing.Size(321, 24);
            this.cbKhachhang.TabIndex = 21;
            this.cbKhachhang.SelectedIndexChanged += new System.EventHandler(this.LayStk);
            // 
            // cbNhanvien
            // 
            this.cbNhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhanvien.FormattingEnabled = true;
            this.cbNhanvien.Location = new System.Drawing.Point(183, 154);
            this.cbNhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNhanvien.Name = "cbNhanvien";
            this.cbNhanvien.Size = new System.Drawing.Size(323, 24);
            this.cbNhanvien.TabIndex = 20;
            // 
            // dpNgaylap
            // 
            this.dpNgaylap.Location = new System.Drawing.Point(183, 103);
            this.dpNgaylap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpNgaylap.Name = "dpNgaylap";
            this.dpNgaylap.Size = new System.Drawing.Size(323, 22);
            this.dpNgaylap.TabIndex = 19;
            // 
            // btnThemkhach
            // 
            this.btnThemkhach.Image = ((System.Drawing.Image)(resources.GetObject("btnThemkhach.Image")));
            this.btnThemkhach.Location = new System.Drawing.Point(549, 25);
            this.btnThemkhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemkhach.Name = "btnThemkhach";
            this.btnThemkhach.Size = new System.Drawing.Size(44, 41);
            this.btnThemkhach.TabIndex = 18;
            this.btnThemkhach.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(465, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbVidientu
            // 
            this.rbVidientu.AutoSize = true;
            this.rbVidientu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVidientu.Location = new System.Drawing.Point(480, 143);
            this.rbVidientu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbVidientu.Name = "rbVidientu";
            this.rbVidientu.Size = new System.Drawing.Size(106, 25);
            this.rbVidientu.TabIndex = 18;
            this.rbVidientu.Text = "Ví điện tử";
            this.rbVidientu.UseVisualStyleBackColor = true;
            this.rbVidientu.CheckedChanged += new System.EventHandler(this.Select);
            // 
            // rbThe
            // 
            this.rbThe.AutoSize = true;
            this.rbThe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThe.Location = new System.Drawing.Point(209, 143);
            this.rbThe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbThe.Name = "rbThe";
            this.rbThe.Size = new System.Drawing.Size(60, 25);
            this.rbThe.TabIndex = 17;
            this.rbThe.Text = "Thẻ";
            this.rbThe.UseVisualStyleBackColor = true;
            this.rbThe.CheckedChanged += new System.EventHandler(this.Select);
            // 
            // rbTienmat
            // 
            this.rbTienmat.AutoSize = true;
            this.rbTienmat.Checked = true;
            this.rbTienmat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTienmat.Location = new System.Drawing.Point(319, 143);
            this.rbTienmat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTienmat.Name = "rbTienmat";
            this.rbTienmat.Size = new System.Drawing.Size(100, 25);
            this.rbTienmat.TabIndex = 16;
            this.rbTienmat.TabStop = true;
            this.rbTienmat.Text = "Tiền mặt ";
            this.rbTienmat.UseVisualStyleBackColor = true;
            this.rbTienmat.CheckedChanged += new System.EventHandler(this.Select);
            // 
            // txtStk
            // 
            this.txtStk.Location = new System.Drawing.Point(209, 210);
            this.txtStk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStk.Multiline = true;
            this.txtStk.Name = "txtStk";
            this.txtStk.ReadOnly = true;
            this.txtStk.Size = new System.Drawing.Size(383, 35);
            this.txtStk.TabIndex = 8;
            // 
            // txtChungtu
            // 
            this.txtChungtu.Location = new System.Drawing.Point(183, 210);
            this.txtChungtu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChungtu.Multiline = true;
            this.txtChungtu.Name = "txtChungtu";
            this.txtChungtu.ReadOnly = true;
            this.txtChungtu.Size = new System.Drawing.Size(276, 35);
            this.txtChungtu.TabIndex = 6;
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Location = new System.Drawing.Point(183, 38);
            this.txtMahoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMahoadon.Multiline = true;
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.ReadOnly = true;
            this.txtMahoadon.Size = new System.Drawing.Size(323, 30);
            this.txtMahoadon.TabIndex = 3;
            // 
            // dgvChitiet
            // 
            this.dgvChitiet.AllowUserToAddRows = false;
            this.dgvChitiet.AllowUserToDeleteRows = false;
            this.dgvChitiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvChitiet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPhieu,
            this.MaSP,
            this.TenSP,
            this.DonGia,
            this.SL,
            this.DVT,
            this.ThanhTien});
            this.dgvChitiet.Location = new System.Drawing.Point(43, 73);
            this.dgvChitiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChitiet.Name = "dgvChitiet";
            this.dgvChitiet.ReadOnly = true;
            this.dgvChitiet.RowHeadersWidth = 51;
            this.dgvChitiet.RowTemplate.Height = 24;
            this.dgvChitiet.Size = new System.Drawing.Size(1541, 207);
            this.dgvChitiet.TabIndex = 20;
            this.dgvChitiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Get);
            this.dgvChitiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChitiet_CellContentClick);
            // 
            // IDPhieu
            // 
            this.IDPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDPhieu.DataPropertyName = "ID_PB";
            this.IDPhieu.HeaderText = "Mã Phiếu ";
            this.IDPhieu.MinimumWidth = 6;
            this.IDPhieu.Name = "IDPhieu";
            this.IDPhieu.ReadOnly = true;
            this.IDPhieu.Visible = false;
            this.IDPhieu.Width = 125;
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
            this.TenSP.DataPropertyName = "Ten";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DONGIA";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 125;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            this.SL.Width = 125;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            this.DVT.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 125;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(683, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 34);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Navy;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1443, 20);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 34);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChon.Enabled = false;
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.Color.Navy;
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.Location = new System.Drawing.Point(1264, 21);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(141, 34);
            this.btnChon.TabIndex = 10;
            this.btnChon.Text = "Chọn ";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(937, 18);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoluong.Multiline = true;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(117, 34);
            this.txtSoluong.TabIndex = 8;
            this.txtSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoluong.TextChanged += new System.EventHandler(this.Chon);
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(339, 18);
            this.txtMasp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMasp.Multiline = true;
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.ReadOnly = true;
            this.txtMasp.Size = new System.Drawing.Size(321, 34);
            this.txtMasp.TabIndex = 6;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(1356, 318);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(221, 22);
            this.txtTongtien.TabIndex = 2;
            this.txtTongtien.Text = "0";
            this.txtTongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDanhan
            // 
            this.txtDanhan.Location = new System.Drawing.Point(1356, 361);
            this.txtDanhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDanhan.Name = "txtDanhan";
            this.txtDanhan.Size = new System.Drawing.Size(221, 22);
            this.txtDanhan.TabIndex = 3;
            this.txtDanhan.Text = "0";
            this.txtDanhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDanhan.TextChanged += new System.EventHandler(this.TienTraKhach);
            this.txtDanhan.Leave += new System.EventHandler(this.Test);
            // 
            // txtTrakhach
            // 
            this.txtTrakhach.Location = new System.Drawing.Point(1356, 402);
            this.txtTrakhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrakhach.Name = "txtTrakhach";
            this.txtTrakhach.ReadOnly = true;
            this.txtTrakhach.Size = new System.Drawing.Size(221, 22);
            this.txtTrakhach.TabIndex = 4;
            this.txtTrakhach.Text = "0";
            this.txtTrakhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1225, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1225, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Đã nhận";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1225, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Trả khách";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.BackColor = System.Drawing.Color.White;
            this.btnInhoadon.Enabled = false;
            this.btnInhoadon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhoadon.Image = ((System.Drawing.Image)(resources.GetObject("btnInhoadon.Image")));
            this.btnInhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInhoadon.Location = new System.Drawing.Point(37, 71);
            this.btnInhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(160, 41);
            this.btnInhoadon.TabIndex = 13;
            this.btnInhoadon.Text = "In hóa đơn";
            this.btnInhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInhoadon.UseVisualStyleBackColor = false;
            this.btnInhoadon.Click += new System.EventHandler(this.btnInhoadon_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(37, 208);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 41);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(1524, 423);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 54);
            this.button5.TabIndex = 14;
            this.button5.Text = "Trở về";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.White;
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(37, 139);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(160, 41);
            this.btnThanhToan.TabIndex = 17;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // grStt
            // 
            this.grStt.AutoSize = true;
            this.grStt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grStt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grStt.ForeColor = System.Drawing.Color.Cornsilk;
            this.grStt.Location = new System.Drawing.Point(683, 361);
            this.grStt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grStt.Name = "grStt";
            this.grStt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grStt.Size = new System.Drawing.Size(164, 69);
            this.grStt.TabIndex = 19;
            this.grStt.TabStop = false;
            this.grStt.Visible = false;
            this.grStt.Enter += new System.EventHandler(this.grStt_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkBlue;
            this.label14.Location = new System.Drawing.Point(768, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 45);
            this.label14.TabIndex = 20;
            this.label14.Text = "HÓA ĐƠN";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(39, 80);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(1628, 337);
            this.groupBox4.TabIndex = 122;
            this.groupBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.btnInhoadon);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Location = new System.Drawing.Point(1360, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 291);
            this.panel3.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkBlue;
            this.label15.Location = new System.Drawing.Point(33, 33);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 21);
            this.label15.TabIndex = 30;
            this.label15.Text = "Quản lý";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkBlue;
            this.label16.Location = new System.Drawing.Point(33, 33);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 21);
            this.label16.TabIndex = 29;
            this.label16.Text = "Quản lý";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.rbVidientu);
            this.panel2.Controls.Add(this.rbThe);
            this.panel2.Controls.Add(this.cbKhachhang);
            this.panel2.Controls.Add(this.rbTienmat);
            this.panel2.Controls.Add(this.btnThemkhach);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtStk);
            this.panel2.Location = new System.Drawing.Point(649, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 291);
            this.panel2.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkBlue;
            this.label17.Location = new System.Drawing.Point(57, 38);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 21);
            this.label17.TabIndex = 29;
            this.label17.Text = "Khách hàng";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkBlue;
            this.label19.Location = new System.Drawing.Point(57, 215);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 21);
            this.label19.TabIndex = 24;
            this.label19.Text = "Số tài khoản";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkBlue;
            this.label20.Location = new System.Drawing.Point(57, 103);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(188, 21);
            this.label20.TabIndex = 23;
            this.label20.Text = "Phương thức thanh toán";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.cbNhanvien);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.dpNgaylap);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtMahoadon);
            this.panel1.Controls.Add(this.txtChungtu);
            this.panel1.Location = new System.Drawing.Point(23, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 291);
            this.panel1.TabIndex = 21;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkBlue;
            this.label21.Location = new System.Drawing.Point(40, 161);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 21);
            this.label21.TabIndex = 16;
            this.label21.Text = "Nhân viên";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkBlue;
            this.label22.Location = new System.Drawing.Point(40, 215);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 21);
            this.label22.TabIndex = 15;
            this.label22.Text = "Chứng từ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DarkBlue;
            this.label23.Location = new System.Drawing.Point(40, 103);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 21);
            this.label23.TabIndex = 14;
            this.label23.Text = "Ngày lập";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DarkBlue;
            this.label24.Location = new System.Drawing.Point(40, 38);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 21);
            this.label24.TabIndex = 13;
            this.label24.Text = "Mã hóa đơn";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cbTrangthai);
            this.panel4.Controls.Add(this.dgvChitiet);
            this.panel4.Controls.Add(this.grStt);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.btnChon);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtSoluong);
            this.panel4.Controls.Add(this.txtTrakhach);
            this.panel4.Controls.Add(this.txtMasp);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtTongtien);
            this.panel4.Controls.Add(this.txtDanhan);
            this.panel4.Location = new System.Drawing.Point(29, 484);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1636, 450);
            this.panel4.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 402);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 21);
            this.label3.TabIndex = 126;
            this.label3.Text = "0 - Chờ        1 - Hoàn thành";
            // 
            // cbTrangthai
            // 
            this.cbTrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangthai.Enabled = false;
            this.cbTrangthai.FormattingEnabled = true;
            this.cbTrangthai.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbTrangthai.Location = new System.Drawing.Point(151, 393);
            this.cbTrangthai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTrangthai.Name = "cbTrangthai";
            this.cbTrangthai.Size = new System.Drawing.Size(160, 24);
            this.cbTrangthai.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 398);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 124;
            this.label4.Text = "Trạng Thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 93;
            this.label1.Text = "Đặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(821, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 91;
            this.label2.Text = "Số lượng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Navy;
            this.label18.Location = new System.Drawing.Point(187, 20);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 22);
            this.label18.TabIndex = 91;
            this.label18.Text = "Mã sản phẩm";
            // 
            // lbStt
            // 
            this.lbStt.AutoSize = true;
            this.lbStt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStt.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbStt.Location = new System.Drawing.Point(35, 441);
            this.lbStt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStt.Name = "lbStt";
            this.lbStt.Size = new System.Drawing.Size(0, 21);
            this.lbStt.TabIndex = 21;
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1604, 981);
            this.Controls.Add(this.lbStt);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_HoaDon";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.TextBox txtDanhan;
        private System.Windows.Forms.TextBox txtTrakhach;
        private System.Windows.Forms.TextBox txtStk;
        private System.Windows.Forms.TextBox txtChungtu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbVidientu;
        private System.Windows.Forms.RadioButton rbThe;
        private System.Windows.Forms.RadioButton rbTienmat;
        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThemkhach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.ComboBox cbKhachhang;
        private System.Windows.Forms.ComboBox cbNhanvien;
        private System.Windows.Forms.DateTimePicker dpNgaylap;
        private System.Windows.Forms.DataGridView dgvChitiet;
        private System.Windows.Forms.GroupBox grStt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTrangthai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}