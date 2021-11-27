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
    public partial class Thao_ThongKeDonHang : Form
    {
        ConnectDB cn = new ConnectDB();
        int flag = 0;
        Function f = new Function();
        string query = @"SELECT tbl_PhieuBanHang.IDPHIEU as id, tbl_KhachHang.tenkh, tbl_NhanVien.tennv, tbl_PhieuBanHang.TongTien, tbl_PhieuBanHang.NGAYGIAO as ngay,                     
            ( case tbl_PhieuBanHang.TrangThai 
	                                    when 0 then N'Đang xử lý' 
	                                    when 1 then N'Đã thanh toán' 
	                                    end) as 'TrangThai'
                                    FROM tbl_PhieuBanHang 
                                    INNER JOIN
                                  tbl_NhanVien ON tbl_PhieuBanHang.MANV = tbl_NhanVien.manv
                                    INNER JOIN tbl_KhachHang on tbl_PhieuBanHang.makh = tbl_KhachHang.makh";
        public Thao_ThongKeDonHang()
        {
            InitializeComponent();
            load();
            LoadDanhSach();
            flag++;
        }
        public void load()
        {
            cn.LoadCombobox(cbMaNV, "Select * from tbl_NhanVien", "tennv", "manv");
            cn.LoadCombobox(cbMaKH, "Select * from tbl_Khachhang", "tenkh", "makh");
        }
        public void LoadDanhSach()
        {
            dgDanhSach.DataSource = cn.taobang(query);
        }
        public void LoadDanhSach(DateTime s, DateTime e)
        {             
            query = @"SELECT tbl_PhieuBanHang.IDPHIEU as id, tbl_KhachHang.tenkh, tbl_NhanVien.tennv, tbl_PhieuBanHang.TongTien, tbl_PhieuBanHang.NGAYGIAO as ngay,                     
            ( case tbl_PhieuBanHang.TrangThai 
	                                    when 0 then N'Đang xử lý' 
	                                    when 1 then N'Đã thanh toán' 
	                                    end) as 'TrangThai'
                                    FROM tbl_PhieuBanHang 
                                    INNER JOIN
                                  tbl_NhanVien ON tbl_PhieuBanHang.MANV = tbl_NhanVien.manv
                                    INNER JOIN tbl_KhachHang on tbl_PhieuBanHang.makh = tbl_KhachHang.makh
								  where tbl_PhieuBanHang.NGAYGIAO>='" + s+"' and tbl_PhieuBanHang.NGAYGIAO<='"+e+"'";
            dgDanhSach.DataSource = cn.taobang(query);
        }
        public void LoadChiTiet(string id, string loai)
        {

        }
        public void Reload()
        {
            LoadDanhSach();
            LoadChiTiet("","");
        }

        private void btnPickKhachHang_Click(object sender, EventArgs e)
        {
            frm_PickKhachHang frm = new frm_PickKhachHang();
            frm.ShowDialog();
        }


        private void CheckThoiGian(object sender, EventArgs e) //check tg chọn xem đúng không
        {
            if (dpStart.Value > dpEnd.Value)
                MessageBox.Show("Ngày chọn không hợp lệ");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbTG.Checked)
            {
                LoadDanhSach(dpStart.Value, dpEnd.Value);
            }
            else
            if (cbDoituong.Enabled)
            {
                LoadDanhSach();
            }
            else
            if(!cbTG.Checked && !cbDoituong.Checked)
                LoadDanhSach();
        }

        private void GetThoiGian(object sender, EventArgs e) // set enabled cho datetimpicker
        {
            if (cbTG.Checked)
            {
                dpStart.Enabled = true;
                dpEnd.Enabled = true;
                cbDoituong.Checked = false;
                cbMaNV.Enabled = false;
                cbMaKH.Enabled = false;
            }
            else
            {
                dpStart.Enabled = false;
                dpEnd.Enabled = false;
            }

        }

        private void GetDoiTuong(object sender, EventArgs e) // set enabled cho đói tượng
        {
            if (cbDoituong.Checked)
            {
                rbNhanVien.Enabled = true;
                rbKH.Enabled = true;
                cbTG.Checked = false;
            }
            else
            {
                rbNhanVien.Enabled = false;
                rbKH.Enabled = false;
            }    
        }

        private void rbChange(object sender, EventArgs e)
        {
            if (rbNhanVien.Checked)
            {
                cbMaNV.Enabled = true;
                cbMaKH.Enabled = false;
                btnPickKhachHang.Enabled = false;
                SetNhanVien();
                
            }
            else
            {
                cbMaNV.Enabled = false;
                cbMaKH.Enabled = true;
                btnPickKhachHang.Enabled = true;
                SetKH();
            }
        }

        private void SetNhanVien(object sender, EventArgs e)
        {
            if (flag > 0)
            {
                query = @"SELECT tbl_PhieuBanHang.IDPHIEU as id, tbl_KhachHang.tenkh, tbl_NhanVien.tennv, tbl_PhieuBanHang.TongTien, tbl_PhieuBanHang.NGAYGIAO as ngay,                     
            ( case tbl_PhieuBanHang.TrangThai 
	                                    when 0 then N'Đang xử lý' 
	                                    when 1 then N'Đã thanh toán' 
	                                    end) as 'TrangThai'
                                    FROM tbl_PhieuBanHang 
                                    INNER JOIN
                                  tbl_NhanVien ON tbl_PhieuBanHang.MANV = tbl_NhanVien.manv
                                    INNER JOIN tbl_KhachHang on tbl_PhieuBanHang.makh = tbl_KhachHang.makh where tbl_PhieuBanHang.MaNv=N'" + cbMaNV.SelectedValue.ToString()+"'";
            }
        }
        private void SetNhanVien()
        {
            if (flag > 0)
            {
                query = @"SELECT tbl_PhieuBanHang.IDPHIEU as id, tbl_KhachHang.tenkh, tbl_NhanVien.tennv, tbl_PhieuBanHang.TongTien, tbl_PhieuBanHang.NGAYGIAO as ngay,                     
            ( case tbl_PhieuBanHang.TrangThai 
	                                    when 0 then N'Đang xử lý' 
	                                    when 1 then N'Đã thanh toán' 
	                                    end) as 'TrangThai'
                                    FROM tbl_PhieuBanHang 
                                    INNER JOIN
                                  tbl_NhanVien ON tbl_PhieuBanHang.MANV = tbl_NhanVien.manv
                                    INNER JOIN tbl_KhachHang on tbl_PhieuBanHang.makh = tbl_KhachHang.makh where tbl_PhieuBanHang.MaNv=N'" + cbMaNV.SelectedValue.ToString() + "'";
            }
        }
        private void SetKH(object sender, EventArgs e)
        {
            if (flag > 0)
            {
                query = @"SELECT tbl_PhieuBanHang.IDPHIEU as id, tbl_KhachHang.tenkh, tbl_NhanVien.tennv, tbl_PhieuBanHang.TongTien, tbl_PhieuBanHang.NGAYGIAO as ngay,                     
            ( case tbl_PhieuBanHang.TrangThai 
	                                    when 0 then N'Đang xử lý' 
	                                    when 1 then N'Đã thanh toán' 
	                                    end) as 'TrangThai'
                                    FROM tbl_PhieuBanHang 
                                    INNER JOIN
                                  tbl_NhanVien ON tbl_PhieuBanHang.MANV = tbl_NhanVien.manv
                                    INNER JOIN tbl_KhachHang on tbl_PhieuBanHang.makh = tbl_KhachHang.makh where tbl_PhieuBanHang.MaKH=N'" + cbMaKH.SelectedValue.ToString() + "'";
            }
        }
        private void SetKH()
        {
            if (flag > 0)
            {
                query = @"SELECT tbl_PhieuBanHang.IDPHIEU as id, tbl_KhachHang.tenkh, tbl_NhanVien.tennv, tbl_PhieuBanHang.TongTien, tbl_PhieuBanHang.NGAYGIAO as ngay,                     
            ( case tbl_PhieuBanHang.TrangThai 
	                                    when 0 then N'Đang xử lý' 
	                                    when 1 then N'Đã thanh toán' 
	                                    end) as 'TrangThai'
                                    FROM tbl_PhieuBanHang 
                                    INNER JOIN
                                  tbl_NhanVien ON tbl_PhieuBanHang.MANV = tbl_NhanVien.manv
                                    INNER JOIN tbl_KhachHang on tbl_PhieuBanHang.makh = tbl_KhachHang.makh where tbl_PhieuBanHang.MaKH=N'" + cbMaKH.SelectedValue.ToString() + "'";
            }
        }

        private void TinhTongSoDonHang(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgDanhSach.Rows.Count > 0)
            {
                txtTongDon.Text = dgDanhSach.Rows.Count.ToString();
                double tong = 0;
                foreach(DataGridViewRow item in dgDanhSach.Rows)
                {
                    tong = tong + (double)item.Cells["tongtien"].Value;
                }
                txtTongTien.Text = tong.ToString();
            }
            
        }
    }
}
