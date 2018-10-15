namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("Tintuc")]
    public partial class Tintuc
    {
        [Key]
        public int BlogId { get; set; }

        [Required]
        [StringLength(512)]
        public string Title { get; set; }

        [Required]
        [StringLength(2000)]
        public string Brief { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        [AllowHtml]
        public string Content { get; set; }

        [StringLength(256)]
        public string Picture { get; set; }

        public DateTime? CreateDate { get; set; }

        public int CategoryId { get; set; }

        public int CategoryChildId { get; set; }

        [StringLength(128)]
        public string Tags { get; set; }

        public int? ViewNo { get; set; }

        public bool Status { get; set; }

        public int UserId { get; set; }

        [StringLength(250)]
        public string Seotitle { get; set; }
    }
}
