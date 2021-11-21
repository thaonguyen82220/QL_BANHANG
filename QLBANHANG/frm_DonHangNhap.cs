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
    public partial class frm_DonHangNhap : Form
    {
        tbl_PhieuNhap phieu;
        int dong = -1;
        Function f = new Function();
        ConnectDB cn = new ConnectDB();
        bool tao = false,edit=false;
        public frm_DonHangNhap()
        {
            InitializeComponent();
            TaoID();
            load();
            cbTrangthai.SelectedIndex = 0;
            btnTao.Enabled = true;
        }
        public frm_DonHangNhap(tbl_PhieuNhap p)
        {
            InitializeComponent();
            load();
            Lock();
            btnTao.Enabled = false;
            btnSua.Enabled = true;
            this.phieu = p;
            this.tao = true;
            txtMaphieu.Text = p.IDPN;
            txtMaphieu.Text = phieu.IDPN;
            txtNguoigiao.Text = p.NguoiGiao;
            txtSdt.Text = phieu.Sdt;
            cbManv.SelectedValue = phieu.MANV;
            cbNhacc.Text = phieu.MANCC;
            dpNgaylap.Value = phieu.NGAY.Value;
            if (phieu.TrangThai == 0)
            {
                cbTrangthai.SelectedIndex = 0;
            }
            else
            {
                cbTrangthai.SelectedIndex = 1;
            }
            Reload();
        }

        public void TaoID()
        {
            txtMaphieu.Text = "PN" + f.RandomNumber() + f.Random(2);
        }
        public void load()
        {
            cn.LoadCombobox(cbManv, "Select * from tbl_NhanVien", "tennv", "manv");
            cn.LoadCombobox(cbNhacc, "Select * from tbl_Nhacungcap", "TENNCC", "mancc");
        }
        public void LoadChiTiet()
        {
            string sql = @"SELECT  Ma, tbl_Hang.Ten, tbl_PhieuNhapChiTiet.SL, tbl_PhieuNhapChiTiet.DonGia, tbl_Hang.DVT, (SL*tbl_Hang.DONGIA) as 'ThanhTien'
            FROM tbl_PhieuNhapChiTiet 
            INNER JOIN tbl_Hang ON tbl_PhieuNhapChiTiet.HANG = tbl_Hang.Ma 
            where  tbl_PhieuNhapChiTiet.ID_PN=N'" + txtMaphieu.Text + "'";
            dgvChitiet.DataSource = cn.taobang(sql);
        }        
        public void Reload()
        {
            LoadChiTiet();
            if(f.GetPhieuNhap(txtMaphieu.Text)!=null)
            txtTongtien.Text = f.GetPhieuNhap(txtMaphieu.Text).TONGTIEN.ToString();
        }
        private void btnTrove_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            UnLock();
            btnLuu.Enabled = true;

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }
        public void Lock()
        {
            cbNhacc.Enabled = false;
            dpNgaylap.Enabled = false;
            cbManv.Enabled = false;
            txtNguoigiao.ReadOnly = true;
            txtSdt.ReadOnly = true;
        }       
        public void UnLock()
        {
            cbNhacc.Enabled = true;
            dpNgaylap.Enabled = true;
            cbManv.Enabled = true;
            txtNguoigiao.ReadOnly = false;
            txtSdt.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tao)
            {

            }
            else
                MessageBox.Show("Vui lòng tạo đơn trước khi lưu");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (frm_PickSanPham frm = new frm_PickSanPham())
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    txtMasp.Text = frm.GetID();
                    btnChon.Enabled = true;
                }
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtMasp.Text) || String.IsNullOrEmpty(txtSoluong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else
                {

                    if (tao && phieu!=null)
                    {
                        if (edit)
                        {
                            var up = f.EditCTPN(phieu.IDPN, txtMasp.Text, int.Parse(txtSoluong.Text));
                            if (up)
                            {

                                MessageBox.Show("Sửa thành công");
                                edit = false;
                                Reload();
                            }
                            else
                                MessageBox.Show("Lỗi");
                        }
                        else
                        {
                            tbl_PhieuNhapChiTiet p = new tbl_PhieuNhapChiTiet();
                            p.ID_PN = phieu.IDPN;
                            p.HANG = txtMasp.Text;
                            p.SL = int.Parse(txtSoluong.Text);
                            p.DonGia = new Function().GetSanPham(txtMasp.Text).DONGIA;
                            bool up = f.AddCTPN(p);
                            if (up)
                            {
                                Reload();
                            }
                            else
                                MessageBox.Show("lỗi");
                        }

                    }
                    else
                        MessageBox.Show("Vui lòng tạo đơn trước");

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Vui lòng nhập đúng số lượng");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var up = f.DeleteCTPB(txtMaphieu.Text, txtMasp.Text);
                if (up)
                {
                    btnXoa.Enabled = false;
                    this.edit = false;
                    Reload();
                }
                else
                    MessageBox.Show("Xóa Thất Bại");

            }
            catch (Exception x)
            {
                throw x;
            }

        }
        private void Select(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                if (dong > -1)
                {
                    txtMasp.Text = dgvChitiet.Rows[dong].Cells["MaSP"].Value.ToString();
                    txtSoluong.Text = dgvChitiet.Rows[dong].Cells["SL"].Value.ToString();
                    btnXoa.Enabled = true;
                    btnChon.Enabled = true;
                    edit = true;
                }
                else
                {
                    edit = false;
                }
            }
            catch
            {

            }
        }


    }
}
