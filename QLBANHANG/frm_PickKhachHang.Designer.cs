
namespace QLBANHANG
{
    partial class frm_PickKhachHang
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
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSdt = new QLBANHANG.PlaceHolder_Text();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten,
            this.diachi,
            this.sdt,
            this.ngaysinh,
            this.gioitinh,
            this.g,
            this.stk});
            this.dgvSanPham.Location = new System.Drawing.Point(11, 26);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.Size = new System.Drawing.Size(1203, 350);
            this.dgvSanPham.TabIndex = 102;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.setID);
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.setID);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "makh";
            this.Ma.HeaderText = "Mã khách hàng";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "tenkh";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gt";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // g
            // 
            this.g.DataPropertyName = "gioitinh";
            this.g.HeaderText = "gt";
            this.g.MinimumWidth = 6;
            this.g.Name = "g";
            this.g.ReadOnly = true;
            this.g.Visible = false;
            // 
            // stk
            // 
            this.stk.DataPropertyName = "stk";
            this.stk.HeaderText = "Số tài khoản";
            this.stk.MinimumWidth = 6;
            this.stk.Name = "stk";
            this.stk.ReadOnly = true;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(554, 399);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(96, 32);
            this.btnChon.TabIndex = 101;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 103;
            this.button1.Text = "Tìm ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtSdt.ForeColor = System.Drawing.Color.Gray;
            this.txtSdt.Location = new System.Drawing.Point(123, 404);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.PlaceHolderText = null;
            this.txtSdt.Size = new System.Drawing.Size(217, 22);
            this.txtSdt.TabIndex = 105;
            this.txtSdt.Text = "Tìm theo số điện thoại";
            // 
            // frm_PickKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 452);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.btnChon);
            this.Name = "frm_PickKhachHang";
            this.Text = "Khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn g;
        private System.Windows.Forms.DataGridViewTextBoxColumn stk;
        private System.Windows.Forms.Button button1;
        public PlaceHolder_Text txtSdt;
    }
}