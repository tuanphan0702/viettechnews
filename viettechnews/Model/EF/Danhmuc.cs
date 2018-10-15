namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Danhmuc")]
    public partial class Danhmuc
    {
        [Key]
        public int CategoryId { get; set; }

        public int? ParentId { get; set; }

        public int? ChildId { get; set; }

        [Required]
        [StringLength(256)]
        public string CategoryName { get; set; }

        public int? OrderNo { get; set; }

        public bool Status { get; set; }

        public int UserId { get; set; }
    }
}
