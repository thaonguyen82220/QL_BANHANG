namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_NhaCungCap
    {
        [Key]
        [StringLength(50)]
        public string mancc { get; set; }

        [StringLength(50)]
        public string TENNCC { get; set; }

        [StringLength(500)]
        public string DIACHI { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }
    }
}
