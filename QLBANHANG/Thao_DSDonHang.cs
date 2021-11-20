using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBANHANG
{
    public partial class Thao_DSDonHang : Form
    {
        ConnectDB cn = new ConnectDB();
        Function f = new Function();
        int dong = -1;
        string id_don;
        bool pick=false;
        public Thao_DSDonHang(bool pick=false)
        {
            InitializeComponent();
            this.pick = pick;
            if (pick)
            {
                gbChon.Visible = true;
                btnChon.Visible = true;              
            }
            LoadDanhSach();
        }
        public string Get_ID_Don()
        {
            return id_don;
        }
        public void LoadDanhSach()
        {
            string sql = @"SELECT tbl_PhieuBanHang.IDPHIEU, tbl_KhachHang.tenkh, tbl_PhieuBanHang.NGAYLAP,tbl_PhieuBanHang.NGAYGIAO, tbl_NhanVien.tennv, tbl_PhieuBanHang.TongTien,
                        ( case tbl_PhieuBanHang.TrangThai 
	                        when 0 then N'Đang xử lý' 
	                        when 1 then N'Đã thanh toán' 
	                        end) as 'TrangThai'
                        FROM         tbl_PhieuBanHang INNER JOIN
                      tbl_NhanVien ON tbl_PhieuBanHang.MANV = tbl_NhanVien.manv INNER JOIN
                      tbl_KhachHang ON tbl_PhieuBanHang.MAKH = tbl_KhachHang.makh";
            if(pick)
                sql = @"SELECT tbl_PhieuBanHang.IDPHIEU, tbl_KhachHang.tenkh, tbl_PhieuBanHang.NGAYLAP,tbl_PhieuBanHang.NGAYGIAO, tbl_NhanVien.tennv, tbl_PhieuBanHang.TongTien,
                        ( case tbl_PhieuBanHang.TrangThai 
	                        when 0 then N'Đang xử lý' 
	                        when 1 then N'Đã thanh toán' 
	                        end) as 'TrangThai'
                        FROM         tbl_PhieuBanHang INNER JOIN
                      tbl_NhanVien ON tbl_PhieuBanHang.MANV = tbl_NhanVien.manv INNER JOIN
                      tbl_KhachHang ON tbl_PhieuBanHang.MAKH = tbl_KhachHang.makh
                       where  tbl_PhieuBanHang.TrangThai = 0";
            dgDanhsach.DataSource = cn.taobang(sql);

        }
        public void LoadDanhSach(DateTime s, DateTime e)
        {
            string query = @"SELECT tbl_PhieuBanHang.IDPHIEU, tbl_KhachHang.tenkh, tbl_PhieuBanHang.NGAYLAP,tbl_PhieuBanHang.NGAYGIAO, tbl_NhanVien.tennv, tbl_PhieuBanHang.TongTien,
                        ( case tbl_PhieuBanHang.TrangThai 
	                        when 0 then N'Đang xử lý' 
	                        when 1 then N'Hoàn thành' 
	                        end) as 'TrangThai'
                        FROM tbl_PhieuBanHang INNER JOIN
                      tbl_NhanVien ON tbl_PhieuBanHang.MANV = tbl_NhanVien.manv INNER JOIN
                      tbl_KhachHang ON tbl_PhieuBanHang.MAKH = tbl_KhachHang.makh
                        where tbl_PhieuBanHang.NGAYLAP >= '" + s + "' and tbl_PhieuBanHang.NGAYGIAO <= '" + e + "'";
            if(pick)
                query = @"SELECT tbl_PhieuBanHang.IDPHIEU, tbl_KhachHang.tenkh, tbl_PhieuBanHang.NGAYLAP,tbl_PhieuBanHang.NGAYGIAO, tbl_NhanVien.tennv, tbl_PhieuBanHang.TongTien,
                        ( case tbl_PhieuBanHang.TrangThai 
	                        when 0 then N'Đang xử lý' 
	                        when 1 then N'Hoàn thành' 
	                        end) as 'TrangThai'
                        FROM tbl_PhieuBanHang INNER JOIN
                      tbl_NhanVien ON tbl_PhieuBanHang.MANV = tbl_NhanVien.manv INNER JOIN
                      tbl_KhachHang ON tbl_PhieuBanHang.MAKH = tbl_KhachHang.makh
                        where tbl_PhieuBanHang.TrangThai=0 and tbl_PhieuBanHang.NGAYLAP >= '" + s + "' and tbl_PhieuBanHang.NGAYGIAO <= '" + e + "'";
            dgDanhsach.DataSource = cn.taobang(query);
        }
        public void LoadChiTiet(string id)
        {
            string sql = @"SELECT  Ma,tbl_PhieuBanChiTiet.ID_PB, tbl_Hang.Ten, tbl_PhieuBanChiTiet.SL, tbl_PhieuBanChiTiet.DonGia, tbl_Hang.DVT, (SL*tbl_Hang.DONGIA) as 'ThanhTien'
            FROM tbl_PhieuBanChiTiet 
            INNER JOIN tbl_Hang ON tbl_PhieuBanChiTiet.HANG = tbl_Hang.Ma 
            where  tbl_PhieuBanChiTiet.ID_PB=N'" + id + "'";
             dgvChitiet.DataSource = cn.taobang(sql);

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
                    id_don = dgDanhsach.Rows[dong].Cells["IDPHIEU"].Value.ToString();
                    btnChon.Enabled = true;
                    LoadChiTiet(id_don);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var up = f.XoaPhieuBan(id_don);
            if (!up)
            {
                MessageBox.Show("Lỗi");
            }   
            else
            {
                btnChon.Enabled = false;
                LoadDanhSach();
                LoadChiTiet("");
            }    
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(dpNgay.Value>dpNgayGiao.Value)
            {
                MessageBox.Show("Ngày chọn không hợp lệ");
            }    
            else
            {
                LoadDanhSach(dpNgay.Value,dpNgayGiao.Value);
                LoadChiTiet(null);
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var phieu = f.GetPhieuBanHang(id_don);
                frm_DonHang frm = new frm_DonHang(phieu);
                this.Hide();
                frm.ShowDialog();             
                this.Show();
                LoadDanhSach();
                LoadChiTiet("");
            }
            catch(Exception ex)
            {
                throw ex;
            } 
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frm_DonHang frm = new frm_DonHang())
            {
                frm.ShowDialog();
            }
            LoadDanhSach();
            LoadChiTiet(null);
            this.Show();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
