namespace QLBANHANG
{
    partial class frm_CTPhieuNhap
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
            this.cbmathe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdg = new System.Windows.Forms.NumericUpDown();
            this.txtsl = new System.Windows.Forms.NumericUpDown();
            this.cbmhd = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.cmdxoa = new DevComponents.DotNetBar.ButtonX();
            this.cmdsua = new DevComponents.DotNetBar.ButtonX();
            this.cmdluu = new DevComponents.DotNetBar.ButtonX();
            this.cmdthem = new DevComponents.DotNetBar.ButtonX();
            this.msds = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID_PN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsl)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmathe
            // 
            this.cbmathe.DisplayMember = "Text";
            this.cbmathe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmathe.FormattingEnabled = true;
            this.cbmathe.ItemHeight = 21;
            this.cbmathe.Location = new System.Drawing.Point(156, 47);
            this.cbmathe.Name = "cbmathe";
            this.cbmathe.Size = new System.Drawing.Size(252, 27);
            this.cbmathe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbmathe.TabIndex = 103;
            this.cbmathe.SelectedValueChanged += new System.EventHandler(this.cbmathe_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtdg);
            this.panel1.Controls.Add(this.txtsl);
            this.panel1.Controls.Add(this.cbmhd);
            this.panel1.Controls.Add(this.cbmathe);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 122);
            this.panel1.TabIndex = 31;
            // 
            // txtdg
            // 
            this.txtdg.Location = new System.Drawing.Point(493, 54);
            this.txtdg.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.txtdg.Name = "txtdg";
            this.txtdg.Size = new System.Drawing.Size(169, 20);
            this.txtdg.TabIndex = 104;
            this.txtdg.Enabled = false;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(493, 13);
            this.txtsl.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(169, 20);
            this.txtsl.TabIndex = 104;
            // 
            // cbmhd
            // 
            this.cbmhd.DisplayMember = "Text";
            this.cbmhd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmhd.FormattingEnabled = true;
            this.cbmhd.ItemHeight = 21;
            this.cbmhd.Location = new System.Drawing.Point(156, 13);
            this.cbmhd.Name = "cbmhd";
            this.cbmhd.Size = new System.Drawing.Size(252, 27);
            this.cbmhd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbmhd.TabIndex = 103;
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
            this.labelX1.Location = new System.Drawing.Point(417, 11);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX1.Size = new System.Drawing.Size(113, 27);
            this.labelX1.TabIndex = 101;
            this.labelX1.Text = "Số lượng";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Enabled = false;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(417, 48);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX5.Size = new System.Drawing.Size(113, 27);
            this.labelX5.TabIndex = 99;
            this.labelX5.Text = "Đơn giá";
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
            this.labelX3.Size = new System.Drawing.Size(137, 27);
            this.labelX3.TabIndex = 96;
            this.labelX3.Text = "Hàng";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Enabled = false;
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
            this.panel2.Controls.Add(this.buttonX1);
            this.panel2.Controls.Add(this.cmdxoa);
            this.panel2.Controls.Add(this.cmdsua);
            this.panel2.Controls.Add(this.cmdluu);
            this.panel2.Controls.Add(this.cmdthem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 35);
            this.panel2.TabIndex = 55;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonX1.Location = new System.Drawing.Point(321, 0);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(79, 35);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 20;
            this.buttonX1.Text = "In ";
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
            this.cmdxoa.Location = new System.Drawing.Point(242, 0);
            this.cmdxoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmdxoa.Name = "cmdxoa";
            this.cmdxoa.Size = new System.Drawing.Size(79, 35);
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
            this.cmdsua.Location = new System.Drawing.Point(168, 0);
            this.cmdsua.Margin = new System.Windows.Forms.Padding(4);
            this.cmdsua.Name = "cmdsua";
            this.cmdsua.Size = new System.Drawing.Size(74, 35);
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
            this.cmdluu.Size = new System.Drawing.Size(83, 35);
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
            this.cmdthem.Size = new System.Drawing.Size(85, 35);
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
            this.ID_PN,
            this.Ten,
            this.SL,
            this.DonGia});
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
            this.msds.Location = new System.Drawing.Point(0, 122);
            this.msds.Name = "msds";
            this.msds.Size = new System.Drawing.Size(962, 360);
            this.msds.TabIndex = 33;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellDoubleClick);
            // 
            // ID_PN
            // 
            this.ID_PN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_PN.DataPropertyName = "ID_PN";
            this.ID_PN.HeaderText = "Mã Phiếu";
            this.ID_PN.Name = "ID_PN";
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Hàng";
            this.Ten.Name = "Ten";
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // frm_CTPhieuNhap
            // 
            this.ClientSize = new System.Drawing.Size(962, 482);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CTPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Hóa Đơn Nhập";
            this.Load += new System.EventHandler(this.frm_CTHDBANHANG_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtdg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsl)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevComponents.DotNetBar.Controls.ComboBoxEx cbmathe;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX cmdxoa;
        private DevComponents.DotNetBar.ButtonX cmdsua;
        private DevComponents.DotNetBar.ButtonX cmdluu;
        private DevComponents.DotNetBar.ButtonX cmdthem;
        private System.Windows.Forms.NumericUpDown txtdg;
        private System.Windows.Forms.NumericUpDown txtsl;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cbmhd;
        private DevComponents.DotNetBar.Controls.DataGridViewX msds;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}