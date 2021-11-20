namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_ChiTietHoaDon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Id_hd { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string masp { get; set; }

        public int? soluong { get; set; }

        public virtual tbl_HoaDon tbl_HoaDon { get; set; }
    }
}
