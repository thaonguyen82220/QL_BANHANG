namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_HANG
    {
        [Key]
        [StringLength(50)]
        public string Ma { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string DVT { get; set; }

        [StringLength(50)]
        public string LOAI { get; set; }

        public double DONGIANHAP { get; set; }

        public int Soluong { get; set; }

        public double DONGIABAN { get; set; }

        [StringLength(50)]
        public string Mausac { get; set; }

        [StringLength(50)]
        public string Mota { get; set; }

        public double Chietkhau { get; set; }

        public double Thue { get; set; }

        [StringLength(50)]
        public string Anh { get; set; }

        public int Trangthai { get; set; }
    }
}
