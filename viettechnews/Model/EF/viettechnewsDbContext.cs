namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class viettechnewsDbContext : DbContext
    {
        public viettechnewsDbContext()
            : base("name=viettechnewsDbContext")
        {
        }

        public virtual DbSet<Danhmuc> Danhmucs { get; set; }
        public virtual DbSet<Nguoidung> Nguoidungs { get; set; }
        public virtual DbSet<Tintuc> Tintucs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nguoidung>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Nguoidung>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Nguoidung>()
                .Property(e => e.Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<Tintuc>()
                .Property(e => e.Picture)
                .IsUnicode(false);
        }
    }
}
