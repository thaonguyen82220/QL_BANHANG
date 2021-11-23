namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_HANG()
        {
            tbl_ChiTietHoaDonBan = new HashSet<tbl_ChiTietHoaDonBan>();
            tbl_ChiTietHoaDonNhap = new HashSet<tbl_ChiTietHoaDonNhap>();
            tbl_PhieuBanChiTiet = new HashSet<tbl_PhieuBanChiTiet>();
            tbl_PhieuNhapChiTiet = new HashSet<tbl_PhieuNhapChiTiet>();
        }

        [Key]
        [StringLength(50)]
        public string Ma { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string DVT { get; set; }

        [StringLength(50)]
        public string LOAI { get; set; }

        public double? DONGIA { get; set; }

        public int? Soluong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ChiTietHoaDonBan> tbl_ChiTietHoaDonBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ChiTietHoaDonNhap> tbl_ChiTietHoaDonNhap { get; set; }

        public virtual tbl_DVT tbl_DVT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PhieuBanChiTiet> tbl_PhieuBanChiTiet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PhieuNhapChiTiet> tbl_PhieuNhapChiTiet { get; set; }

        public virtual tbl_Loai tbl_Loai { get; set; }
    }
}
