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
    public partial class frm_NhanVien : DevComponents.DotNetBar.Office2007Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        int dong;
        bool themmoi;

        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdc.Text = "";
            txtdt.Text = "";
            txtCNMND.Text = "";
        }
        public void Locktext()
        {
            txtten.Enabled = false;
            txtma.Enabled = false;
            txtdc.Enabled = false;
            txtdt.Enabled = false;
            txtCNMND.Enabled = false;
            cmdthem.Enabled = true;
            cmdluu.Enabled = false;
            cmdsua.Enabled = true;
            cmdxoa.Enabled = true;
        }
        public void Un_locktex()
        {
            txtCNMND.Enabled = true;
            txtten.Enabled = true;
            txtma.Enabled = true;
            txtdc.Enabled = true;
            txtdt.Enabled = true;
            cmdthem.Enabled = false;
            cmdluu.Enabled = true;
            cmdsua.Enabled = false;
            cmdxoa.Enabled = false;
        }
        public void hienthi()
        {
            string sql = "Select * from tbl_NhanVien";
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
                if (string.IsNullOrEmpty(txtma.Text) )
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.");
                }
                else
                {
                    string sql = "Select count(*) from tbl_NhanVien where manv=N'" + txtma.Text + "'";
                    if (cn.LoadLable(sql) == "0")
                    {

                        try
                        {
                            cn.ExcuteNonQuery("insert into tbl_NhanVien values(N'" + txtma.Text + "',N'" + txtten.Text + "',N'" + txtdc.Text + "',N'" + txtdt.Text + "',N'" + txtCNMND.Text + "')");
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
                    cn.ExcuteNonQuery("update tbl_NhanVien set diachi=N'" + txtdc.Text + "',sdt=N'" + txtdt.Text + "',tennv=N'" + txtten.Text + "',CMND=N'" + txtCNMND.Text + "' where manv=N'" + txtma.Text + "'");

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
            txtma.Enabled = false;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ExcuteNonQuery("delete tbl_NhanVien where manv=N'" + txtma.Text + "'");

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
            try
            {
                dong = e.RowIndex;
                txtma.Text = msds.Rows[dong].Cells["manv"].Value.ToString();
                txtten.Text = msds.Rows[dong].Cells["tennv"].Value.ToString();
                txtdc.Text = msds.Rows[dong].Cells["diachi"].Value.ToString();
                txtdt.Text = msds.Rows[dong].Cells["sdt"].Value.ToString();
                txtCNMND.Text = msds.Rows[dong].Cells["CMND"].Value.ToString();
            }
            catch
            {  }

        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            hienthi();
            Locktext();
        }
    }
}