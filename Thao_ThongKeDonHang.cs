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
        Function f = new Function();
        public Thao_ThongKeDonHang()
        {
            InitializeComponent();
            load();
            LoadDanhSach();
        }
        public void load()
        {
            cn.LoadCombobox(cbMaNV, "Select * from tbl_NhanVien", "tennv", "manv");
            cn.LoadCombobox(cbMaKH, "Select * from tbl_Khachhang", "tenkh", "makh");
        }
        public void LoadDanhSach()
        {
            string sql = @"SELECT tbl_PhieuBanHang.IDPHIEU as id, tbl_NhanVien.tennv, tbl_PhieuBanHang.TongTien,tbl_PhieuBanHang.Loai, tbl_PhieuBanHang.NGAYGIAO as ngay,                     
            ( case tbl_PhieuBanHang.TrangThai 
	                                    when 0 then N'Đang xử lý' 
	                                    when 1 then N'Đã thanh toán' 
	                                    end) as 'TrangThai'
                                    FROM         tbl_PhieuBanHang INNER JOIN
                                  tbl_NhanVien ON tbl_PhieuBanHang.MANV = tbl_NhanVien.manv 

            union 
                                  SELECT tbl_PhieuNhap.IDPN as id,tbl_Nhanvien.tennv, tbl_PhieuNhap.TongTien, tbl_PhieuNhap.Loai, tbl_PhieuNhap.NGAY as ngay,
                                    ( case tbl_PhieuNhap.TrangThai 
	                                    when 0 then N'Đang xử lý' 
	                                    when 1 then N'Đã thanh toán' 
	                                    end) as 'TrangThai'
                                    FROM         tbl_PhieuNhap INNER JOIN
                                  tbl_NhanVien ON tbl_PhieuNhap.MANV = tbl_NhanVien.manv";
            dgDanhSach.DataSource = cn.taobang(sql);
        }

        public void LoadChiTiet(string id, string loai)
        {

        }
        public void Reload()
        {
            LoadDanhSach();
            LoadChiTiet("","");
        }
    }
}
