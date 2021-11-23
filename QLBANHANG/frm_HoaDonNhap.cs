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
    public partial class frm_HoaDonNhap : Form
    {
        int flag = 0;
        bool thanhtoan = false, edit = false, tao = false;
        Function f = new Function();
        int dong = -1;
        ConnectDB cn = new ConnectDB();
        tbl_HoaDonNhap hd = new tbl_HoaDonNhap();
        tbl_PhieuNhap phieu;
        string pt = "Tiền mặt";
        public void CreateMaHD()
        {
            var id = "HDN" + f.RandomNumber() + f.Random(2);
            txtMahoadon.Text = id;
        }
        public void load()
        {
            cn.LoadCombobox(cbNhanvien, "Select * from tbl_NhanVien", "tennv", "manv");
            cn.LoadCombobox(cbNhacc, "Select * from tbl_Nhacungcap", "tenncc", "MANCC");
        }
        public frm_HoaDonNhap()
        {
            InitializeComponent();
            CreateMaHD();
            btnLuu.Text = "Tạo hóa đơn";
            load();
            btnThanhToan.Enabled = true;
            txtNguoigiao.ReadOnly = false;
            txtSdt.ReadOnly = false;
            cbNhanvien.Enabled = true;
            cbNhacc.Enabled = true;
            
        }
        public frm_HoaDonNhap(tbl_HoaDonNhap hd)
        {
            InitializeComponent();
            this.edit = true;
            this.phieu = f.GetPhieuNhap(hd.chungtu);
            this.hd = hd;
            this.tao = true;
            this.Text = "Hóa đơn " + hd.Id;
            load();
            txtMahoadon.Text = hd.Id;
            dpNgaylap.Value = hd.Ngay.Value;
            cbNhanvien.SelectedValue = hd.manv;
            cbNhacc.SelectedValue = hd.mancc;
            txtChungtu.Text = hd.chungtu;
            txtNguoigiao.Text = hd.nguoigiao;
            txtSdt.Text = hd.sdt;
            if (hd.trangthai != 1)
            {
                btnThanhToan.Enabled = true;
                cbTrangthai.SelectedIndex = 0;
            }
            else
            {
                thanhtoan = true;
                cbTrangthai.SelectedIndex = 1;
                btnInhoadon.Enabled = true;
                btnLuu.Enabled = false;
                lbStt.Text = "Đơn hàng đã được thanh toán, bạn không thể chỉnh sửa";
                button1.Enabled = false;
            }
            flag = 1;
            Reload();
        }
        public frm_HoaDonNhap(tbl_PhieuNhap p)
        {
            InitializeComponent();
            this.phieu = p;
            button1.Enabled = false;
            var check = f.TimHoaDonNhapByMaPhieu(phieu.IDPN);
            if (check != null)
            {
                txtMahoadon.Text = check.Id;
                tao = true;
            }
            else
            {
                CreateMaHD();
                btnLuu.Text = "Tạo hóa đơn";
            }    
            load();           
            if (phieu.TrangThai == 0)
            {
                cbTrangthai.SelectedIndex = 0;
                btnThanhToan.Enabled = true;               
                btnInhoadon.Enabled = false;
            }
            else
            {
                cbTrangthai.SelectedIndex = 1;
                thanhtoan = true;
                btnInhoadon.Enabled = true;

            }
            cbNhacc.SelectedValue = phieu.MANCC;
            txtChungtu.Text = phieu.IDPN;
            txtNguoigiao.Text = phieu.NguoiGiao;
            txtSdt.Text = phieu.Sdt;
            cbNhanvien.SelectedValue = phieu.MANV;
            dpNgaylap.Value = phieu.NGAY.Value;
            txtTongtien.Text = phieu.TONGTIEN.ToString();
            txtChungtu.Text = phieu.IDPN;
            flag = 1;
            LoadChiTiet(phieu.IDPN);

        }
        public void LoadChiTiet(string id, int n = 0)
        {
            string sql = "";
            if (n == 0) //n=0 thì load chi tiết phiếu liên quan
                sql = @"select sp.Ma, sp.Ten,sp.dvt, sp.DONGIA, pb.SL, (pb.SL*sp.DONGIA) as 'thanhtien'
                from tbl_PhieuNhapChiTiet pb, tbl_HANG sp
                where sp.Ma = pb.HANG and pb.ID_Pn=N'" + id + "'";
            else //load chi tiết hóa đơn
                sql = @"select sp.Ma, sp.Ten,sp.dvt, sp.DONGIA, pb.soluong as 'SL' , (pb.soluong*sp.DONGIA) as 'thanhtien'
            from tbl_ChiTietHoaDonNhap pb, tbl_HANG sp
            where sp.Ma = pb.masp and pb.ID_hd=N'" + id + "'";

            dgvChitiet.DataSource = cn.taobang(sql);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnThemkhach_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_KhachHang f = new frm_KhachHang();
            f.ShowDialog();
            this.Show();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var hoadon = new tbl_HoaDonNhap();
                hoadon.Id = txtMahoadon.Text;
                hoadon.mancc = cbNhacc.SelectedValue.ToString();
                hoadon.manv = cbNhanvien.SelectedValue.ToString();
                hoadon.Ngay = dpNgaylap.Value;
                hoadon.nguoigiao = txtNguoigiao.Text;
                hoadon.sdt = txtSdt.Text;
                hoadon.tongtien = float.Parse(txtTongtien.Text);
                hoadon.chungtu = txtChungtu.Text;
                hoadon.trangthai = 0;
                if (tao)
                {
                    var up = f.EditHoaDonNhap(hoadon);
                    if (up)
                    {
                        MessageBox.Show("Lưu thành công");
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
                else
                {
                    var up = f.AddHoaDonNhap(hoadon);
                    if (up)
                    {
                        MessageBox.Show("Tạo thành công");
                        tao = true;
                        btnLuu.Text = "Lưu";
                    }
                    else
                        MessageBox.Show("Lỗi");
                }

            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            try
            {
                if (thanhtoan)
                {
                    var hd = f.GetHoaDonNhap(txtMahoadon.Text);
                    frm_ChiTietHoaDonNhap frm = new frm_ChiTietHoaDonNhap(hd);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Bạn phải thanh toán cho hóa đơn trước");
            }
            catch (Exception x)
            {
                throw x;
            }


        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (thanhtoan)
            {
                MessageBox.Show("Hóa đơn đã được thanh toán");
            }
            else
            {
                if (tao)
                {
                    var hd = new tbl_HoaDonNhap();                 

                        hd.Id = txtMahoadon.Text;
                        hd.mancc = cbNhacc.SelectedValue.ToString();
                        hd.manv = cbNhanvien.SelectedValue.ToString();
                        hd.sdt = txtSdt.Text;
                        hd.chungtu = txtChungtu.Text;
                        hd.Ngay = dpNgaylap.Value;
                        hd.tongtien = double.Parse(txtTongtien.Text);
                        var up = f.ThanhToanHoaDonNhap(hd.Id);
                        if (up)
                        {
                            MessageBox.Show("Thanh toán thành công");
                            btnInhoadon.Enabled = true;
                            btnLuu.Enabled = false;
                            btnThanhToan.Enabled = false;
                            cbTrangthai.SelectedIndex = 1;
                            thanhtoan = true;
                        }
                        else
                            MessageBox.Show("Lỗi");
                    
                }
                else
                    MessageBox.Show("Vui lòng tạo hóa đơn trước");


            }
        }
        

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            MessageBox.Show("form load");
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
        private void Get(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                if (dong > -1)
                {
                    this.edit = true;
                    txtMasp.Text = dgvChitiet.Rows[dong].Cells["MaSP"].Value.ToString();
                    txtSoluong.Text = dgvChitiet.Rows[dong].Cells["SL"].Value.ToString();
                    btnXoa.Enabled = true;
                    btnChon.Enabled = true;
                }
                else
                    edit = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!thanhtoan)
                {
                    if (!string.IsNullOrEmpty(txtChungtu.Text) && f.GetPhieuNhap(txtChungtu.Text) != null)
                    {
                        var up = f.DeleteCTPN(txtChungtu.Text, txtMasp.Text);
                        if (up)
                        {
                            btnXoa.Enabled = false;
                            Reload();
                        }
                        else
                            MessageBox.Show("Xóa Thất Bại");
                    }
                    else
                    {
                        var up = f.DeleteCTHDN(txtMahoadon.Text, txtMasp.Text);
                        if (up)
                        {
                            btnXoa.Enabled = false;
                            Reload();
                        }
                        else
                            MessageBox.Show("Xóa Thất Bại");
                    }    
                    
                }
                else
                    MessageBox.Show("Hóa đơn đã thanh toán, bạn không thể sửa");


            }
            catch (Exception x)
            {
                throw x;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                if (thanhtoan)
                {
                    MessageBox.Show("Hóa đơn đã thanh toán, bạn không được sửa");
                }
                else
                {
                    if (String.IsNullOrEmpty(txtMasp.Text) || String.IsNullOrEmpty(txtSoluong.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin");
                    }
                    else
                    {
                            if (tao)
                            {
                                var phieu1 = f.GetPhieuNhap(txtChungtu.Text);
                                if (phieu1 != null)
                                {
                                    if (edit)
                                    {
                                        //f.UpdateKho(txtMasp.Text, (int)f.GetPhieuNhapChiTiet(phieu1.IDPN, txtMasp.Text).SL, int.Parse(txtSoluong.Text));
                                        var up = f.EditCTPN(phieu1.IDPN, txtMasp.Text, int.Parse(txtSoluong.Text));
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
                                        tbl_PhieuNhapChiTiet phieu = new tbl_PhieuNhapChiTiet();
                                        phieu.ID_PN = phieu1.IDPN;
                                        phieu.HANG = txtMasp.Text;
                                        phieu.SL = int.Parse(txtSoluong.Text);
                                        phieu.DonGia = new Function().GetSanPham(txtMasp.Text).DONGIA;
                                        bool up = f.AddCTPN(phieu);
                                        if (up)
                                        {
                                            //f.UpdateKho(txtMasp.Text, int.Parse(txtSoluong.Text), "out");
                                            Reload();
                                        }
                                        else
                                            MessageBox.Show("lỗi");
                                    }

                                }
                                else
                                {
                                    //tạo đơn hang mới cho hóa đơn này
                                    tbl_ChiTietHoaDonNhap cthd = new tbl_ChiTietHoaDonNhap();
                                    cthd.Id_hd = txtMahoadon.Text;
                                    cthd.masp = txtMasp.Text;
                                    cthd.soluong = int.Parse(txtSoluong.Text);
                                    var up = f.AddChiTietHoaDonNhap(txtMahoadon.Text, cthd);
                                    if (up)
                                    {
                                        Reload();
                                    }
                                    else
                                        MessageBox.Show("Vui lòng khởi tạo hóa đơn trước");

                                }
                            }
                            else
                                MessageBox.Show("Vui lòng tạo hóa đơn trước khi thêm hàng");                        

                    }
                }
            }
            catch(Exception x)
            {
                throw x;
            }
        }

        private void ThemChungTu_Click(object sender, EventArgs e)
        {
            using (frm_DSDonHangNhap frm = new frm_DSDonHangNhap(true))
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    txtChungtu.Text = frm.Get_ID_Don();
                    var dh = f.GetPhieuNhap(txtChungtu.Text);
                    txtTongtien.Text = dh.TONGTIEN.ToString();
                    Reload();
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Chon(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtSoluong.Text) > 0)
                {
                    btnChon.Enabled = true;
                }
                else
                    MessageBox.Show("Vui lòng nhập đúng số lượng");

            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng số lượng");
            }
        }

        public void Reload()
        {

            try
            {
                if (!string.IsNullOrEmpty(txtChungtu.Text) && f.GetPhieuNhap(txtChungtu.Text) != null)
                {
                    var current = f.GetPhieuNhap(txtChungtu.Text);                   
                    txtTongtien.Text = current.TONGTIEN.ToString();
                    LoadChiTiet(txtChungtu.Text);
                }
                else
                {
                    LoadChiTiet(txtMahoadon.Text, 1);
                    txtTongtien.Text = f.GetHoaDonNhap(txtMahoadon.Text).tongtien.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
