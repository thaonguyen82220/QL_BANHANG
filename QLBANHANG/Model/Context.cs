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
        public virtual DbSet<tbl_ChiTietHoaDon> tbl_ChiTietHoaDon { get; set; }
        public virtual DbSet<tbl_DVT> tbl_DVT { get; set; }
        public virtual DbSet<tbl_HANG> tbl_HANG { get; set; }
        public virtual DbSet<tbl_HoaDon> tbl_HoaDon { get; set; }
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
            modelBuilder.Entity<tbl_DVT>()
                .HasMany(e => e.tbl_HANG)
                .WithOptional(e => e.tbl_DVT)
                .HasForeignKey(e => e.DVT)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tbl_HANG>()
                .HasMany(e => e.tbl_PhieuBanChiTiet)
                .WithRequired(e => e.tbl_HANG)
                .HasForeignKey(e => e.HANG);

            modelBuilder.Entity<tbl_HoaDon>()
                .HasMany(e => e.tbl_ChiTietHoaDon)
                .WithRequired(e => e.tbl_HoaDon)
                .HasForeignKey(e => e.Id_hd)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_KhachHang>()
                .HasMany(e => e.tbl_PhieuBanHang)
                .WithOptional(e => e.tbl_KhachHang)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tbl_Loai>()
                .HasMany(e => e.tbl_HANG)
                .WithOptional(e => e.tbl_Loai)
                .HasForeignKey(e => e.LOAI)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tbl_NhaCungCap>()
                .HasMany(e => e.tbl_PhieuNhap)
                .WithOptional(e => e.tbl_NhaCungCap)
                .HasForeignKey(e => e.NCC)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tbl_NhanVien>()
                .HasMany(e => e.tbl_PhieuBanHang)
                .WithOptional(e => e.tbl_NhanVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tbl_PhieuBanHang>()
                .HasMany(e => e.tbl_PhieuBanChiTiet)
                .WithRequired(e => e.tbl_PhieuBanHang)
                .HasForeignKey(e => e.ID_PB);

            modelBuilder.Entity<tbl_PhieuNhap>()
                .HasMany(e => e.tbl_PhieuNhapChiTiet)
                .WithRequired(e => e.tbl_PhieuNhap)
                .HasForeignKey(e => e.ID_PN);
        }
    }
}
