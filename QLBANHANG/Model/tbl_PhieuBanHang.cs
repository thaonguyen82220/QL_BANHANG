namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_PhieuBanHang
    {
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
    }
}
