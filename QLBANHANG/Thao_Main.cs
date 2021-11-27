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
    public partial class Thao_Main : Form
    {
        public Thao_Main()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            frm_DSDonHangNhap frm = new frm_DSDonHangNhap();
            frm.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            frm_DSDonHangBan frm = new frm_DSDonHangBan();
            frm.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            frm_DSHoaDonBan frm = new frm_DSHoaDonBan();
            frm.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            frm_DSBaoGia frm = new frm_DSBaoGia();
            frm.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            frm_DSBaoGia frm = new frm_DSBaoGia();
            frm.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            frm_DSHoaDonNhap frm = new frm_DSHoaDonNhap();
            frm.ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            frm_DSThongKe frm = new frm_DSThongKe();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Thao_frm_NhapKho frm = new Thao_frm_NhapKho();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thao_frm_XuatKho frm = new Thao_frm_XuatKho();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thao_ThongKeDonHang frm = new Thao_ThongKeDonHang();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_NhaCungCap frm = new frm_NhaCungCap();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Loai frm = new frm_Loai();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frm_DVT frm = new frm_DVT();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Thao_frm_TKDoanhThu frm = new Thao_frm_TKDoanhThu();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_QuanLyNguoiDung frm = new frm_QuanLyNguoiDung();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_SaoLuu frm = new frm_SaoLuu();
            frm.ShowDialog();
        }
    }
}
