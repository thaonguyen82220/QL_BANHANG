using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBANHANG
{
    public partial class frm_PickSanPham : Form
    {
        int current = -1 ;
        string id = "no";
        ConnectDB cn = new ConnectDB();
        Function f = new Function();
        bool nhap = false;
        public frm_PickSanPham(bool n=false)
        {
            InitializeComponent();
            cn.LoadCombobox(cbLoaihang, "Select * from tbl_loai", "TenLoai", "Ma");
            if (n==false)
            {
                hienthi(false);              
            }
            else
            {
                nhap = true;
                hienthi(true);
            }    
        }
        public void hienthi(bool nhap,string loai = "no", string ten = "no")
        {
            string sql = "";
            if (nhap)
            {
                if (loai == "no" && ten == "no")
                    sql = @"SELECT * from tbl_HANG";
                else
            if (loai != "no" && ten == "no")
                    sql = @"SELECT * from tbl_HANG where LOAI='" + loai + "'";
                else
            if (loai != "no" && ten != "no")
                    sql = @"SELECT * from tbl_HANG where LOAI='" + loai + "' and Ten like N'%" + ten + "%'";
            }  
            else
            {
                if (loai == "no" && ten == "no")
                    sql = @"SELECT * from tbl_HANG where SoLuong > 0";
                else
            if (loai != "no" && ten == "no")
                    sql = @"SELECT * from tbl_HANG where SoLuong > 0 and LOAI='" + loai + "'";
                else
            if (loai != "no" && ten != "no")
                    sql = @"SELECT * from tbl_HANG where SoLuong > 0 and LOAI='" + loai + "' and Ten like N'%" + ten + "%'";
            }    
            dgvSanPham.DataSource = cn.taobang(sql);
        }
        public string GetID()
        {
            return id;
        }
        private void frm_SanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            current = dgvSanPham.CurrentCell.RowIndex;
            id = dgvSanPham.Rows[current].Cells["Ma"].Value.ToString();
            DialogResult = DialogResult.OK;
        }

        private void setID(object sender, DataGridViewCellEventArgs e)
        {
            current = e.RowIndex;
            if (current >= 0)
            {
                id = dgvSanPham.Rows[current].Cells["Ma"].Value.ToString();
                DialogResult = DialogResult.OK;
            }
        }

        private void ThayDoiLoai(object sender, EventArgs e)
        {
            if (nhap)
            {
                hienthi(false, cbLoaihang.SelectedValue.ToString());
            }else
            {
                hienthi(true, cbLoaihang.SelectedValue.ToString());

            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTensp.Text))
            {
                string t = txtTensp.Text;
                if(nhap)
                hienthi(true,cbLoaihang.SelectedValue.ToString(),t);
                else
                    hienthi(false, cbLoaihang.SelectedValue.ToString(), t);
            }
            else
                MessageBox.Show("Vui lòng nhập tên sản phẩm muốn tìm");
        }
    }
}
