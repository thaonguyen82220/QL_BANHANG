namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_HoaDonNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_HoaDonNhap()
        {
            tbl_ChiTietHoaDonNhap = new HashSet<tbl_ChiTietHoaDonNhap>();
        }

        [StringLength(50)]
        public string Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngay { get; set; }

        [StringLength(50)]
        public string mancc { get; set; }

        [Required]
        [StringLength(50)]
        public string manv { get; set; }

        [StringLength(50)]
        public string chungtu { get; set; }

        [StringLength(50)]
        public string nguoigiao { get; set; }

        [StringLength(20)]
        public string sdt { get; set; }

        public double? tongtien { get; set; }

        public int trangthai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ChiTietHoaDonNhap> tbl_ChiTietHoaDonNhap { get; set; }
    }
}
