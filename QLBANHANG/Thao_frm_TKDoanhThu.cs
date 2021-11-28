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
    public partial class Thao_frm_TKDoanhThu : Form
    {
        int flag = 0;
        string query = @"select id, ngay, nv.tennv, chungtu,loai,tongtien 
        from tbl_Hoadonnhap, tbl_nhanvien nv
        where tbl_HoaDonNhap.manv = nv.manv and tbl_HoaDonNhap.TrangThai=1
        union
        select id, ngay, nv.tennv, chungtu,loai,tongtien 
        from tbl_Hoadonban, tbl_nhanvien nv
        where tbl_HoaDonBan.manv = nv.manv and tbl_HoaDonBan.trangthai =1";

        ConnectDB cn = new ConnectDB();
        public void LoadCombobox()
        {
            cn.LoadCombobox(cbNhanvien,"select * from tbl_NhanVien","tennv","manv");
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public void LoadDanhSach()
        {
            dgDanhSach.DataSource = cn.taobang(query);
        }
        public Thao_frm_TKDoanhThu()
        {
            InitializeComponent();
            LoadCombobox();
            LoadDanhSach();
        }
        private void GetThoiGian(object sender, EventArgs e)
        {
            if (cbTG.Checked)
            {

            }
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            dgDanhSach.DataSource = cn.taobang("select * from tbl_KhachHang");
        }
    }
}
