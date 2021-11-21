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
    public partial class frm_DonHangBan : Form
    {
        int dong, flag=0;
        tbl_PhieuBanHang phieu;
        Function f = new Function();
        ConnectDB cn = new ConnectDB();
        string id;
        tbl_KhachHang khach;
        bool tao = false, edit = false;

        private void frm_DonHang_Load(object sender, EventArgs e)
        {            
        }
        public void load()
        {
            cn.LoadCombobox(cbManv, "Select * from tbl_NhanVien", "tennv", "manv");
            cn.LoadCombobox(cbKhachhang, "Select * from tbl_khachhang", "tenkh", "makh");
        }
        public frm_DonHangBan(tbl_PhieuBanHang phieu)
        {
            InitializeComponent();
            btnTao.Enabled = false;
            btnSua.Enabled = true;
            this.tao = true;
            load();
            this.phieu = phieu;
            this.id = phieu.IDPHIEU;
            khach = f.GetKhachHang(this.phieu.MAKH);
            txtMadonhang.Text = phieu.IDPHIEU;
            txtNguoinhan.Text = khach.tenkh;
            txtDiachi.Text = khach.diachi;
            txtSdt.Text = khach.sdt;
            dpNgaylap.Value = phieu.NGAYLAP.Value;
            dpNgaygiao.Value = phieu.NGAYGIAO.Value;
            cbKhachhang.SelectedValue = phieu.MAKH;
            cbManv.SelectedValue = phieu.MANV;
            if (f.GetPhieuBanHang(id).TrangThai == 1)
            {
                btnXuathoadon.Text = "Xem hóa đơn";
                
            }
            if (phieu.TrangThai == 1)
            {
                btnXuathoadon.Text = "Xem hóa đơn";
            }
            if (phieu.TrangThai == 0)
            {
                cbTrangthai.SelectedIndex = 0;
            }
            else
                cbTrangthai.SelectedIndex = 1;
            this.flag = 1;
            Lock();
            Reload();
        }
        public frm_DonHangBan()
        {
            InitializeComponent();
            load();
            txtMadonhang.Text = "DH" + f.RandomNumber() + f.Random(2);
        }

        public void hienthi(string SOHD)
        {
            string sql = @"SELECT  Ma,tbl_PhieuBanChiTiet.ID_PB, tbl_Hang.Ten, tbl_PhieuBanChiTiet.SL, tbl_PhieuBanChiTiet.DonGia, tbl_Hang.DVT, (SL*tbl_Hang.DONGIA) as 'ThanhTien'
            FROM tbl_PhieuBanChiTiet 
            INNER JOIN tbl_Hang ON tbl_PhieuBanChiTiet.HANG = tbl_Hang.Ma 
            where  tbl_PhieuBanChiTiet.ID_PB=N'" + SOHD + "'";
            ConnectDB cn = new ConnectDB();
            dgvChitiet.DataSource = cn.taobang(sql);
        }
        public void Reload()
        {
            hienthi(id);
            if (id == null)
            {
                txtTongtien.Text = "0";
                cbTrangthai.SelectedIndex = 0;
            }              
            else
            {
                txtTongtien.Text = f.GetPhieuBanHang(id).TongTien.ToString();
                var hd = f.TimHoaDonByMaPhieuBan(txtMadonhang.Text);
                if (hd != null)
                {
                    var up = f.UpdateTongTienHoaDonByMaPhieuBan(txtMadonhang.Text);
                    if (!up)
                        MessageBox.Show("Lỗi hóa đơn");
                }
                if (phieu.TrangThai == 1)
                    cbTrangthai.SelectedIndex = 1;
                else
                    cbTrangthai.SelectedIndex = 0;
            }    
                
        }
        public void Lock()
        {
            cbKhachhang.Enabled = false;
            dpNgaygiao.Enabled = false;
            dpNgaylap.Enabled = false;
            cbTrangthai.Enabled = false;
            cbManv.Enabled = false;
        }
        public void UnLock()
        {
            cbKhachhang.Enabled = true;
            dpNgaygiao.Enabled = true;
            dpNgaylap.Enabled = true;
            cbTrangthai.Enabled = true;
            cbManv.Enabled = true;
        }


        private void btnTrove_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var up = f.DeleteCTPB(txtMadonhang.Text, txtMasp.Text);
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

        private void Get(object sender, DataGridViewCellEventArgs e)
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            UnLock();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (dpNgaylap.Value <= dpNgaygiao.Value)
            {
                tbl_PhieuBanHang p = new tbl_PhieuBanHang();
                p.IDPHIEU = txtMadonhang.Text;
                p.MAKH = cbKhachhang.SelectedValue.ToString();
                if (cbTrangthai.SelectedValue == null)
                    p.TrangThai = 0;
                else
                    p.TrangThai = int.Parse(cbTrangthai.SelectedValue.ToString());

                p.NGAYLAP = dpNgaylap.Value;
                p.NGAYGIAO = dpNgaygiao.Value;
                p.MANV = cbManv.SelectedValue.ToString();
                p.TongTien = 0;
                var up = f.AddPhieuBan(p);
                if (up)
                {
                    this.phieu = p;
                    this.id = p.IDPHIEU;
                    tao = true;
                    btnTao.Enabled = false;
                    MessageBox.Show("Tạo thành công");
                    Reload();
                }
                else
                    MessageBox.Show("Lỗi");

            }
            else
                MessageBox.Show("Ngày nhập vào không hợp lệ");
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            var p = f.GetPhieuBanHang(id);
            if (p != null)
            {
                frm_HoaDon frm = new frm_HoaDon(p);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Không tìm thấy hóa đơn");

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
                    var kho = f.GetSanPham(txtMasp.Text).Soluong;
                    if (int.Parse(txtSoluong.Text) > kho)
                    {
                        MessageBox.Show("Sản phẩm trong kho không đủ");
                    }
                    else
                    if (id != null)
                    {
                        if (edit)
                        {
                            f.UpdateKho(txtMasp.Text, (int)f.GetPhieuBanChiTiet(id, txtMasp.Text).SL, int.Parse(txtSoluong.Text));
                            var up = f.EditCTPB(id, txtMasp.Text, int.Parse(txtSoluong.Text));
                            if (up)
                            {

                                MessageBox.Show("Sửa thành công");
                                Reload();
                            }
                            else
                                MessageBox.Show("Lỗi");
                        }
                        else
                        {
                            tbl_PhieuBanChiTiet phieu = new tbl_PhieuBanChiTiet();
                            phieu.ID_PB = id;
                            phieu.HANG = txtMasp.Text;
                            phieu.SL = int.Parse(txtSoluong.Text);
                            phieu.DonGia = new Function().GetSanPham(txtMasp.Text).DONGIA;
                            bool up = f.AddCTPB(phieu);
                            if (up)
                            {
                                f.UpdateKho(txtMasp.Text, int.Parse(txtSoluong.Text), "out");
                                Reload();
                            }
                            else
                                MessageBox.Show("lỗi");
                        }

                    }
                    else
                        MessageBox.Show("Hóa đơn chưa được tạo");

                }
            }
            catch(Exception x)
            {
                MessageBox.Show (x.Message);
            }

        }
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (dpNgaylap.Value > dpNgaygiao.Value)
            {
                MessageBox.Show("Ngày nhập vào không hợp lệ");
            }
            else
            {
                if (!tao)
                {
                    MessageBox.Show("Bạn chưa tạo phiếu này");
                }
                else
                {
                    tbl_PhieuBanHang p = new tbl_PhieuBanHang();
                    p.IDPHIEU = txtMadonhang.Text;
                    p.MAKH = cbKhachhang.SelectedValue.ToString();
                    p.MANV = cbManv.SelectedValue.ToString();
                    p.NGAYLAP = dpNgaylap.Value;
                    p.NGAYGIAO = dpNgaygiao.Value;
                    if (cbTrangthai.SelectedValue == null)
                        p.TrangThai = 0;
                    else
                        p.TrangThai = int.Parse(cbTrangthai.SelectedValue.ToString());

                    var up = f.EditPhieuBan(p);
                    if (up)
                    {
                        MessageBox.Show("Lưu thành công");
                        Reload();
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
            }
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_KhachHang frm = new frm_KhachHang();
            Hide();
            frm.ShowDialog();
            Show();
            Reload();
        }

        private void LayThongTinKhachHang(object sender, EventArgs e)
        {
            if (flag != 0)
            {
                var khach = f.GetKhachHang(cbKhachhang.SelectedValue.ToString());
                if (khach != null)
                {
                    txtNguoinhan.Text = khach.tenkh;
                    txtSdt.Text = khach.sdt;
                    txtDiachi.Text = khach.diachi;
                }
                else
                    MessageBox.Show("Lỗi");
            }
            
        }

        private void GetInfo(object sender, EventArgs e)
        {
            if (cbKhachhang.SelectedItem != null && cbKhachhang.SelectedIndex != -1)
            {
                this.khach = f.GetKhachHang(cbKhachhang.SelectedValue.ToString());
                if (khach != null)
                {
                    txtNguoinhan.Text = khach.tenkh;
                    txtDiachi.Text = khach.diachi;
                    txtSdt.Text = khach.sdt;
                }
            }
        }
    }
}
