using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBANHANG.Model;

namespace QLBANHANG
{
    public partial class frm_ChiTietHoaDonBan : Form
    {
        Function f = new Function();
        public frm_ChiTietHoaDonBan()
        {
            InitializeComponent();
        }
        public frm_ChiTietHoaDonBan(tbl_HoaDonBan hd)
        {
            InitializeComponent();
            var khach = f.GetKhachHang(hd.makh);
            txtDiachi.Text = khach.diachi;
            txtNguoimua.Text = txtTenkach.Text = khach.tenkh;
            txtNgaysinh.Text = khach.ngaysinh.Value.ToString("yyyy/MM/dd");
            txtNhanvien.Text = f.GetNhanVien(hd.manv).tennv;
            txtPhuongthuc.Text = hd.phuongthuc;
            txtSdt.Text = khach.sdt;
            txtTongtien.Text = hd.tongtien.ToString();
            txtNguoiban.Text = f.GetNhanVien(hd.manv).tennv;
            theanh.Text = "";

            if (f.GetPhieuBanHang(hd.chungtu) == null)
            {
                var chitiet = f.ListCTHDB(hd.Id);
                foreach (var item in chitiet)
                {
                    var i = (tbl_ChiTietHoaDonBan)item;
                    var sp = f.GetSanPham(i.masp);
                    var ct = "Sản phẩm: " + i.masp + " x Số lượng: " + i.soluong + " --- Đơn giá: " + sp.DONGIA.ToString()+ '\n';
                    theanh.Text += ct;
                }
            }
            else
            {
                var chitiet = f.ListCTPB(hd.chungtu);
                foreach (var item in chitiet)
                {
                    var ct = "Sản phẩm: " + item.HANG + " x Số lượng: " + item.SL + " --- Đơn giá: " + item.DonGia + '\n';
                    theanh.Text += ct;
                }

            }    
            
            
            txtTenHoaDon.Text = "HÓA ĐƠN BÁN " + hd.Id;
        }
        /*private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }*/
        private void print_Click(object sender, EventArgs e)
        {
            PrintScreen();
            printPreviewDialog1.ShowDialog();
            this.btnPrint.Visible = true;
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        private void PrintScreen()
        {
            this.btnPrint.Visible = false;
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
