namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_KhachHang()
        {
            tbl_PhieuBanHang = new HashSet<tbl_PhieuBanHang>();
        }

        [Key]
        [StringLength(50)]
        public string makh { get; set; }

        [StringLength(50)]
        public string tenkh { get; set; }

        [StringLength(500)]
        public string diachi { get; set; }

        [StringLength(50)]
        public string sdt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(20)]
        public string stk { get; set; }

        public int? gioitinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PhieuBanHang> tbl_PhieuBanHang { get; set; }
    }
}
