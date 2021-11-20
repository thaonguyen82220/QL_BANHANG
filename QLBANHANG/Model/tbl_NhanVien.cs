namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_NhanVien()
        {
            tbl_nguoidung = new HashSet<tbl_nguoidung>();
            tbl_PhieuBanHang = new HashSet<tbl_PhieuBanHang>();
        }

        [Key]
        [StringLength(50)]
        public string manv { get; set; }

        [StringLength(50)]
        public string tennv { get; set; }

        [StringLength(500)]
        public string diachi { get; set; }

        [StringLength(11)]
        public string sdt { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_nguoidung> tbl_nguoidung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PhieuBanHang> tbl_PhieuBanHang { get; set; }
    }
}
