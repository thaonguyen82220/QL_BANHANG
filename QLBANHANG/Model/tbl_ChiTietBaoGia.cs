namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_ChiTietBaoGia
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string mabaogia { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string masp { get; set; }

        public int? soluong { get; set; }

        public double? dongia { get; set; }

        public double? thanhtien { get; set; }
    }
}
