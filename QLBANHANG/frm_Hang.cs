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
    public partial class frm_Hang : DevComponents.DotNetBar.Office2007Form
    {
        public frm_Hang()
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
            cbmenhgia.Text = "";
            cbloai.Text = "";
            txtdongia.Text = "";
        }
        public void Locktext()
        {
            txtten.Enabled = false;
            txtma.Enabled = false;
            txtdongia.Enabled = false;
            cbmenhgia.Enabled = false;
            cbloai.Enabled = false;

            cmdthem.Enabled = true;
            cmdluu.Enabled = false;
            cmdsua.Enabled = true;
            cmdxoa.Enabled = true;
        }
        public void Un_locktex()
        {
            txtten.Enabled = true;
            txtma.Enabled = true;
            txtdongia.Enabled = true;
            cbmenhgia.Enabled = true;
            cbloai.Enabled = true;
            cmdthem.Enabled = false;
            cmdluu.Enabled = true;
            cmdsua.Enabled = false;
            cmdxoa.Enabled = false;
        }
        public void hienthi()
        {
            string sql = @"SELECT     tbl_Hang.Ma, tbl_Hang.Ten, tbl_DVT.Ten as TenDVT, tbl_Loai.TenLoai as TenLoai, tbl_Hang.DONGIA, tbl_Hang.Soluong
FROM         tbl_Hang INNER JOIN
                     tbl_DVT ON tbl_Hang.DVT = tbl_DVT.ID INNER JOIN
                      tbl_Loai ON tbl_Hang.LOAI = tbl_Loai.Ma";
            //msds.DataSource = cn.taobang(sql);
            dgvSanPham.DataSource = cn.taobang(sql);
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
                if (string.IsNullOrEmpty(txtma.Text) || string.IsNullOrEmpty(cbloai.Text) || string.IsNullOrEmpty(cbmenhgia.Text) )
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.");
                }
                else
                {
                    string sql = "Select count(*) from tbl_Hang where Ma=N'" + txtma.Text + "'";
                    if (cn.LoadLable(sql) == "0")
                    {

                        try
                        {
                            cn.ExcuteNonQuery("insert into tbl_Hang values(N'" + txtma.Text + "',N'" + txtten.Text + "',N'" + cbmenhgia.SelectedValue.ToString() + "',N'" + cbloai.SelectedValue.ToString() + "',N'" + txtdongia.Text + "','0')");
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
                    cn.ExcuteNonQuery("update tbl_Hang set Ten=N'" + txtten.Text + "',DVT=N'" + cbmenhgia.SelectedValue.ToString() + "',LOAI=N'" + cbloai.SelectedValue.ToString() + "',DONGIA=N'" + txtdongia.Text + "' where Ma=N'" + txtma.Text + "'");
                    
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
            txtma.Enabled = true;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ExcuteNonQuery("delete tbl_Hang where Ma=N'" + txtma.Text + "'");

                hienthi();
                MessageBox.Show("Xóa Thành Công");
            }
            catch
            {
                MessageBox.Show("Xóa Thất Bại");
            }
        }
        //private void msds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    Locktext();
        //    dong = e.RowIndex;
        //    txtma.Text = msds.Rows[dong].Cells["Ma"].Value.ToString();
        //    txtten.Text = msds.Rows[dong].Cells["Ten"].Value.ToString();
        //    cbmenhgia.Text = msds.Rows[dong].Cells["TenDVT"].Value.ToString();
        //    cbloai.Text = msds.Rows[dong].Cells["Ten"].Value.ToString();
        //    txtdongia.Text = msds.Rows[dong].Cells["DONGIA"].Value.ToString();
        //    cbloai.Text = msds.Rows[dong].Cells["TenLoai"].Value.ToString();
        //}

        private void frm_The_Load(object sender, EventArgs e)
        {
            hienthi();
            Locktext();
            cn.LoadCombobox(cbmenhgia, "Select * from tbl_DVT", "Ten", "ID");
            cn.LoadCombobox(cbloai, "Select * from tbl_Loai", "TenLoai", "Ma");
        }

        private void msds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Locktext();
            dong = e.RowIndex;
            txtma.Text = dgvSanPham.Rows[dong].Cells["Ma"].Value.ToString();
            txtten.Text = dgvSanPham.Rows[dong].Cells["Ten"].Value.ToString();
            cbmenhgia.Text = dgvSanPham.Rows[dong].Cells["TenDVT"].Value.ToString();
            cbloai.Text = dgvSanPham.Rows[dong].Cells["Ten"].Value.ToString();
            txtdongia.Text = dgvSanPham.Rows[dong].Cells["DONGIA"].Value.ToString();
            cbloai.Text = dgvSanPham.Rows[dong].Cells["TenLoai"].Value.ToString();
        }

        private void msds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}