namespace QLBANHANG
{
    partial class frm_DVT
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
            this.cmdxoa = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtma = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdsua = new DevComponents.DotNetBar.ButtonX();
            this.cmdluu = new DevComponents.DotNetBar.ButtonX();
            this.cmdthem = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.msds = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdxoa
            // 
            this.cmdxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdxoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdxoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmdxoa.Image = global::QLBANHANG.Properties.Resources._3Xoa;
            this.cmdxoa.Location = new System.Drawing.Point(232, 0);
            this.cmdxoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmdxoa.Name = "cmdxoa";
            this.cmdxoa.Size = new System.Drawing.Size(79, 35);
            this.cmdxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdxoa.TabIndex = 19;
            this.cmdxoa.Text = "Xóa";
            this.cmdxoa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.cmdxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtma);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.txtten);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 127);
            this.panel1.TabIndex = 26;
            // 
            // txtma
            // 
            this.txtma.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtma.Border.Class = "TextBoxBorder";
            this.txtma.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtma.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtma.ForeColor = System.Drawing.Color.Black;
            this.txtma.Location = new System.Drawing.Point(101, 15);
            this.txtma.Margin = new System.Windows.Forms.Padding(4);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(453, 27);
            this.txtma.TabIndex = 1;
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
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 35);
            this.panel2.TabIndex = 55;
            // 
            // cmdsua
            // 
            this.cmdsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdsua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdsua.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdsua.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmdsua.Image = global::QLBANHANG.Properties.Resources._2Sua;
            this.cmdsua.Location = new System.Drawing.Point(158, 0);
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
            this.cmdluu.Size = new System.Drawing.Size(73, 35);
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
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(13, 47);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX4.Size = new System.Drawing.Size(80, 27);
            this.labelX4.TabIndex = 54;
            this.labelX4.Text = "Tên";
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
            this.labelX3.Location = new System.Drawing.Point(13, 12);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX3.Size = new System.Drawing.Size(80, 27);
            this.labelX3.TabIndex = 53;
            this.labelX3.Text = "Mã ";
            // 
            // txtten
            // 
            this.txtten.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtten.Border.Class = "TextBoxBorder";
            this.txtten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtten.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtten.ForeColor = System.Drawing.Color.Black;
            this.txtten.Location = new System.Drawing.Point(101, 50);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(453, 27);
            this.txtten.TabIndex = 2;
            // 
            // msds
            // 
            this.msds.BackgroundColor = System.Drawing.Color.White;
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ten});
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
            this.msds.Location = new System.Drawing.Point(0, 127);
            this.msds.Name = "msds";
            this.msds.ReadOnly = true;
            this.msds.Size = new System.Drawing.Size(569, 435);
            this.msds.TabIndex = 28;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã ";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // frm_DVT
            // 
            this.ClientSize = new System.Drawing.Size(569, 562);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DVT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn vị tính";
            this.Load += new System.EventHandler(this.frm_MenhGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cmdxoa;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtma;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX cmdsua;
        private DevComponents.DotNetBar.ButtonX cmdluu;
        private DevComponents.DotNetBar.ButtonX cmdthem;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtten;
        private DevComponents.DotNetBar.Controls.DataGridViewX msds;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
    }
}