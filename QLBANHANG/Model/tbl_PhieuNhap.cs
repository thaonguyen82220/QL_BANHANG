namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_PhieuNhap
    {
        [Key]
        [StringLength(50)]
        public string IDPN { get; set; }

        public double? TONGTIEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY { get; set; }

        public int? TrangThai { get; set; }

        [StringLength(50)]
        public string NguoiGiao { get; set; }

        [StringLength(20)]
        public string Sdt { get; set; }

        [StringLength(50)]
        public string MANCC { get; set; }

        [StringLength(50)]
        public string MANV { get; set; }
    }
}
