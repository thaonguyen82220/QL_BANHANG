using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QLBANHANG
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        public string quyen { get; set; }
        private void buttonItem2_Click(object sender, EventArgs e)
        {
            frm_QuanLyNguoiDung frm = new frm_QuanLyNguoiDung();
            frm.ShowDialog();
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            frm_NhanVien frm = new frm_NhanVien();
            frm.ShowDialog();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát? ", "Thoát", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btthe_Click(object sender, EventArgs e)
        {
            frm_Hang frm = new frm_Hang();
            frm.ShowDialog();
        }

        private void btphong_Click(object sender, EventArgs e)
        {
            frm_KhachHang frm = new frm_KhachHang();
            frm.ShowDialog();
        }

        private void btnv_Click(object sender, EventArgs e)
        {
            frm_NhaCungCap frm = new frm_NhaCungCap();
            frm.ShowDialog();
        }

        private void btdv_Click(object sender, EventArgs e)
        {
            frm_Loai frm = new frm_Loai();
            frm.ShowDialog();
        }

        private void btkh_Click(object sender, EventArgs e)
        {
            frm_DVT frm = new frm_DVT();
            frm.ShowDialog();
        }

        private void btdot_Click(object sender, EventArgs e)
        {
            frm_PhieuNhapHang frm = new frm_PhieuNhapHang();
            frm.ShowDialog();
        }

        private void btlich_Click(object sender, EventArgs e)
        {
            Thao_DSDonHang frm = new Thao_DSDonHang();
            frm.ShowDialog();
        }

        private void ButtonItem1_Click(object sender, EventArgs e)
        {
            frm_ThongKePhieuNhap frm = new frm_ThongKePhieuNhap();
            frm.ShowDialog();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            frm_ThongKePhieuXuat frm = new frm_ThongKePhieuXuat();
            frm.ShowDialog();
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            frm_ThongKeKhachHang frm = new frm_ThongKeKhachHang();
            frm.ShowDialog();
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            frm_ThongKeTheTon frm = new frm_ThongKeTheTon();
            frm.ShowDialog();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            if (quyen != "ADMIN")
            {
                buttonItem2.Visible = false;
                buttonItem4.Visible = false;
            }
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            frm_DangNhap frm = new frm_DangNhap();
            frm.Show();
            this.Hide();
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            frm_SaoLuu frm = new frm_SaoLuu();
            frm.ShowDialog();
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            frm_PhucHoi frm = new frm_PhucHoi();
            frm.ShowDialog();
        }

        private void ribbonTabItem3_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            frm_HoTro frm = new frm_HoTro();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tabControl1_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            if (tabControl1.SelectedTab != null)
                tabControl1.Tabs.Remove(tabControl1.SelectedTab);
        }

        private void RibbonControl1_Click(object sender, EventArgs e)
        {
        }

        private void btnThongKeDS_Click(object sender, EventArgs e)
        {
            frm_DSThongKe frm = new frm_DSThongKe();
            frm.ShowDialog();
        }
    }
}