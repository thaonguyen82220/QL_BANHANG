using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLBANHANG.Model
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_BaoGia> tbl_BaoGia { get; set; }
        public virtual DbSet<tbl_ChiTietHoaDonBan> tbl_ChiTietHoaDonBan { get; set; }
        public virtual DbSet<tbl_ChiTietHoaDonNhap> tbl_ChiTietHoaDonNhap { get; set; }
        public virtual DbSet<tbl_DVT> tbl_DVT { get; set; }
        public virtual DbSet<tbl_HANG> tbl_HANG { get; set; }
        public virtual DbSet<tbl_HoaDonBan> tbl_HoaDonBan { get; set; }
        public virtual DbSet<tbl_HoaDonNhap> tbl_HoaDonNhap { get; set; }
        public virtual DbSet<tbl_KhachHang> tbl_KhachHang { get; set; }
        public virtual DbSet<tbl_Loai> tbl_Loai { get; set; }
        public virtual DbSet<tbl_nguoidung> tbl_nguoidung { get; set; }
        public virtual DbSet<tbl_NhaCungCap> tbl_NhaCungCap { get; set; }
        public virtual DbSet<tbl_NhanVien> tbl_NhanVien { get; set; }
        public virtual DbSet<tbl_PhieuBanChiTiet> tbl_PhieuBanChiTiet { get; set; }
        public virtual DbSet<tbl_PhieuBanHang> tbl_PhieuBanHang { get; set; }
        public virtual DbSet<tbl_PhieuNhap> tbl_PhieuNhap { get; set; }
        public virtual DbSet<tbl_PhieuNhapChiTiet> tbl_PhieuNhapChiTiet { get; set; }
        public virtual DbSet<tbl_ChiTietBaoGia> tbl_ChiTietBaoGia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
