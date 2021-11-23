
namespace QLBANHANG
{
    partial class frm_DSBaoGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DSBaoGia));
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.dpHieuluc = new System.Windows.Forms.DateTimePicker();
            this.dpNgay = new System.Windows.Forms.DateTimePicker();
            this.dgChiTiet = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDanhsachbaogia = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTrove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhsachbaogia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(677, 73);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(128, 39);
            this.btnTimkiem.TabIndex = 167;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // dpHieuluc
            // 
            this.dpHieuluc.Location = new System.Drawing.Point(405, 90);
            this.dpHieuluc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpHieuluc.Name = "dpHieuluc";
            this.dpHieuluc.Size = new System.Drawing.Size(243, 22);
            this.dpHieuluc.TabIndex = 166;
            // 
            // dpNgay
            // 
            this.dpNgay.Location = new System.Drawing.Point(85, 90);
            this.dpNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpNgay.Name = "dpNgay";
            this.dpNgay.Size = new System.Drawing.Size(255, 22);
            this.dpNgay.TabIndex = 165;
            // 
            // dgChiTiet
            // 
            this.dgChiTiet.AllowUserToAddRows = false;
            this.dgChiTiet.AllowUserToDeleteRows = false;
            this.dgChiTiet.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column9,
            this.Column8,
            this.Column11});
            this.dgChiTiet.Location = new System.Drawing.Point(39, 468);
            this.dgChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.dgChiTiet.Name = "dgChiTiet";
            this.dgChiTiet.ReadOnly = true;
            this.dgChiTiet.RowHeadersWidth = 51;
            this.dgChiTiet.Size = new System.Drawing.Size(1447, 247);
            this.dgChiTiet.TabIndex = 164;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "masp";
            this.Column6.HeaderText = "Mã sản phẩm";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "ten";
            this.Column7.HeaderText = "Tên sản phẩm";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "soluong";
            this.Column10.HeaderText = "Số lượng";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "dongia";
            this.Column9.HeaderText = "Đơn giá";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "dvt";
            this.Column8.HeaderText = "Đơn vị tính";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "thanhtien";
            this.Column11.HeaderText = "Thành tiền";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // dgDanhsachbaogia
            // 
            this.dgDanhsachbaogia.AllowUserToAddRows = false;
            this.dgDanhsachbaogia.AllowUserToDeleteRows = false;
            this.dgDanhsachbaogia.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgDanhsachbaogia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhsachbaogia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgDanhsachbaogia.Location = new System.Drawing.Point(39, 144);
            this.dgDanhsachbaogia.Margin = new System.Windows.Forms.Padding(4);
            this.dgDanhsachbaogia.Name = "dgDanhsachbaogia";
            this.dgDanhsachbaogia.ReadOnly = true;
            this.dgDanhsachbaogia.RowHeadersWidth = 51;
            this.dgDanhsachbaogia.Size = new System.Drawing.Size(1452, 266);
            this.dgDanhsachbaogia.TabIndex = 163;
            this.dgDanhsachbaogia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Select);
            this.dgDanhsachbaogia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Select);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "mabaogia";
            this.id.HeaderText = "Số báo giá";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ngay";
            this.Column1.HeaderText = "Ngày báo giá";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "hieuluc";
            this.Column3.HeaderText = "Hiệu lực đến";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "makh";
            this.Column4.HeaderText = "Khách hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "diachi";
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.GhostWhite;
            this.btnChiTiet.Enabled = false;
            this.btnChiTiet.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.Location = new System.Drawing.Point(39, 416);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(104, 34);
            this.btnChiTiet.TabIndex = 171;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.GhostWhite;
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1368, 70);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 42);
            this.btnXoa.TabIndex = 174;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSua.Enabled = false;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1245, 70);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 42);
            this.btnSua.TabIndex = 173;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(1123, 70);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 42);
            this.btnThem.TabIndex = 172;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(809, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 39);
            this.button1.TabIndex = 175;
            this.button1.Text = "Làm mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(567, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 42);
            this.label3.TabIndex = 180;
            this.label3.Text = "DANH MỤC PHIẾU BÁO GIÁ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(353, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 183;
            this.label4.Text = "đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(39, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 25);
            this.label5.TabIndex = 182;
            this.label5.Text = "Từ";
            // 
            // btnTrove
            // 
            this.btnTrove.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrove.Image = ((System.Drawing.Image)(resources.GetObject("btnTrove.Image")));
            this.btnTrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrove.Location = new System.Drawing.Point(1358, 742);
            this.btnTrove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(127, 38);
            this.btnTrove.TabIndex = 188;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrove.UseVisualStyleBackColor = true;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // frm_DSBaoGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1524, 829);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.dpHieuluc);
            this.Controls.Add(this.dpNgay);
            this.Controls.Add(this.dgChiTiet);
            this.Controls.Add(this.dgDanhsachbaogia);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DSBaoGia";
            this.Text = "Phiếu Báo Giá";
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhsachbaogia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DateTimePicker dpHieuluc;
        private System.Windows.Forms.DateTimePicker dpNgay;
        private System.Windows.Forms.DataGridView dgChiTiet;
        private System.Windows.Forms.DataGridView dgDanhsachbaogia;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnTrove;
    }
}