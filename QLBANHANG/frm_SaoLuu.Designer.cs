namespace QLBANHANG
{
    partial class frm_SaoLuu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcsdl = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSaoluu = new System.Windows.Forms.Button();
            this.txtduongdan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Dường dẫn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên CSDL";
            // 
            // txtcsdl
            // 
            this.txtcsdl.Enabled = false;
            this.txtcsdl.Location = new System.Drawing.Point(66, 24);
            this.txtcsdl.Name = "txtcsdl";
            this.txtcsdl.Size = new System.Drawing.Size(286, 20);
            this.txtcsdl.TabIndex = 17;
            this.txtcsdl.Text = "QL_BANHANG";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(410, 57);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 36);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSaoluu
            // 
            this.btnSaoluu.Location = new System.Drawing.Point(410, 15);
            this.btnSaoluu.Name = "btnSaoluu";
            this.btnSaoluu.Size = new System.Drawing.Size(75, 36);
            this.btnSaoluu.TabIndex = 15;
            this.btnSaoluu.Text = "Sao lưu";
            this.btnSaoluu.UseVisualStyleBackColor = true;
            this.btnSaoluu.Click += new System.EventHandler(this.btnSaoluu_Click);
            // 
            // txtduongdan
            // 
            this.txtduongdan.Location = new System.Drawing.Point(66, 66);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(286, 20);
            this.txtduongdan.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = ".......";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_SaoLuu
            // 
            this.ClientSize = new System.Drawing.Size(524, 99);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcsdl);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSaoluu);
            this.Controls.Add(this.txtduongdan);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SaoLuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SaoLuu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcsdl;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSaoluu;
        private System.Windows.Forms.TextBox txtduongdan;
        private System.Windows.Forms.Button button1;
    }
}