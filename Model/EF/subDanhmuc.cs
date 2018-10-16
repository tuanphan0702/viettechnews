namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("subDanhmuc")]
    public partial class subDanhmuc
    {
        [Key]
        public int subID { get; set; }

        public int subCategoryId { get; set; }

        [Required]
        [StringLength(256)]
        public string subCategoryName { get; set; }

        public int? OrderNo { get; set; }

        public bool Status { get; set; }

        public virtual Danhmuc Danhmuc { get; set; }
    }
}
