namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_PhieuBanHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PhieuBanHang()
        {
            tbl_PhieuBanChiTiet = new HashSet<tbl_PhieuBanChiTiet>();
        }

        [Key]
        [StringLength(50)]
        public string IDPHIEU { get; set; }

        [StringLength(50)]
        public string MAKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYLAP { get; set; }

        [StringLength(50)]
        public string MANV { get; set; }

        public double? TongTien { get; set; }

        public int? TrangThai { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYGIAO { get; set; }

        public virtual tbl_KhachHang tbl_KhachHang { get; set; }

        public virtual tbl_NhanVien tbl_NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PhieuBanChiTiet> tbl_PhieuBanChiTiet { get; set; }
    }
}
