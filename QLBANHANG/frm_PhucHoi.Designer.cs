namespace QLBANHANG
{
    partial class frm_PhucHoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcsdl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnPhuchoi = new System.Windows.Forms.Button();
            this.txtduongdan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tên CSDL";
            // 
            // txtcsdl
            // 
            this.txtcsdl.Enabled = false;
            this.txtcsdl.Location = new System.Drawing.Point(92, 12);
            this.txtcsdl.Name = "txtcsdl";
            this.txtcsdl.Size = new System.Drawing.Size(286, 20);
            this.txtcsdl.TabIndex = 27;
            this.txtcsdl.Text = "QL_BANHANG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Dường dẫn";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(436, 45);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 36);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnPhuchoi
            // 
            this.btnPhuchoi.Location = new System.Drawing.Point(436, 3);
            this.btnPhuchoi.Name = "btnPhuchoi";
            this.btnPhuchoi.Size = new System.Drawing.Size(75, 36);
            this.btnPhuchoi.TabIndex = 24;
            this.btnPhuchoi.Text = "Phục hồi";
            this.btnPhuchoi.UseVisualStyleBackColor = true;
            this.btnPhuchoi.Click += new System.EventHandler(this.btnPhuchoi_Click);
            // 
            // txtduongdan
            // 
            this.txtduongdan.Location = new System.Drawing.Point(92, 47);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(286, 20);
            this.txtduongdan.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = ".......";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_PhucHoi
            // 
            this.ClientSize = new System.Drawing.Size(543, 89);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcsdl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPhuchoi);
            this.Controls.Add(this.txtduongdan);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "frm_PhucHoi";
            this.Text = "Phục hồi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcsdl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnPhuchoi;
        private System.Windows.Forms.TextBox txtduongdan;
        private System.Windows.Forms.Button button1;
    }
}