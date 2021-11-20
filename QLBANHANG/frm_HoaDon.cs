using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLBANHANG.Model;

namespace QLBANHANG
{
    public partial class frm_HoaDon : Form
    {
        int flag = 0;
        bool thanhtoan = false, edit = false, tao = false;
        Function f = new Function();
        int dong = -1;
        ConnectDB cn = new ConnectDB();
        tbl_HoaDon hd = new tbl_HoaDon();
        tbl_PhieuBanHang phieu;
        string pt = "Tiền mặt";
        public void CreateMaHD()
        {
            var id = "HD" + f.RandomNumber() + f.Random(2);
            txtMahoadon.Text = id;
        }
        public void load()
        {
            cn.LoadCombobox(cbNhanvien, "Select * from tbl_NhanVien", "tennv", "manv");
            cn.LoadCombobox(cbKhachhang, "Select * from tbl_khachhang", "tenkh", "makh");
        }
        public frm_HoaDon()
        {
            InitializeComponent();
            CreateMaHD();
            btnLuu.Text = "Tạo hóa đơn";
            load();
            btnThanhToan.Enabled = true;
        }
        public frm_HoaDon(tbl_HoaDon hd)
        {
            InitializeComponent();
            this.edit = true;
            this.phieu = f.GetPhieuBanHang(hd.chungtu);
            this.hd = hd;
            this.tao = true;
            this.Text = "Hóa đơn " + hd.Id;
            load();
            txtMahoadon.Text = hd.Id;
            dpNgaylap.Value = hd.Ngay.Value;
            cbNhanvien.SelectedValue = hd.manv;
            cbKhachhang.SelectedValue = hd.makh;
            txtChungtu.Text = hd.chungtu;
            cbNhanvien.SelectedText = "dã chọn";
            if (hd.trangthai != 1)
            {
                btnThanhToan.Enabled = true;
                cbTrangthai.SelectedIndex = 0;
            }
            else
            {
                thanhtoan = true;
                cbTrangthai.SelectedIndex = 1;
            }    
                
            if (hd.phuongthuc == "Thẻ")
                rbThe.Checked = true;
            else
            if (hd.phuongthuc == "Ví điện tử")
                rbVidientu.Checked = true;
            else
                rbTienmat.Checked = true;
            if (thanhtoan)
            {
                btnInhoadon.Enabled = true;
                btnLuu.Enabled = false;
                txtDanhan.ReadOnly = true;
                grStt.Visible = true;
                lbStt.Text = "Đơn hàng đã được thanh toán, bạn không thể chỉnh sửa";
                button1.Enabled = false;
            }
            txtDanhan.Text = hd.danhan.ToString();
            flag = 1;
            Reload();
        }
        public frm_HoaDon(tbl_PhieuBanHang phieu)
        {
            InitializeComponent();
            this.phieu = phieu;
            var check = f.TimHoaDonByMaPhieuBan(phieu.IDPHIEU);
            if (check != null)
            {
                txtMahoadon.Text = check.Id;
            }
            load();
            cbKhachhang.SelectedValue = phieu.MAKH;
            if (phieu.TrangThai == 0)
            {
                cbTrangthai.SelectedIndex = 0;
                btnThanhToan.Enabled = true;
                btnLuu.Text = "Tạo hóa đơn";
                btnInhoadon.Enabled = false;
                CreateMaHD();
            }
            else
            {
                cbTrangthai.SelectedIndex = 1;
                thanhtoan = true;
                btnInhoadon.Enabled = true;

            }
            
            cbNhanvien.SelectedValue = phieu.MANV;
            dpNgaylap.Value = DateTime.Now;       
            txtTongtien.Text = phieu.TongTien.ToString();
            txtChungtu.Text = phieu.IDPHIEU;
            flag = 1;
            LoadChiTiet(phieu.IDPHIEU);
            
        }
        public void LoadChiTiet(string id, int n = 0)
        {
            string sql = "";
            if (n == 0) //n=0 thì load chi tiết phiếu liên quan
                sql = @"select sp.Ma, sp.Ten,sp.dvt, sp.DONGIA, pb.SL, (pb.SL*sp.DONGIA) as 'thanhtien'
                from tbl_PhieuBanChiTiet pb, tbl_HANG sp
                where sp.Ma = pb.HANG and pb.ID_Pb=N'" + id + "'";
            else //load chi tiết hóa đơn
                sql = @"select sp.Ma, sp.Ten,sp.dvt, sp.DONGIA, pb.soluong as 'SL' , (pb.soluong*sp.DONGIA) as 'thanhtien'
            from tbl_ChiTietHoaDon pb, tbl_HANG sp
            where sp.Ma = pb.masp and pb.ID_hd=N'" + id + "'";

            dgvChitiet.DataSource = cn.taobang(sql);
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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
        private void Test(object sender, EventArgs e)
        {
            try
            {
                if(float.Parse(txtDanhan.Text) >= float.Parse(txtTongtien.Text))
                {
                    txtTrakhach.Text = (int.Parse(txtDanhan.Text) - int.Parse(txtTongtien.Text)).ToString();
                    var up = f.UpdateTienNhanHoaDon(txtMahoadon.Text,float.Parse(txtDanhan.Text));
                    if (!up)
                        MessageBox.Show("Sửa tiền lỗi");
                }
                else
                {
                    MessageBox.Show("Số tiền không đủ");
                    txtDanhan.Text = "0";
                    txtTrakhach.Text = "0";
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập lại");
            }
        }
        private void TienTraKhach(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtDanhan.Text) < 0 )
                {
                    MessageBox.Show("Số tiền không đúng");
                    txtDanhan.Text = "0";
                }
            }
            catch(Exception x)
            {               
                txtDanhan.Text = "0";
                MessageBox.Show("Số tiền không đúng");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var hoadon = new tbl_HoaDon();
                hoadon.Id = txtMahoadon.Text;
                hoadon.makh = cbKhachhang.SelectedValue.ToString();
                hoadon.manv = cbNhanvien.SelectedValue.ToString();
                hoadon.Ngay = dpNgaylap.Value;
                hoadon.phuongthuc = pt;
                hoadon.stk = txtStk.Text;
                hoadon.tongtien = float.Parse(txtTongtien.Text);
                hoadon.chungtu = txtChungtu.Text;
                hoadon.danhan = float.Parse(txtDanhan.Text);
                hoadon.trangthai = 0;
                if (tao)
                {
                    var up = f.EditHoaDon(hoadon);
                    if (up)
                    {
                        MessageBox.Show("Lưu thành công");
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
                else
                {
                    var up = f.AddHoaDon(hoadon);
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
                    var hd = f.GetHoaDon(txtMahoadon.Text);
                    frm_ChiTietHoaDon frm = new frm_ChiTietHoaDon(hd);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Bạn phải thanh toán cho hóa đơn trước");
            }
            catch(Exception x)
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
                    var hd = new tbl_HoaDon();
                    if (rbThe.Checked)
                    {
                        hd.phuongthuc = "Thẻ";
                    }
                    else
                    if (rbTienmat.Checked)
                    {
                        hd.phuongthuc = "Tiền mặt";
                    }
                    else
                    if (rbVidientu.Checked)
                    {
                        hd.phuongthuc = "Ví điện tử";
                    }

                    if (string.IsNullOrEmpty(hd.phuongthuc))
                    {
                        MessageBox.Show("Vui lòng chọn phương thức thanh toán ");
                    }
                    else
                    {
                        hd.Id = txtMahoadon.Text;
                        hd.makh = cbKhachhang.SelectedValue.ToString();
                        hd.manv = cbNhanvien.SelectedValue.ToString();
                        hd.stk = txtStk.Text;
                        hd.chungtu = txtChungtu.Text;
                        hd.Ngay = dpNgaylap.Value;
                        hd.tongtien = double.Parse(txtTongtien.Text);
                        var up = f.ThanhToanHoaDon(hd.Id);
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
                }
                else
                    MessageBox.Show("Vui lòng tạo hóa đơn trước");


            }
        }

        private void Select(object sender, EventArgs e)
        {
            if (flag != 0)
            {
                if (rbThe.Checked)
                {
                    txtStk.Text = f.GetKhachHang(cbKhachhang.SelectedValue.ToString()).stk;
                    pt = "Thẻ";
                }
                else
                if (rbVidientu.Checked)
                {
                    txtStk.Text = f.GetKhachHang(cbKhachhang.SelectedValue.ToString()).stk;
                    pt = "Ví điện tử";
                }
                else
                {
                    txtStk.Text = "";
                    pt = "Tiền mặt";
                }
            }

        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {

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
                var up = f.DeleteCTPB(txtChungtu.Text, txtMasp.Text);
                if (up)
                {
                    btnXoa.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (Thao_DSDonHang frm = new Thao_DSDonHang(true))
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    txtChungtu.Text = frm.Get_ID_Don();
                    var dh = f.GetPhieuBanHang(txtChungtu.Text);
                    txtStk.Text = f.GetKhachHang(dh.MAKH).stk;
                    cbKhachhang.SelectedValue = dh.MAKH;
                    txtTongtien.Text = dh.TongTien.ToString();
                    Reload();
                }
            }

        }

        private void btnChon_Click(object sender, EventArgs e)
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
                    var kho = f.GetSanPham(txtMasp.Text).Soluong;
                    if (int.Parse(txtSoluong.Text) > kho)
                    {
                        MessageBox.Show("Sản phẩm trong kho không đủ");
                    }
                    else
                    {
                        if (tao)
                        {
                            var phieu1 = f.GetPhieuBanHang(txtChungtu.Text);
                            if (phieu1 != null)
                            {
                                if (edit)
                                {
                                    f.UpdateKho(txtMasp.Text, (int)f.GetPhieuBanChiTiet(phieu1.IDPHIEU, txtMasp.Text).SL, int.Parse(txtSoluong.Text));
                                    var up = f.EditCTPB(phieu1.IDPHIEU, txtMasp.Text, int.Parse(txtSoluong.Text));
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
                                    phieu.ID_PB = phieu1.IDPHIEU;
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
                            {
                                //tạo đơn hang mới cho hóa đơn này
                                tbl_ChiTietHoaDon cthd = new tbl_ChiTietHoaDon();
                                cthd.Id_hd = txtMahoadon.Text;
                                cthd.masp = txtMasp.Text;
                                cthd.soluong = int.Parse(txtSoluong.Text);
                                var up = f.AddChiTietHoaDon(txtMahoadon.Text, cthd);
                                if (up)
                                {
                                    Reload();
                                }
                                else
                                    MessageBox.Show("Vui lòng khởi tạo hóa đơn trước");

                            }
                        }
                        else
                            MessageBox.Show("Vui lòng tạo hóa đơn trước khi chỉnh sửa");

                    }

                }
            }

        }
        
        private void LayStk(object sender, EventArgs e)
        {
            if (flag != 0)
            {
                rbThe.Checked = true;
                txtStk.Text = f.GetKhachHang(cbKhachhang.SelectedValue.ToString()).stk;
            }

        }

        private void lbStt_Click(object sender, EventArgs e)
        {

        }

        private void grStt_Enter(object sender, EventArgs e)
        {

        }

        private void dgvChitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                if (f.GetPhieuBanHang(txtChungtu.Text) != null)
                {
                    txtTongtien.Text = f.GetHoaDon(txtMahoadon.Text).tongtien.ToString();
                    LoadChiTiet(txtChungtu.Text);
                }
                else
                {
                    LoadChiTiet(txtMahoadon.Text, 1);
                    txtTongtien.Text = f.GetHoaDon(txtMahoadon.Text).tongtien.ToString();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("<<< catch : " + ex.ToString());
            }

        }

    }
}
