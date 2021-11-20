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
    public partial class frm_QuanLyNguoiDung : DevComponents.DotNetBar.Office2007Form
    {
        public frm_QuanLyNguoiDung()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        int dong;
        bool themmoi;

        public void setnull()
        {
            cbnhanvien.Text = "";
            txtten.Text = "";
            txtmk.Text = "";
            cbquyen.Text = "";
        }
        public void Locktext()
        {
            txtten.Enabled = false;
            cbnhanvien.Enabled = false;
            txtmk.Enabled = false;
            cbquyen.Enabled = false;

            cmdthem.Enabled = true;
            cmdluu.Enabled = false;
            cmdsua.Enabled = true;
            cmdxoa.Enabled = true;
        }
        public void Un_locktex()
        {
            txtten.Enabled = true;
            cbnhanvien.Enabled = true;
            txtmk.Enabled = true;
            cbquyen.Enabled = true;
            cmdthem.Enabled = false;
            cmdluu.Enabled = true;
            cmdsua.Enabled = false;
            cmdxoa.Enabled = false;
        }
        public void hienthi()
        {
            string sql = @"SELECT     tbl_NhanVien.tennv, tbl_nguoidung.TENDANGNHAP, tbl_nguoidung.MATKHAU, tbl_nguoidung.PHANQUYEN
FROM         tbl_nguoidung INNER JOIN
                      tbl_NhanVien ON tbl_nguoidung.MANV = tbl_NhanVien.manv";
            msds.DataSource = cn.taobang(sql);
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            setnull();
            Un_locktex();
            themmoi = true;
        }

        private void cmdluu_Click(object sender, EventArgs e)
        {

            if (themmoi == true)
            {
                if (string.IsNullOrEmpty(txtten.Text) || string.IsNullOrEmpty(cbnhanvien.Text) )
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.");
                }
                else
                {
                    string sql = "Select count(*) from tbl_nguoidung where TENDANGNHAP=N'" + txtten.Text + "'";
                    if (cn.LoadLable(sql) == "0")
                    {

                        try
                        {
                            cn.ExcuteNonQuery("insert into tbl_nguoidung values(N'" + cbnhanvien.SelectedValue.ToString() + "',N'" + txtten.Text + "',N'" + txtmk.Text + "',N'" + cbquyen.Text + "')");
                            hienthi();
                            MessageBox.Show("Lưu Thành Công");
                        }
                        catch
                        {
                            MessageBox.Show("Lưu Thất Bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Này Đã Có");
                        txtten.Focus();
                    }
                }
            }
            else
            {
                try
                {
                    cn.ExcuteNonQuery("update tbl_nguoidung set MANV=N'" + cbnhanvien.SelectedValue.ToString() + "',MATKHAU=N'" + txtmk.Text + "',PHANQUYEN=N'" + cbquyen.Text + "' where TENDANGNHAP=N'" + txtten.Text + "'");

                    hienthi();
                    MessageBox.Show("Sửa Thành Công");
                }
                catch
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
            Locktext();
            setnull();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            Un_locktex();
            txtten.Enabled = false;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ExcuteNonQuery("delete tbl_nguoidung where TENDANGNHAP=N'" + txtten.Text + "'");

                hienthi();
                MessageBox.Show("Xóa Thành Công");
                setnull();
            }
            catch
            {
                MessageBox.Show("Xóa Thất Bại");
            }
        }
        private void msds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Locktext();
            dong = e.RowIndex;
            txtten.Text = msds.Rows[dong].Cells["TENDANGNHAP"].Value.ToString();
            cbnhanvien.Text = msds.Rows[dong].Cells["tennv"].Value.ToString();
            txtmk.Text = msds.Rows[dong].Cells["MATKHAU"].Value.ToString();
            cbquyen.Text = msds.Rows[dong].Cells["PHANQUYEN"].Value.ToString();
        }

        private void frm_QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            hienthi();
            Locktext();
            cn.LoadCombobox(cbnhanvien, "Select * from tbl_NhanVien", "tennv", "manv");
        }
    }
}