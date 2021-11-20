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
    public partial class Thao_DSBaoGia : Form
    {
        int dong = -1;

        Function f = new Function();
        ConnectDB cn = new ConnectDB();
        string current_id = "";
        public Thao_DSBaoGia()
        {
            InitializeComponent();
            LoadDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Thao_frm_BaoGia frm = new Thao_frm_BaoGia();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Thao_frm_BaoGia frm = new Thao_frm_BaoGia(current_id);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
        public void LoadDanhSach()
        {
            var baogia = f.GetDanhSachBaoGia();
            string query = @"select b.mabaogia, b.makh,b.hieuluc,b.ngay, k.diachi from tbl_BaoGia b, tbl_KhachHang k where b.makh = k.makh";
            dgDanhsachbaogia.DataSource = cn.taobang(query);
        }
        public void LoadDanhSach(DateTime s, DateTime e)
        {
            string query = @"select b.mabaogia, b.makh,b.ngay,b.hieuluc, k.diachi from tbl_BaoGia b, tbl_KhachHang k 
            where b.makh = k.makh and b.ngay >= '"+s+"' and b.hieuluc <= '"+e+ "'";
            dgDanhsachbaogia.DataSource = cn.taobang(query);
        }
        public void LoadChiTiet()
        {
            string sql = @"select c.masp, s.ten,s.dvt, c.soluong,s.dongia , (c.soluong * s.dongia) as 'thanhtien'
            from tbl_chitietbaogia c, tbl_HANG s
            where c.masp=s.Ma and c.mabaogia='" + current_id + "'";
            dgChiTiet.DataSource = cn.taobang(sql);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            var start = dpNgay.Value;
            var end = dpHieuluc.Value;
            LoadDanhSach(start,end);
        }

        private void Select(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                if (dong > -1)
                {
                    btnChiTiet.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    current_id = dgDanhsachbaogia.Rows[dong].Cells["id"].Value.ToString();
                }
                else
                {
                    btnChiTiet.Enabled = false;
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
            var up = f.XoaBaoGia(current_id);
            if (!up)
                MessageBox.Show("Lỗi");
            LoadDanhSach();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            LoadChiTiet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
    }
}
