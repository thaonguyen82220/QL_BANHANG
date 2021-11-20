namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_PhieuNhapChiTiet
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ID_PN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string HANG { get; set; }

        public int? SL { get; set; }

        public double? DonGia { get; set; }

        public virtual tbl_PhieuNhap tbl_PhieuNhap { get; set; }
    }
}
