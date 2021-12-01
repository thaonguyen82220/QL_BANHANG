namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Loai
    {
        [Key]
        [StringLength(50)]
        public string Ma { get; set; }

        [StringLength(50)]
        public string TenLoai { get; set; }
    }
}
