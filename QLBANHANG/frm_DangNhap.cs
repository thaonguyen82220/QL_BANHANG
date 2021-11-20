using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QLBANHANG
{
    public partial class frm_DangNhap : DevComponents.DotNetBar.Office2007Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        private void cmddn_Click(object sender, EventArgs e)
        {
            string sql = "Select count(*) from tbl_nguoidung where TENDANGNHAP=N'" + txtten.Text + "'  and MATKHAU=N'" + txtmk.Text + "'";
            string quyen = "Select PHANQUYEN from tbl_nguoidung where  TENDANGNHAP=N'" + txtten.Text + "'  and MATKHAU=N'" + txtmk.Text + "'";
            if (this.txtten.TextLength == 0 || this.txtmk.TextLength == 0)
            {
                this.lbstt.ForeColor = Color.Red;
                this.lbstt.Text = "Bạn chưa nhập tài khoản hoặc mật khẩu!!!";
                this.txtmk.Focus();
            }
            else
            {
                if ((cn.LoadLable(sql)) == "1")
                {
                   // MessageBox.Show("Đăng nhập thành công", "Chúc mừng");
                    this.Hide();
                    frm_Main fr = new frm_Main();
                    fr.quyen = cn.LoadLable(quyen);
                    fr.Show();
                }
                else
                {
                    //MessageBox.Show("Đăng nhập thất bại hoặc\n Bạn không có quyền truy nhập vào hệ thống");
                   // txtten.Focus();
                    this.lbstt.ForeColor = Color.Red;
                    this.lbstt.Text = "Tài khoản không tồn tại!";
                    this.txtten.Clear();
                    this.txtten.Focus();
                    this.txtmk.Clear();
                }
            }
        }

        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
        }

        private void txtmk_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn thoát? ", "Thoát", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sql = "Select count(*) from tbl_nguoidung where TENDANGNHAP=N'" + txtten.Text + "'  and MATKHAU=N'" + txtmk.Text + "'";
            string quyen = "Select PHANQUYEN from tbl_nguoidung where  TENDANGNHAP=N'" + txtten.Text + "'  and MATKHAU=N'" + txtmk.Text + "'";
            if (this.txtten.TextLength == 0 || this.txtmk.TextLength == 0)
            {
                this.lbstt.ForeColor = Color.Red;
                this.lbstt.Text = "Bạn chưa nhập tài khoản hoặc mật khẩu!!!";
                this.txtmk.Focus();
            }
            else
            {
                if ((cn.LoadLable(sql)) == "1")
                {
                    // MessageBox.Show("Đăng nhập thành công", "Chúc mừng");
                    this.Hide();
                    frm_Main fr = new frm_Main();
                    fr.quyen = cn.LoadLable(quyen);
                    fr.Show();
                }
                else
                {
                    //MessageBox.Show("Đăng nhập thất bại hoặc\n Bạn không có quyền truy nhập vào hệ thống");
                    // txtten.Focus();
                    this.lbstt.ForeColor = Color.Red;
                    this.lbstt.Text = "Tài khoản không tồn tại!";
                    this.txtten.Clear();
                    this.txtten.Focus();
                    this.txtmk.Clear();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn thoát? ", "Thoát", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
        }
    }
}