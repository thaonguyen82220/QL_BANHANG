namespace QLBANHANG
{
    partial class frm_PhieuBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbkh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchMaChungTu = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.txtngay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbnv = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtma = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBanhang = new System.Windows.Forms.Button();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.cmdxoa = new DevComponents.DotNetBar.ButtonX();
            this.cmdsua = new DevComponents.DotNetBar.ButtonX();
            this.cmdluu = new DevComponents.DotNetBar.ButtonX();
            this.cmdthem = new DevComponents.DotNetBar.ButtonX();
            this.txttongtien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.msds = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IDPHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongTienDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtngay)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.SuspendLayout();
            // 
            // cbkh
            // 
            this.cbkh.DisplayMember = "Text";
            this.cbkh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbkh.FormattingEnabled = true;
            this.cbkh.ItemHeight = 21;
            this.cbkh.Location = new System.Drawing.Point(156, 47);
            this.cbkh.Name = "cbkh";
            this.cbkh.Size = new System.Drawing.Size(222, 27);
            this.cbkh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbkh.TabIndex = 103;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTrangThai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearchMaChungTu);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.btnThemKhachHang);
            this.panel1.Controls.Add(this.txtngay);
            this.panel1.Controls.Add(this.cbnv);
            this.panel1.Controls.Add(this.cbkh);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.txtma);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txttongtien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 170);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbTrangThai.Location = new System.Drawing.Point(564, 95);
            this.cbTrangThai.MaxDropDownItems = 2;
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(57, 24);
            this.cbTrangThai.TabIndex = 147;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(627, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 21);
            this.label2.TabIndex = 146;
            this.label2.Text = "0 - Chờ xử lý. 1 - Hoàn thành";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(456, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 145;
            this.label1.Text = "Tình trạng";
            // 
            // btnSearchMaChungTu
            // 
            this.btnSearchMaChungTu.Location = new System.Drawing.Point(381, 85);
            this.btnSearchMaChungTu.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchMaChungTu.Name = "btnSearchMaChungTu";
            this.btnSearchMaChungTu.Size = new System.Drawing.Size(37, 25);
            this.btnSearchMaChungTu.TabIndex = 143;
            this.btnSearchMaChungTu.UseVisualStyleBackColor = true;
            this.btnSearchMaChungTu.Click += new System.EventHandler(this.btnSearchMaChungTu_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(12, 90);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 25);
            this.label24.TabIndex = 142;
            this.label24.Text = "Mã chứng từ";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(156, 85);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(220, 29);
            this.txtMaKH.TabIndex = 141;
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemKhachHang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKhachHang.Location = new System.Drawing.Point(381, 47);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(37, 29);
            this.btnThemKhachHang.TabIndex = 140;
            this.btnThemKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemKhachHang.UseVisualStyleBackColor = false;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // txtngay
            // 
            // 
            // 
            // 
            this.txtngay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtngay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtngay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtngay.ButtonDropDown.Visible = true;
            this.txtngay.CustomFormat = "MM/dd/yyyy";
            this.txtngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngay.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.txtngay.IsPopupCalendarOpen = false;
            this.txtngay.Location = new System.Drawing.Point(562, 18);
            // 
            // 
            // 
            // 
            // 
            // 
            this.txtngay.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtngay.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtngay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtngay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtngay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtngay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtngay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtngay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtngay.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtngay.MonthCalendar.DisplayMonth = new System.DateTime(2014, 3, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.txtngay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtngay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtngay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtngay.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtngay.MonthCalendar.TodayButtonVisible = true;
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(252, 34);
            this.txtngay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtngay.TabIndex = 104;
            // 
            // cbnv
            // 
            this.cbnv.DisplayMember = "Text";
            this.cbnv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbnv.FormattingEnabled = true;
            this.cbnv.ItemHeight = 21;
            this.cbnv.Location = new System.Drawing.Point(562, 53);
            this.cbnv.Name = "cbnv";
            this.cbnv.Size = new System.Drawing.Size(252, 27);
            this.cbnv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbnv.TabIndex = 103;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(457, 11);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX1.Size = new System.Drawing.Size(113, 27);
            this.labelX1.TabIndex = 101;
            this.labelX1.Text = "Ngày nhập";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(457, 53);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX2.Size = new System.Drawing.Size(137, 27);
            this.labelX2.TabIndex = 96;
            this.labelX2.Text = "Nhân viên";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(14, 74);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX5.Size = new System.Drawing.Size(113, 27);
            this.labelX5.TabIndex = 99;
            this.labelX5.Text = "Tổng tiền";
            this.labelX5.Visible = false;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(12, 45);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX3.Size = new System.Drawing.Size(137, 27);
            this.labelX3.TabIndex = 96;
            this.labelX3.Text = "Khách hàng";
            // 
            // txtma
            // 
            this.txtma.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtma.Border.Class = "TextBoxBorder";
            this.txtma.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtma.Enabled = false;
            this.txtma.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtma.ForeColor = System.Drawing.Color.Black;
            this.txtma.Location = new System.Drawing.Point(156, 13);
            this.txtma.Margin = new System.Windows.Forms.Padding(4);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(252, 32);
            this.txtma.TabIndex = 95;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(14, 13);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX6.Size = new System.Drawing.Size(69, 27);
            this.labelX6.TabIndex = 94;
            this.labelX6.Text = "Mã phiếu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnBanhang);
            this.panel2.Controls.Add(this.buttonX1);
            this.panel2.Controls.Add(this.cmdxoa);
            this.panel2.Controls.Add(this.cmdsua);
            this.panel2.Controls.Add(this.cmdluu);
            this.panel2.Controls.Add(this.cmdthem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 44);
            this.panel2.TabIndex = 55;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnBanhang
            // 
            this.btnBanhang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBanhang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanhang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBanhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanhang.Location = new System.Drawing.Point(888, 2);
            this.btnBanhang.Name = "btnBanhang";
            this.btnBanhang.Size = new System.Drawing.Size(114, 42);
            this.btnBanhang.TabIndex = 147;
            this.btnBanhang.Text = "Bán hàng";
            this.btnBanhang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanhang.UseVisualStyleBackColor = false;
            this.btnBanhang.Click += new System.EventHandler(this.btnBanhang_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonX1.Image = global::QLBANHANG.Properties.Resources.cash_single_add;
            this.buttonX1.Location = new System.Drawing.Point(318, 0);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(200, 44);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 20;
            this.buttonX1.Text = "Chi tiết đơn hàng";
            this.buttonX1.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // cmdxoa
            // 
            this.cmdxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdxoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdxoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmdxoa.Image = global::QLBANHANG.Properties.Resources._3Xoa;
            this.cmdxoa.Location = new System.Drawing.Point(239, 0);
            this.cmdxoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmdxoa.Name = "cmdxoa";
            this.cmdxoa.Size = new System.Drawing.Size(79, 44);
            this.cmdxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdxoa.TabIndex = 19;
            this.cmdxoa.Text = "Xóa";
            this.cmdxoa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.cmdxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // cmdsua
            // 
            this.cmdsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdsua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdsua.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdsua.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmdsua.Image = global::QLBANHANG.Properties.Resources._2Sua;
            this.cmdsua.Location = new System.Drawing.Point(165, 0);
            this.cmdsua.Margin = new System.Windows.Forms.Padding(4);
            this.cmdsua.Name = "cmdsua";
            this.cmdsua.Size = new System.Drawing.Size(74, 44);
            this.cmdsua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdsua.TabIndex = 18;
            this.cmdsua.Text = "Sửa";
            this.cmdsua.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.cmdsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // cmdluu
            // 
            this.cmdluu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdluu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdluu.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdluu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmdluu.Image = global::QLBANHANG.Properties.Resources._5Luu;
            this.cmdluu.Location = new System.Drawing.Point(85, 0);
            this.cmdluu.Margin = new System.Windows.Forms.Padding(4);
            this.cmdluu.Name = "cmdluu";
            this.cmdluu.Size = new System.Drawing.Size(80, 44);
            this.cmdluu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdluu.TabIndex = 17;
            this.cmdluu.Text = "Lưu";
            this.cmdluu.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.cmdluu.Click += new System.EventHandler(this.cmdluu_Click);
            // 
            // cmdthem
            // 
            this.cmdthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdthem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdthem.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdthem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmdthem.Image = global::QLBANHANG.Properties.Resources._1Them1;
            this.cmdthem.Location = new System.Drawing.Point(0, 0);
            this.cmdthem.Margin = new System.Windows.Forms.Padding(4);
            this.cmdthem.Name = "cmdthem";
            this.cmdthem.Size = new System.Drawing.Size(85, 44);
            this.cmdthem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdthem.TabIndex = 16;
            this.cmdthem.Text = "Thêm";
            this.cmdthem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.cmdthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttongtien
            // 
            this.txttongtien.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttongtien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttongtien.Enabled = false;
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.ForeColor = System.Drawing.Color.Black;
            this.txttongtien.Location = new System.Drawing.Point(156, 81);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(252, 22);
            this.txttongtien.TabIndex = 102;
            this.txttongtien.Visible = false;
            // 
            // msds
            // 
            this.msds.AllowUserToAddRows = false;
            this.msds.AllowUserToDeleteRows = false;
            this.msds.BackgroundColor = System.Drawing.Color.White;
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPHIEU,
            this.tenkh,
            this.NGAYLAP,
            this.tennv,
            this.MaCT,
            this.txtTongTienDonHang,
            this.TrangThai});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.msds.DefaultCellStyle = dataGridViewCellStyle1;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.msds.Location = new System.Drawing.Point(0, 170);
            this.msds.Name = "msds";
            this.msds.ReadOnly = true;
            this.msds.RowHeadersWidth = 51;
            this.msds.Size = new System.Drawing.Size(1002, 309);
            this.msds.TabIndex = 33;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellDoubleClick);
            this.msds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellContentClick);
            // 
            // IDPHIEU
            // 
            this.IDPHIEU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDPHIEU.DataPropertyName = "IDPHIEU";
            this.IDPHIEU.HeaderText = "Mã đơn hàng";
            this.IDPHIEU.MinimumWidth = 6;
            this.IDPHIEU.Name = "IDPHIEU";
            this.IDPHIEU.ReadOnly = true;
            // 
            // tenkh
            // 
            this.tenkh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenkh.DataPropertyName = "tenkh";
            this.tenkh.HeaderText = "Khách hàng";
            this.tenkh.MinimumWidth = 6;
            this.tenkh.Name = "tenkh";
            this.tenkh.ReadOnly = true;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày lập";
            this.NGAYLAP.MinimumWidth = 6;
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.ReadOnly = true;
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
            // MaCT
            // 
            this.MaCT.HeaderText = "Mã chứng từ";
            this.MaCT.MinimumWidth = 6;
            this.MaCT.Name = "MaCT";
            this.MaCT.ReadOnly = true;
            this.MaCT.Width = 125;
            // 
            // txtTongTienDonHang
            // 
            this.txtTongTienDonHang.DataPropertyName = "TongTien";
            this.txtTongTienDonHang.HeaderText = "Tổng tiền";
            this.txtTongTienDonHang.MinimumWidth = 6;
            this.txtTongTienDonHang.Name = "txtTongTienDonHang";
            this.txtTongTienDonHang.ReadOnly = true;
            this.txtTongTienDonHang.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 125;
            // 
            // frm_PhieuBanHang
            // 
            this.ClientSize = new System.Drawing.Size(1002, 479);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PhieuBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu bán hàng";
            this.Load += new System.EventHandler(this.frm_PhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtngay)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtngay;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtma;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX cmdxoa;
        private DevComponents.DotNetBar.ButtonX cmdsua;
        private DevComponents.DotNetBar.ButtonX cmdluu;
        private DevComponents.DotNetBar.ButtonX cmdthem;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX msds;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbkh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbnv;
        private DevComponents.DotNetBar.Controls.TextBoxX txttongtien;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchMaChungTu;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnBanhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPHIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTongTienDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.ComboBox cbTrangThai;
    }
}