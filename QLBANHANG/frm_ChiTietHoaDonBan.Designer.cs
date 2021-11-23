
namespace QLBANHANG
{
    partial class frm_ChiTietHoaDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChiTietHoaDonBan));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtTenHoaDon = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.SF = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            this.bf = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.theanh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.txtTenkach = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.Label();
            this.txtNgaysinh = new System.Windows.Forms.Label();
            this.txtNhanvien = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPhuongthuc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNguoiban = new System.Windows.Forms.Label();
            this.txtNguoimua = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txtTenHoaDon
            // 
            this.txtTenHoaDon.AutoSize = true;
            this.txtTenHoaDon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHoaDon.Location = new System.Drawing.Point(539, 4);
            this.txtTenHoaDon.Name = "txtTenHoaDon";
            this.txtTenHoaDon.Size = new System.Drawing.Size(95, 21);
            this.txtTenHoaDon.TabIndex = 0;
            this.txtTenHoaDon.Text = "HÓA ĐƠN";
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(29, 202);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(102, 21);
            this.S.TabIndex = 1;
            this.S.Text = "Khách hàng:";
            // 
            // SF
            // 
            this.SF.AutoSize = true;
            this.SF.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SF.Location = new System.Drawing.Point(29, 242);
            this.SF.Name = "SF";
            this.SF.Size = new System.Drawing.Size(65, 21);
            this.SF.TabIndex = 2;
            this.SF.Text = "Địa chỉ";
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd.Location = new System.Drawing.Point(29, 286);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(108, 21);
            this.sd.TabIndex = 3;
            this.sd.Text = "Số điện thoại";
            // 
            // bf
            // 
            this.bf.AutoSize = true;
            this.bf.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bf.Location = new System.Drawing.Point(938, 201);
            this.bf.Name = "bf";
            this.bf.Size = new System.Drawing.Size(84, 21);
            this.bf.TabIndex = 4;
            this.bf.Text = "Ngày sinh";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.theanh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTongtien);
            this.groupBox1.Location = new System.Drawing.Point(33, 358);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1118, 429);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // theanh
            // 
            this.theanh.AutoSize = true;
            this.theanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theanh.ForeColor = System.Drawing.Color.BlueViolet;
            this.theanh.Location = new System.Drawing.Point(3, 17);
            this.theanh.Name = "theanh";
            this.theanh.Size = new System.Drawing.Size(76, 29);
            this.theanh.TabIndex = 11;
            this.theanh.Text = "chitiet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(905, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng tiền";
            // 
            // txtTongtien
            // 
            this.txtTongtien.AutoSize = true;
            this.txtTongtien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtien.Location = new System.Drawing.Point(905, 390);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(69, 21);
            this.txtTongtien.TabIndex = 10;
            this.txtTongtien.Text = "tongtien";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(938, 267);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(84, 21);
            this.d.TabIndex = 6;
            this.d.Text = "Nhân viên";
            // 
            // txtTenkach
            // 
            this.txtTenkach.AutoSize = true;
            this.txtTenkach.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenkach.Location = new System.Drawing.Point(225, 202);
            this.txtTenkach.Name = "txtTenkach";
            this.txtTenkach.Size = new System.Drawing.Size(53, 21);
            this.txtTenkach.TabIndex = 9;
            this.txtTenkach.Text = "label4";
            // 
            // txtDiachi
            // 
            this.txtDiachi.AutoSize = true;
            this.txtDiachi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(225, 242);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(54, 21);
            this.txtDiachi.TabIndex = 10;
            this.txtDiachi.Text = "diachi";
            // 
            // txtSdt
            // 
            this.txtSdt.AutoSize = true;
            this.txtSdt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(225, 286);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(33, 21);
            this.txtSdt.TabIndex = 11;
            this.txtSdt.Text = "sdt";
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.AutoSize = true;
            this.txtNgaysinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaysinh.Location = new System.Drawing.Point(938, 223);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(75, 21);
            this.txtNgaysinh.TabIndex = 10;
            this.txtNgaysinh.Text = "ngaysinh";
            // 
            // txtNhanvien
            // 
            this.txtNhanvien.AutoSize = true;
            this.txtNhanvien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanvien.Location = new System.Drawing.Point(938, 288);
            this.txtNhanvien.Name = "txtNhanvien";
            this.txtNhanvien.Size = new System.Drawing.Size(28, 21);
            this.txtNhanvien.TabIndex = 10;
            this.txtNhanvien.Text = "nv";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(528, 199);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(108, 23);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "IN HÓA ĐƠN";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.print_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtTenHoaDon);
            this.panel1.Location = new System.Drawing.Point(31, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 173);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn vị bán hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtPhuongthuc
            // 
            this.txtPhuongthuc.AutoSize = true;
            this.txtPhuongthuc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhuongthuc.Location = new System.Drawing.Point(225, 326);
            this.txtPhuongthuc.Name = "txtPhuongthuc";
            this.txtPhuongthuc.Size = new System.Drawing.Size(73, 21);
            this.txtPhuongthuc.TabIndex = 15;
            this.txtPhuongthuc.Text = "hinhthuc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hình thức thanh toán";
            // 
            // txtNguoiban
            // 
            this.txtNguoiban.AutoSize = true;
            this.txtNguoiban.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiban.Location = new System.Drawing.Point(938, 838);
            this.txtNguoiban.Name = "txtNguoiban";
            this.txtNguoiban.Size = new System.Drawing.Size(28, 21);
            this.txtNguoiban.TabIndex = 18;
            this.txtNguoiban.Text = "nv";
            // 
            // txtNguoimua
            // 
            this.txtNguoimua.AutoSize = true;
            this.txtNguoimua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoimua.Location = new System.Drawing.Point(33, 838);
            this.txtNguoimua.Name = "txtNguoimua";
            this.txtNguoimua.Size = new System.Drawing.Size(82, 21);
            this.txtNguoimua.TabIndex = 19;
            this.txtNguoimua.Text = "nguoimua";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(938, 800);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Người bán";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 800);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Người mua";
            // 
            // frm_ChiTietHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1165, 966);
            this.Controls.Add(this.txtNguoiban);
            this.Controls.Add(this.txtNguoimua);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPhuongthuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtNhanvien);
            this.Controls.Add(this.txtNgaysinh);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTenkach);
            this.Controls.Add(this.d);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bf);
            this.Controls.Add(this.sd);
            this.Controls.Add(this.SF);
            this.Controls.Add(this.S);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_ChiTietHoaDonBan";
            this.Text = "Chi tiết hóa đơn bán";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label txtTenHoaDon;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label SF;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.Label bf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTenkach;
        private System.Windows.Forms.Label txtDiachi;
        private System.Windows.Forms.Label txtSdt;
        private System.Windows.Forms.Label txtNgaysinh;
        private System.Windows.Forms.Label txtNhanvien;
        private System.Windows.Forms.Label txtTongtien;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtPhuongthuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtNguoiban;
        private System.Windows.Forms.Label txtNguoimua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label theanh;
    }
}