namespace QLBANHANG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_DVT
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }
    }
}
