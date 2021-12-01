namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_NhanVien
    {
        [Key]
        [StringLength(50)]
        public string manv { get; set; }

        [StringLength(50)]
        public string tennv { get; set; }

        [StringLength(500)]
        public string diachi { get; set; }

        [StringLength(11)]
        public string sdt { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }
    }
}
