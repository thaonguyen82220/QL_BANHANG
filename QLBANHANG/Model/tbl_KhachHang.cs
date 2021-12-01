namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_KhachHang
    {
        [Key]
        [StringLength(50)]
        public string makh { get; set; }

        [StringLength(50)]
        public string tenkh { get; set; }

        public int? gioitinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(500)]
        public string diachi { get; set; }

        [StringLength(50)]
        public string sdt { get; set; }

        [StringLength(20)]
        public string stk { get; set; }
    }
}
