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
    public partial class frm_DSDonHangNhap : Form
    {
        ConnectDB cn = new ConnectDB();
        Function f = new Function();
        int dong = -1;
        string id_don;
        bool pick = false;
        public frm_DSDonHangNhap(bool pick = false)
        {
            InitializeComponent();
            this.pick = pick;
            if (pick)
            {
                gbChon.Visible = true;
                btnChon.Visible = true;
            }
            LoadDanhSach();
        }
        public string Get_ID_Don()
        {
            return id_don;
        }
        public void LoadDanhSach()
        {
            string sql = @"SELECT * from tbl_PhieuNhap";
            dgDanhsach.DataSource = cn.taobang(sql);
        }
        public void LoadDanhSach(DateTime s, DateTime e)
        {
            string query = @"SELECT * from tbl_phieunhap where ngay >= '"+s+"' and ngay <= '"+e+"'";
            dgDanhsach.DataSource = cn.taobang(query);
        }
        public void LoadChiTiet(string id)
        {
            string sql = @"SELECT  Ma, tbl_Hang.Ten, tbl_PhieuNhapChiTiet.SL, tbl_PhieuNhapChiTiet.DonGia, tbl_Hang.DVT, (SL*tbl_Hang.DONGIA) as 'ThanhTien'
            FROM tbl_PhieuNhapChiTiet 
            INNER JOIN tbl_Hang ON tbl_PhieuNhapChiTiet.HANG = tbl_Hang.Ma 
            where  tbl_PhieuNhapChiTiet.ID_PN=N'" + id + "'";
            dgvChitiet.DataSource = cn.taobang(sql);
        }
        private void Select(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                if (dong > -1)
                {
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    id_don = dgDanhsach.Rows[dong].Cells["IDPN"].Value.ToString();
                    LoadChiTiet(id_don);
                }
                else
                {
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var up = f.XoaPhieuNhap(id_don);
            if (!up)
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                btnChon.Enabled = false;
                LoadDanhSach();
                LoadChiTiet("");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dpNgay.Value >= dpNgayGiao.Value)
            {
                MessageBox.Show("Ngày chọn không hợp lệ");
            }
            else
            {
                LoadDanhSach(dpNgay.Value, dpNgayGiao.Value);
                LoadChiTiet(null);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var phieu = f.GetPhieuNhap(id_don);
                frm_DonHangNhap frm = new frm_DonHangNhap(phieu);
                this.Hide();
                frm.ShowDialog();
                this.Show();
                LoadDanhSach();
                LoadChiTiet("");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frm_DonHangNhap frm = new frm_DonHangNhap())
            {
                frm.ShowDialog();
            }
            LoadDanhSach();
            LoadChiTiet(null);
            this.Show();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }

}
