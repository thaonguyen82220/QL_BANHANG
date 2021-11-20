namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_nguoidung
    {
        [Required]
        [StringLength(50)]
        public string MANV { get; set; }

        [Key]
        [StringLength(50)]
        public string TENDANGNHAP { get; set; }

        [StringLength(50)]
        public string MATKHAU { get; set; }

        [StringLength(50)]
        public string PHANQUYEN { get; set; }

        public virtual tbl_NhanVien tbl_NhanVien { get; set; }
    }
}
