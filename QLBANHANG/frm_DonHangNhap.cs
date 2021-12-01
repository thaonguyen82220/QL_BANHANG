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
            UnLock();
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
            cbNhacc.SelectedValue = phieu.MANCC;
            dpNgaylap.Value = phieu.NGAY.Value;
            if (phieu.TrangThai == 0)
            {
                cbTrangthai.SelectedIndex = 0;
            }
            else
            {
                cbTrangthai.SelectedIndex = 1;
                btnXuathoadon.Text = "Xem hóa đơn";
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
            var ph = f.GetPhieuNhap(txtMaphieu.Text);
            if (ph != null)
            {              
                txtTongtien.Text = ph.TONGTIEN.ToString();
            }
            LoadChiTiet();
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
            if (!string.IsNullOrEmpty(txtNguoigiao.Text))
            {
                if(!string.IsNullOrEmpty(txtSdt.Text))
                {
                    tbl_PhieuNhap p = new tbl_PhieuNhap();
                    p.IDPN = txtMaphieu.Text;
                    p.MANCC = cbNhacc.SelectedValue.ToString();
                    p.NGAY = dpNgaylap.Value;
                    p.MANV = cbManv.SelectedValue.ToString();
                    p.NguoiGiao = txtNguoigiao.Text;
                    p.Sdt = txtSdt.Text;
                    p.TrangThai = 0;
                    p.TONGTIEN = 0;
                    var up = f.AddPhieuNhap(p);
                    if (up)
                    {
                        this.phieu = p;
                        tao = true;
                        btnTao.Enabled = false;
                        MessageBox.Show("Tạo thành công");
                        Reload();
                    }
                    else
                        MessageBox.Show("Lỗi");
                }   
                else
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }
            else
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
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
            if (!string.IsNullOrEmpty(txtSdt.Text))
            {
                if (!string.IsNullOrEmpty(txtNguoigiao.Text))
                {
                    if (tao)
                    {
                        tbl_PhieuNhap p = new tbl_PhieuNhap();
                        p.IDPN = txtMaphieu.Text;
                        p.MANCC = cbNhacc.SelectedValue.ToString();
                        p.MANV = cbManv.SelectedValue.ToString();
                        p.NGAY = dpNgaylap.Value;
                        p.NguoiGiao = txtNguoigiao.Text;
                        p.Sdt = txtSdt.Text;
                        

                        var up = f.EditPhieuNhap(p);
                        if (up)
                        {
                            MessageBox.Show("Lưu thành công");
                            Reload();
                        }
                        else
                            MessageBox.Show("Lỗi");
                    }
                    else
                        MessageBox.Show("Vui lòng tạo đơn trước khi lưu");
                }
                else
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }else
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
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
                            p.DonGia = new Function().GetSanPham(txtMasp.Text).DONGIANHAP;
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
                var up = f.DeleteCTPN(txtMaphieu.Text, txtMasp.Text);
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

        private void btnXuathoadon_Click(object sender, EventArgs e)
        {
            var p = f.GetPhieuNhap(txtMaphieu.Text);
            if (p != null)
            {
                frm_HoaDonNhap frm = new frm_HoaDonNhap(p);
                frm.ShowDialog();
                Reload();
            }
            else
                MessageBox.Show("Vui lòng tạo đơn trước khi thanh toán");
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            frm_NhaCungCap frm = new frm_NhaCungCap();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_Hang frm = new frm_Hang();
            frm.ShowDialog();
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
