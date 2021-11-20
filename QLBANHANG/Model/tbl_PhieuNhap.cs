namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_PhieuNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PhieuNhap()
        {
            tbl_PhieuNhapChiTiet = new HashSet<tbl_PhieuNhapChiTiet>();
        }

        [Key]
        [StringLength(50)]
        public string IDPN { get; set; }

        [StringLength(50)]
        public string NCC { get; set; }

        public double? TONGTIEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY { get; set; }

        public int? TrangThai { get; set; }

        [StringLength(50)]
        public string NguoiGiao { get; set; }

        [StringLength(20)]
        public string Sdt { get; set; }

        public virtual tbl_NhaCungCap tbl_NhaCungCap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PhieuNhapChiTiet> tbl_PhieuNhapChiTiet { get; set; }
    }
}
