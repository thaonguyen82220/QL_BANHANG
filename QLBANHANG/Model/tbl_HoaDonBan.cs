namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_HoaDonBan
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngay { get; set; }

        [Required]
        [StringLength(50)]
        public string makh { get; set; }

        [Required]
        [StringLength(50)]
        public string manv { get; set; }

        [StringLength(50)]
        public string phuongthuc { get; set; }

        [StringLength(20)]
        public string stk { get; set; }

        [StringLength(50)]
        public string chungtu { get; set; }

        public double? tongtien { get; set; }

        public double? danhan { get; set; }

        public int trangthai { get; set; }

        [Required]
        [StringLength(50)]
        public string loai { get; set; }
    }
}
