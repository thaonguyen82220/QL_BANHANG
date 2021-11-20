namespace QLBANHANG
{
    partial class frm_QuanLyNguoiDung
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbquyen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.cbnhanvien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtmk = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdxoa = new DevComponents.DotNetBar.ButtonX();
            this.cmdsua = new DevComponents.DotNetBar.ButtonX();
            this.cmdluu = new DevComponents.DotNetBar.ButtonX();
            this.cmdthem = new DevComponents.DotNetBar.ButtonX();
            this.msds = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.TENDANGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHANQUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbquyen);
            this.panel1.Controls.Add(this.cbnhanvien);
            this.panel1.Controls.Add(this.txtmk);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.txtten);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 133);
            this.panel1.TabIndex = 31;
            // 
            // cbquyen
            // 
            this.cbquyen.DisplayMember = "Text";
            this.cbquyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbquyen.FormattingEnabled = true;
            this.cbquyen.ItemHeight = 21;
            this.cbquyen.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cbquyen.Location = new System.Drawing.Point(477, 50);
            this.cbquyen.Name = "cbquyen";
            this.cbquyen.Size = new System.Drawing.Size(262, 27);
            this.cbquyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbquyen.TabIndex = 104;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "ADMIN";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Nhân viên";
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.DisplayMember = "Text";
            this.cbnhanvien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.ItemHeight = 21;
            this.cbnhanvien.Location = new System.Drawing.Point(128, 12);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(252, 27);
            this.cbnhanvien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbnhanvien.TabIndex = 103;
            // 
            // txtmk
            // 
            this.txtmk.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtmk.Border.Class = "";
            this.txtmk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmk.Enabled = false;
            this.txtmk.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmk.ForeColor = System.Drawing.Color.Black;
            this.txtmk.Location = new System.Drawing.Point(477, 16);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(262, 20);
            this.txtmk.TabIndex = 102;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(388, 13);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX1.Size = new System.Drawing.Size(113, 27);
            this.labelX1.TabIndex = 101;
            this.labelX1.Text = "Mật khẩu";
            // 
            // txtten
            // 
            this.txtten.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtten.Border.Class = "";
            this.txtten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtten.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtten.ForeColor = System.Drawing.Color.Black;
            this.txtten.Location = new System.Drawing.Point(128, 46);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(252, 27);
            this.txtten.TabIndex = 100;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(388, 50);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX5.Size = new System.Drawing.Size(113, 27);
            this.labelX5.TabIndex = 99;
            this.labelX5.Text = "Quyền";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(12, 45);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX3.Size = new System.Drawing.Size(113, 27);
            this.labelX3.TabIndex = 96;
            this.labelX3.Text = "Tên đăng nhập";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(14, 13);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX6.Size = new System.Drawing.Size(90, 27);
            this.labelX6.TabIndex = 94;
            this.labelX6.Text = "Nhân Viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cmdxoa);
            this.panel2.Controls.Add(this.cmdsua);
            this.panel2.Controls.Add(this.cmdluu);
            this.panel2.Controls.Add(this.cmdthem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 37);
            this.panel2.TabIndex = 55;
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
            this.cmdxoa.Size = new System.Drawing.Size(79, 37);
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
            this.cmdsua.Size = new System.Drawing.Size(74, 37);
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
            this.cmdluu.Size = new System.Drawing.Size(80, 37);
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
            this.cmdthem.Size = new System.Drawing.Size(85, 37);
            this.cmdthem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdthem.TabIndex = 16;
            this.cmdthem.Text = "Thêm";
            this.cmdthem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.cmdthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // msds
            // 
            this.msds.BackgroundColor = System.Drawing.Color.White;
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENDANGNHAP,
            this.tennv,
            this.MATKHAU,
            this.PHANQUYEN});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.msds.DefaultCellStyle = dataGridViewCellStyle1;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.msds.Location = new System.Drawing.Point(0, 133);
            this.msds.Name = "msds";
            this.msds.Size = new System.Drawing.Size(873, 335);
            this.msds.TabIndex = 33;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellDoubleClick);
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENDANGNHAP.DataPropertyName = "TENDANGNHAP";
            this.TENDANGNHAP.HeaderText = "Tên đăng nhập";
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            // 
            // tennv
            // 
            this.tennv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Nhân viên";
            this.tennv.Name = "tennv";
            // 
            // MATKHAU
            // 
            this.MATKHAU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "Mật khẩu";
            this.MATKHAU.Name = "MATKHAU";
            // 
            // PHANQUYEN
            // 
            this.PHANQUYEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PHANQUYEN.DataPropertyName = "PHANQUYEN";
            this.PHANQUYEN.HeaderText = "Phân quyền";
            this.PHANQUYEN.Name = "PHANQUYEN";
            // 
            // frm_QuanLyNguoiDung
            // 
            this.ClientSize = new System.Drawing.Size(873, 468);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_QuanLyNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Người Dùng";
            this.Load += new System.EventHandler(this.frm_QuanLyNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmk;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtten;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX cmdxoa;
        private DevComponents.DotNetBar.ButtonX cmdsua;
        private DevComponents.DotNetBar.ButtonX cmdluu;
        private DevComponents.DotNetBar.ButtonX cmdthem;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cbquyen;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cbnhanvien;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.DataGridViewX msds;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDANGNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHANQUYEN;
    }
}