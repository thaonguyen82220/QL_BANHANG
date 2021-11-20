using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBANHANG.Model;

namespace QLBANHANG
{
    public partial class frm_PhieuNhapHang : Form
    {
        int dong;
        bool sua = false, them = false;
        Function f = new Function();
        ConnectDB cn = new ConnectDB();
        public frm_PhieuNhapHang()
        {
            InitializeComponent();
            hienthi();
            dpNgay.Value = DateTime.Now;
        }
        public void hienthi()
        {
            string sql = @"SELECT * from tbl_PhieuNhap";
            dgvChitiet.DataSource = cn.taobang(sql);
        }
        private void Select(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                txtMaPhieu.Text = dgvChitiet.Rows[dong].Cells["IDPN"].Value.ToString();
                dpNgay.Value = (DateTime)dgvChitiet.Rows[dong].Cells["NGAY"].Value;
                txtNguoiGiao.Text = dgvChitiet.Rows[dong].Cells["NguoiGiao"].Value.ToString();
                txtSdt.Text = dgvChitiet.Rows[dong].Cells["Sdt"].Value.ToString();
            }
            catch
            {
                
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Text = "PN" + f.RandomNumber() + f.Random(2);
            them = true;
            btnThem.Enabled = false;
            txtSdt.ReadOnly = false;
            txtNguoiGiao.ReadOnly = false;
            dpNgay.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnChitiet.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dong >= 0)
            {
                txtNguoiGiao.Enabled = true;
                txtNguoiGiao.ReadOnly = false;
                txtSdt.Enabled = true;
                txtSdt.ReadOnly = false;
                dpNgay.Enabled = true;
                sua = true;
                btnXoa.Enabled = false;
            }
            else
                MessageBox.Show("Bạn chưa chọn bản ghi");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dong >= 0)
            {
                var up = f.DeletePhieuNhap(txtMaPhieu.Text);
                if (up)
                {
                    MessageBox.Show("Xóa thành công");
                    hienthi();
                }
                else
                    MessageBox.Show("Lỗi");

            }
            else
                MessageBox.Show("Bạn chưa chọn bản ghi");
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            them = false;
            btnThem.Enabled = true;
            txtSdt.ReadOnly = true;
            txtNguoiGiao.ReadOnly = true;
            dpNgay.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnChitiet.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dong >= 0)
            {
                var o = new tbl_PhieuNhap();
                o.IDPN = txtMaPhieu.Text;
                o.NGAY = dpNgay.Value;
                o.NguoiGiao = txtNguoiGiao.Text;
                o.Sdt = txtSdt.Text;
                bool up =  false;                
                if (them)
                {
                    up = f.AddPhieuNhap(o);
                } 
                else
                up = f.EditPhieuNhap(o);

                if (up)
                {
                    MessageBox.Show("Thành công");                                   
                }
                else
                    MessageBox.Show("Lỗi");

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnChitiet.Enabled = true;
                them = false;
                sua = false;
                hienthi();
            }
        
            else
                MessageBox.Show("Bạn chưa chọn bản ghi");
            } 
        }
}

