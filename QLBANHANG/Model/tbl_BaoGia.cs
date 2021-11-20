namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_BaoGia
    {
        [Key]
        [StringLength(50)]
        public string mabaogia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? hieuluc { get; set; }

        [Required]
        [StringLength(50)]
        public string manv { get; set; }

        [Required]
        [StringLength(50)]
        public string makh { get; set; }

        [StringLength(100)]
        public string ghichu { get; set; }
    }
}
