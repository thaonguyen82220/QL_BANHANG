using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBANHANG
{
    public partial class Thao_frm_TKDoanhThu : Form
    {
        int flag = 0;
        bool ncc = false, kh = false, nv=false;
        string query ;

        ConnectDB cn = new ConnectDB();
        private void TinhTongSoDonHang(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TinhTong();

        }
        private void TinhTong()
        {
            if (dgDanhSach.Rows.Count > 0)
            {
                txtSoChungTu.Text = dgDanhSach.Rows.Count.ToString();
                double thu = 0;
                double chi = 0;
                foreach (DataGridViewRow item in dgDanhSach.Rows)
                {
                    if (item.Cells["loai"].Value.ToString() == "Thu")
                    {
                        thu = thu + (double)item.Cells["tongtien"].Value;
                    }
                    else
                    {
                        chi = chi + (double)item.Cells["tongtien"].Value;
                    }
                }
                txtTongChi.Text = chi.ToString();
                txtTongThu.Text = thu.ToString();
                txtDoanhThu.Text = (thu - chi).ToString();
            }

        }
        public void LoadCombobox()
        {
            cn.LoadCombobox(cbNhanvien,"select * from tbl_NhanVien","tennv","manv");
            cn.LoadCombobox(cbKhachhang, "select * from tbl_khachhang", "tenkh", "makh");
            cn.LoadCombobox(cbNcc, "select * from tbl_Nhacungcap", "tenncc", "mancc");
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public void LoadDanhSach(string sql)
        {        
            if (string.IsNullOrEmpty(sql))
            {
                query = @"select ngay,id, nv.tennv, chungtu,loai,tongtien 
            from tbl_Hoadonnhap, tbl_nhanvien nv
            where tbl_HoaDonNhap.manv = nv.manv and tbl_HoaDonNhap.TrangThai=1
            union
            select ngay,id, nv.tennv, chungtu,loai,tongtien 
            from tbl_Hoadonban, tbl_nhanvien nv
            where tbl_HoaDonBan.manv = nv.manv and tbl_HoaDonBan.trangthai =1";
            }
            dgDanhSach.DataSource = cn.taobang(query);
        }
        public Thao_frm_TKDoanhThu()
        {
            InitializeComponent();
            LoadCombobox();
            LoadDanhSach("");
            TinhTong();
        }
        private void GetThoiGian(object sender, EventArgs e)
        {
            if (cbTG.Checked)
            {
                dpEnd.Enabled = true;
                dpStart.Enabled = true;
            }
            else
            {
                dpEnd.Enabled = false;
                dpStart.Enabled = false;
            }
        }       
        private void CheckThoiGian(object sender, EventArgs e)
        {
            if (dpStart.Value > dpEnd.Value)
            {
                MessageBox.Show("Ngày chọn không đúng");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!cbTG.Checked)
            {
                query = @"select ngay,id, nv.tennv, chungtu,loai,tongtien 
            from tbl_Hoadonnhap, tbl_nhanvien nv
            where tbl_HoaDonNhap.manv = nv.manv and tbl_HoaDonNhap.TrangThai=1
            union
            select ngay,id, nv.tennv, chungtu,loai,tongtien 
            from tbl_Hoadonban, tbl_nhanvien nv
            where tbl_HoaDonBan.manv = nv.manv and tbl_HoaDonBan.trangthai =1";
            }
            
            if (cbTG.Checked && ncc==false && nv==false && kh == false)
            {                
                query = @"select ngay,id, nv.tennv, chungtu,loai,tongtien 
                        from tbl_Hoadonnhap, tbl_nhanvien nv
                        where tbl_HoaDonNhap.manv = nv.manv and tbl_HoaDonNhap.TrangThai = 1 and ngay >= '"+dpStart.Value+@"' and ngay<= '"+dpEnd.Value+@"'
                        union
                        select ngay,id, nv.tennv, chungtu,loai,tongtien
                        from tbl_Hoadonban, tbl_nhanvien nv
                        where tbl_HoaDonBan.manv = nv.manv and tbl_HoaDonBan.trangthai = 1 and ngay>='"+dpStart.Value+"' and ngay<= '"+dpEnd.Value+"'";
            }
            else
            if (nv)
            {
                if (cbTG.Checked)
                {
                    query = @"select ngay,id, nv.tennv, chungtu,loai,tongtien
                        from tbl_Hoadonnhap, tbl_nhanvien nv
                        where tbl_Hoadonnhap.manv = nv.manv 
                        and tbl_Hoadonnhap.trangthai = 1 
                        and ngay>='" + dpStart.Value + "' and ngay<= '" + dpEnd.Value + "' and tbl_Hoadonnhap.manv='" + cbNhanvien.SelectedValue.ToString() + "'";
                }
                else
                {
                    query = @"select ngay,id, nv.tennv, chungtu,loai,tongtien
                        from tbl_Hoadonnhap, tbl_nhanvien nv
                        where tbl_Hoadonnhap.manv = nv.manv 
                        and tbl_Hoadonnhap.trangthai = 1 and tbl_Hoadonnhap.manv='" + cbNhanvien.SelectedValue.ToString() + "'";
                }
            }


            if (kh)
            {
                if (cbTG.Checked && nv)
                {
                    query = @"select ngay,id,nv.tennv, kh.tenkh as N'Khách hàng', chungtu,loai,tongtien
                        from tbl_Hoadonban, tbl_khachhang kh, tbl_nhanvien nv
                        where tbl_HoaDonBan.manv = nv.manv and tbl_Hoadonban.makh = kh.makh
                        and tbl_HoaDonBan.trangthai = 1 and tbl_Hoadonban.manv = '"+cbNhanvien.SelectedValue.ToString()+@"'
                        and ngay>='" + dpStart.Value + "' and ngay<= '" + dpEnd.Value + "' and tbl_HoaDonBan.makh='"+cbKhachhang.SelectedValue.ToString()+"'";
                }
                else
                if(!cbTG.Checked && nv)
                {
                    query = @"select ngay,id,nv.tennv, kh.tenkh as N'Khách hàng', chungtu,loai,tongtien
                        from tbl_Hoadonban, tbl_khachhang kh, tbl_nhanvien nv
                        where tbl_HoaDonBan.manv = nv.manv and tbl_Hoadonban.makh = kh.makh
                        and tbl_HoaDonBan.trangthai = 1 
                        and ngay>='" + dpStart.Value + "' and ngay<= '" + dpEnd.Value + "' and tbl_HoaDonBan.makh='" + cbKhachhang.SelectedValue.ToString() + "'";
                }   
                else
                if(!cbTG.Checked && !nv)
                {
                    query = @"select ngay,id,nv.tennv, kh.tenkh as N'Khách hàng', chungtu,loai,tongtien
                        from tbl_Hoadonban, tbl_khachhang kh, tbl_nhanvien nv
                        where tbl_HoaDonBan.manv = nv.manv and tbl_Hoadonban.makh = kh.makh
                        and tbl_HoaDonBan.trangthai = 1 and tbl_HoaDonBan.makh='" + cbKhachhang.SelectedValue.ToString() + "'";
                }
            }
            else
            if(ncc)
            {
                if (cbTG.Checked && nv)
                {
                    query = @"select ngay,id,nv.tennv, nc.tenncc as N'Nhà cung cấp', chungtu,loai,tongtien
                        from tbl_Hoadonnhap, tbl_nhacungcap nc, tbl_nhanvien nv
                        where tbl_Hoadonnhap.manv = nv.manv and tbl_Hoadonnhap.mancc = nc.mancc
                        and tbl_Hoadonnhap.trangthai = 1 and tbl_Hoadonnhap.manv = '" + cbNhanvien.SelectedValue.ToString() + @"'
                        and ngay>='" + dpStart.Value + "' and ngay<= '" + dpEnd.Value + "' and tbl_Hoadonnhap.mancc='" + cbNcc.SelectedValue.ToString() + "'";
                }
                else
               if (!cbTG.Checked && nv)
                {
                    query = @"select ngay,id,nv.tennv, nc.tenncc as N'Nhà cung cấp', chungtu,loai,tongtien
                        from tbl_Hoadonnhap, tbl_nhacungcap nc, tbl_nhanvien nv
                        where tbl_Hoadonnhap.manv = nv.manv and tbl_Hoadonnhap.mancc = nc.mancc
                        and ngay>='" + dpStart.Value + "' and ngay<= '" + dpEnd.Value + "' and tbl_Hoadonnhap.mancc='" + cbNcc.SelectedValue.ToString() + "'";
                }
                else
               if (!cbTG.Checked && !nv)
                {
                    query = @"select ngay,id,nv.tennv, nc.tenncc as N'Nhà cung cấp', chungtu,loai,tongtien
                        from tbl_Hoadonnhap, tbl_nhacungcap nc, tbl_nhanvien nv
                        where tbl_Hoadonnhap.manv = nv.manv and tbl_Hoadonnhap.mancc = nc.mancc
                        and tbl_Hoadonnhap.trangthai = 1 and tbl_Hoadonnhap.mancc='" + cbNcc.SelectedValue.ToString() + "'";
                }
            }

            

            LoadDanhSach(query);
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            nv = true;
            cbNhanvien.Enabled = true;
            btnPickNhanVien.Enabled = true;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            LoadDanhSach("");
            TinhTong();
        }

        private void btnNcc_Click(object sender, EventArgs e)
        {
            ncc = true;
            cbNcc.Enabled = true;
            btnPickNcc.Enabled = true;
            kh = false;
            cbKhachhang.Enabled = false;
            btnPickKH.Enabled = false;
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            ncc = false;         
            cbNcc.Enabled = false;
            btnPickNcc.Enabled = false;
            kh = true;
            cbKhachhang.Enabled = true;
            btnPickKH.Enabled = true;
        }
    }
}
