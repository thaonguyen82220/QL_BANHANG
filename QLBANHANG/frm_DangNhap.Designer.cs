namespace QLBANHANG
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmddn = new DevComponents.DotNetBar.ButtonX();
            this.txtmk = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbstt = new System.Windows.Forms.Label();
            this.btnThoát = new DevComponents.DotNetBar.ButtonX();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLBANHANG.Properties.Resources.LOGIN;
            this.pictureBox1.Location = new System.Drawing.Point(274, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(10, 72);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX3.Size = new System.Drawing.Size(79, 39);
            this.labelX3.TabIndex = 99;
            this.labelX3.Text = "Password";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.FontBold = true;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(10, 37);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX1.Size = new System.Drawing.Size(80, 27);
            this.labelX1.TabIndex = 98;
            this.labelX1.Text = "User";
            // 
            // cmddn
            // 
            this.cmddn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmddn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmddn.Location = new System.Drawing.Point(22, 204);
            this.cmddn.Name = "cmddn";
            this.cmddn.Size = new System.Drawing.Size(1, 1);
            this.cmddn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmddn.TabIndex = 97;
            this.cmddn.Text = "Đăng Nhập";
            this.cmddn.Click += new System.EventHandler(this.cmddn_Click);
            // 
            // txtmk
            // 
            this.txtmk.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtmk.Border.Class = "TextBoxBorder";
            this.txtmk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.ForeColor = System.Drawing.Color.Black;
            this.txtmk.Location = new System.Drawing.Point(97, 79);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(140, 20);
            this.txtmk.TabIndex = 96;
            this.txtmk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmk.TextChanged += new System.EventHandler(this.txtmk_TextChanged);
            // 
            // txtten
            // 
            this.txtten.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtten.Border.Class = "TextBoxBorder";
            this.txtten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtten.DisabledBackColor = System.Drawing.Color.Black;
            this.txtten.ForeColor = System.Drawing.Color.Black;
            this.txtten.Location = new System.Drawing.Point(96, 44);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(140, 20);
            this.txtten.TabIndex = 95;
            this.txtten.Text = "admin";
            this.txtten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtten.WatermarkText = "Mời nhập tên đăng nhập";
            this.txtten.TextChanged += new System.EventHandler(this.txtten_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbstt);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbstt
            // 
            this.lbstt.AutoSize = true;
            this.lbstt.Location = new System.Drawing.Point(10, 116);
            this.lbstt.Name = "lbstt";
            this.lbstt.Size = new System.Drawing.Size(10, 13);
            this.lbstt.TabIndex = 100;
            this.lbstt.Text = ".";
            // 
            // btnThoát
            // 
            this.btnThoát.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoát.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoát.Location = new System.Drawing.Point(320, 204);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(1, 1);
            this.btnThoát.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoát.TabIndex = 93;
            this.btnThoát.Text = "Thoát";
            this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Silver;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(25, 198);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(102, 33);
            this.btnDangNhap.TabIndex = 104;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Silver;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(304, 198);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 31);
            this.btnThoat.TabIndex = 105;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frm_DangNhap
            // 
            this.AcceptButton = this.cmddn;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(455, 260);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnThoát);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmddn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX cmddn;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmk;
        private DevComponents.DotNetBar.Controls.TextBoxX txtten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbstt;
        private DevComponents.DotNetBar.ButtonX btnThoát;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}