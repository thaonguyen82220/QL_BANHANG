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
    public partial class frm_DSHoaDonNhap : Form
    {
        
        Function f = new Function();
        ConnectDB cn = new ConnectDB();
        int dong = -1;
        string id_don;
        tbl_HoaDonNhap hd = new tbl_HoaDonNhap();

        public frm_DSHoaDonNhap()
        {
            InitializeComponent();
            LoadDanhSach();
        }
        public void Reload()
        {
            LoadDanhSach();
            LoadChiTiet("");
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void LoadDanhSach()
        {
            string sql = @"select hd.Id,hd.Ngay, n.tenncc, nv.tennv,hd.nguoigiao,hd.sdt, hd.chungtu, hd.tongtien,
            (case hd.trangthai
            when 0 then N'Đang xử lý'
            when 1 then N'Đã thanh toán'
            end) as 'trangthai'
            from tbl_HoaDonNhap hd, tbl_NhaCungCap n, tbl_NhanVien nv
            where hd.mancc = n.mancc and nv.manv=hd.manv";
            dgDanhsach.DataSource = cn.taobang(sql);
        }
        public void LoadDanhSach(DateTime s, DateTime e)
        {
            string sql = @"select hd.Id,hd.Ngay, n.tenncc, nv.tennv,hd.nguoigiao,hd.sdt, hd.chungtu, hd.tongtien,
            (case hd.trangthai
            when 0 then N'Đang xử lý'
            when 1 then N'Đã thanh toán'
            end) as 'trangthai'
            from tbl_HoaDonNhap hd, tbl_NhaCungCap n, tbl_NhanVien nv
            where hd.mancc = n.mancc and nv.manv=hd.manv and hd.Ngay>= '" + s + "' and hd.Ngay<='" + e + "'";
            dgDanhsach.DataSource = cn.taobang(sql);
        }
        public void LoadChiTiet(string id, int n = 0)
        {
            string sql = "";
            if (n == 0)
                sql = @"select sp.Ma, sp.Ten,sp.dvt, sp.DONGIA, pn.SL, (pn.SL*sp.DONGIA) as 'thanhtien'
                from tbl_PhieuNhapChiTiet pn, tbl_HANG sp
                where sp.Ma = pn.HANG and pn.ID_Pn=N'" + id + "'";
            else
                sql = @"select sp.Ma, sp.Ten,sp.dvt, sp.DONGIA, pn.soluong as 'SL' , (pn.soluong*sp.DONGIA) as 'thanhtien'
                from tbl_ChiTietHoaDonNhap pn, tbl_HANG sp
                where sp.Ma = pn.masp and pn.ID_hd=N'" + id + "'";
            dgChiTiet.DataSource = cn.taobang(sql);
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
                    id_don = dgDanhsach.Rows[dong].Cells["id"].Value.ToString();
                    hd = f.GetHoaDonNhap(id_don);
                    if (hd!= null && string.IsNullOrEmpty(hd.chungtu))
                    {
                        LoadChiTiet(id_don, 1);
                    }
                    else
                        LoadChiTiet(hd.chungtu);
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (dpNgay.Value > dpHieuluc.Value)
            {
                MessageBox.Show("Ngày chọn không hợp lệ");
            }
            else
            {
                LoadDanhSach(dpNgay.Value, dpHieuluc.Value);
                LoadChiTiet("");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDanhSach();
            LoadChiTiet("");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var up = f.XoaHoaDonNhap(id_don);
            if (!up)
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                Reload();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var d = f.GetHoaDonNhap(id_don);
            using (frm_HoaDonNhap frm = new frm_HoaDonNhap(d))
            {
                frm.ShowDialog();
            }
            Reload();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frm_HoaDonNhap frm = new frm_HoaDonNhap())
            {
                frm.ShowDialog();
            }
            Reload();
        }
    }
}
