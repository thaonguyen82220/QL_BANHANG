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
    public partial class frm_PickKhachHang : Form
    {
        int current = -1;
        string id = "no";
        public frm_PickKhachHang()
        {
            InitializeComponent();
            hienthi();
        }
        public void hienthi(string id="ta1o9er")
        {
            ConnectDB cn = new ConnectDB();
            string sql = @"SELECT *, 
            (case gioitinh
            when 0 then N'Nữ'
            when 1 then N'Nam'
            end) as 'gt'
             from tbl_KhachHang";
            if (id!="ta1o9er")
            {
                sql = @"SELECT *, 
            (case gioitinh
            when 0 then N'Nữ'
            when 1 then N'Nam'
            end) as 'gt'
             from tbl_KhachHang
             where sdt like '%"+txtSdt.Text+"%'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSdt.Text))
            {
                hienthi(txtSdt.Text);
            }
            else
                MessageBox.Show("Số điện thoại không hợp lệ");
        }
    }
}
