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
    public partial class frm_BaoGia : Form
    {
        int dong = -1;
        string current_p_id ;
        ConnectDB cn = new ConnectDB();
        Function f = new Function();
        tbl_BaoGia bg = new tbl_BaoGia();
        tbl_KhachHang khach = new tbl_KhachHang();
        bool them = false, sua = false, create = false, suact =false;

        public frm_BaoGia()
        {
            InitializeComponent();
            cn.LoadCombobox(cbNhanvien, "Select * from tbl_NhanVien", "tennv", "manv");
            txtSoBaoGia.Text = "BG" + f.RandomNumber() + f.Random(2);
            dpNgaybaogia.Value = DateTime.Now;
            them = true;
            cbNhanvien.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            create = true;
            var listnv = f.GetListNhanVien();
            //for (int i = 0; i < listnv.Count; i++)
            //{
            //    cbNhanvien.Items.Add(listnv[i].manv);
            //}
        }
        public frm_BaoGia(string id)
        {
            InitializeComponent();
            cn.LoadCombobox(cbNhanvien, "Select * from tbl_NhanVien", "tennv", "manv");
            txtSoBaoGia.Text = id;
            this.bg = f.GetBaoGia(id);
            this.khach = f.GetKhachHang(bg.makh);
            dpNgaybaogia.Value = bg.ngay.Value;
            dpHieuLuc.Value = bg.hieuluc.Value;
            txtKhachhang.Text = khach.makh;
            txtLienHe.Text = khach.sdt;
            txtDiaChi.Text = khach.diachi;
            txtGhiChu.Text = bg.ghichu;
            cbNhanvien.SelectedValue = bg.manv;
            btnTao.Enabled = false;
            dpHieuLuc.Enabled = false;
            dpNgaybaogia.Enabled = false;
            Reload();
            sua = true;
            them = true;
        }
        private void frm_BaoGia_Load(object sender, EventArgs e)
        {
                  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (frm_PickKhachHang frm = new frm_PickKhachHang())
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    string id_khach = txtKhachhang.Text = frm.GetID();
                    txtDiaChi.Text = f.GetKhachHang(id_khach).diachi;
                    txtLienHe.Text = f.GetKhachHang(id_khach).sdt;
                }

            }
            Reload();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frm_KhachHang frm = new frm_KhachHang();
            Hide();
            frm.ShowDialog();
            Show();
            Reload();
        }
        private void Reload()
        {
            LoadChiTiet();
            TinhTien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(sua)
            {
                dpHieuLuc.Enabled = true;
                dpNgaybaogia.Enabled = true;
                cbNhanvien.Enabled = true;
            }    
            
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (sua)
            {
                if (dpHieuLuc.Value < dpNgaybaogia.Value)
                {
                    MessageBox.Show("Ngày hiệu lực hoặc ngày báo giá không đúng");
                }
                else
                {
                    tbl_BaoGia bg = new tbl_BaoGia();
                    bg.mabaogia = txtSoBaoGia.Text;
                    bg.hieuluc = dpHieuLuc.Value;
                    bg.ngay = dpNgaybaogia.Value;
                    bg.manv = cbNhanvien.SelectedValue.ToString();
                    bg.makh = txtKhachhang.Text;
                    bg.ghichu = txtGhiChu.Text;
                    var up = f.EditBaoGia(bg);
                    if (up)
                    {
                        MessageBox.Show("Đã lưu");
                        Reload();
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
            }
            else
                MessageBox.Show("Bạn chưa tạo phiếu này");
        }

        private void button7_Click(object sender, EventArgs e) //xóa dòng chi tiết
        {
            var up = f.XoaChiTietBaoGia(bg.mabaogia, current_p_id);
            if (!up)
                MessageBox.Show("Lỗi");
            else
            {
                Reload();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frm_PickSanPham frm = new frm_PickSanPham())
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    txtMasp.Text = frm.GetID();
                }
                btnThem.Text = "Thêm";
                suact = false;
                them = true;
            }
        }
        public void LoadChiTiet()
        {
            string sql = @"select c.masp, s.ten,s.dvt, c.soluong,s.dongia , (c.soluong * s.dongia) as 'thanhtien'
            from tbl_chitietbaogia c, tbl_HANG s
            where c.masp=s.Ma and c.mabaogia='"+ bg.mabaogia + "'";
            dgChitiet.DataSource = cn.taobang(sql);
        }
        private void Select(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                if (dong > -1)
                {
                    btnXoa.Enabled = true;
                    current_p_id = dgChitiet.Rows[dong].Cells["masp"].Value.ToString();
                    txtMasp.Text = current_p_id;
                    txtSoLuong.Text = dgChitiet.Rows[dong].Cells["soluong"].Value.ToString();
                    btnThem.Text = "Sửa";
                    them = false;
                    suact = true;
                }
                else
                {
                    btnXoa.Enabled = false;
                    btnThem.Text = "Thêm";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (dpHieuLuc.Value < dpNgaybaogia.Value)
            {
                MessageBox.Show("Ngày hiệu lực hoặc báo giá không đúng");
            }
            else
            if(string.IsNullOrEmpty(txtKhachhang.Text))
            {
                MessageBox.Show("Chưa chọn khách hàng");
            }
            else
            if (!create)
            {
                MessageBox.Show("Phiếu này đã được tạo");
            }
            else
            if(cbNhanvien.SelectedItem==null)
            {
                MessageBox.Show("Chưa chọn mã nhân viên");
            }   
            else
            {
                tbl_BaoGia bg = new tbl_BaoGia();
                bg.mabaogia = txtSoBaoGia.Text;
                bg.hieuluc = dpHieuLuc.Value;
                bg.ngay = dpNgaybaogia.Value;
                bg.manv = cbNhanvien.SelectedItem.ToString();
                bg.makh = txtKhachhang.Text;
                bg.ghichu = txtGhiChu.Text;
                var up = f.AddBaoGia(bg);
                if (up)
                {
                    create = false;
                    them = true;
                    sua = true;
                    btnTao.Enabled = false;
                    MessageBox.Show("Tạo phiếu thành công");
                    Reload();
                }
                else
                    MessageBox.Show("Lỗi");
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMasp.Text) && !string.IsNullOrEmpty(txtSoLuong.Text))
                {
                    if (int.Parse(txtSoLuong.Text) > 0)
                    {
                        if (them)
                        {
                            tbl_ChiTietBaoGia ct = new tbl_ChiTietBaoGia();
                            ct.mabaogia = txtSoBaoGia.Text;
                            ct.masp = txtMasp.Text;
                            ct.soluong = int.Parse(txtSoLuong.Text);
                            ct.dongia = f.GetSanPham(txtMasp.Text).DONGIA;
                            ct.thanhtien = ct.dongia * ct.soluong;
                            var up = f.AddChiTietBaoGia(ct);
                            if (up)
                            {
                                MessageBox.Show("OK");
                                Reload();
                            }
                            else
                                MessageBox.Show("Lỗi");
                        }
                        else
                        if (suact)
                        {
                            tbl_ChiTietBaoGia ct = new tbl_ChiTietBaoGia();
                            ct.mabaogia = txtSoBaoGia.Text;
                            ct.masp = txtMasp.Text;
                            ct.soluong = int.Parse(txtSoLuong.Text);
                            ct.dongia = f.GetSanPham(txtMasp.Text).DONGIA;
                            ct.thanhtien = ct.dongia * ct.soluong;
                            var up = f.EditChiTietBaoGia(ct);
                            if (up)
                            {
                                MessageBox.Show("OK");
                                suact = false;
                                them = true;
                                Reload();
                            }
                            else
                                MessageBox.Show("Lỗi");
                        }
                        else
                            MessageBox.Show("Bạn chưa tạo phiếu");
                    }
                    else
                        MessageBox.Show("Vui lòng nhập đủ sản phẩm hoặc số lượng");
                }
                else
                    MessageBox.Show("Vui lòng nhập đủ sản phẩm hoặc số lượng");
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng số lượng");
            }

        }
        public void TinhTien()
        {
            txtTongtien.Text = f.TinhTienBaoGia(bg.mabaogia).ToString();
        }
    }
}
