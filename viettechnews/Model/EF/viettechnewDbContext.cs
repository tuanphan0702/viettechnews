namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class viettechnewDbContext : DbContext
    {
        public viettechnewDbContext()
            : base("name=viettechnewDbContext")
        {
        }

        public virtual DbSet<Danhmuc> Danhmucs { get; set; }
        public virtual DbSet<Nguoidung> Nguoidungs { get; set; }
        public virtual DbSet<subDanhmuc> subDanhmucs { get; set; }
        public virtual DbSet<Tintuc> Tintucs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Danhmuc>()
                .HasMany(e => e.Tintucs)
                .WithRequired(e => e.Danhmuc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Danhmuc>()
                .HasMany(e => e.subDanhmucs)
                .WithRequired(e => e.Danhmuc)
                .HasForeignKey(e => e.subCategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nguoidung>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Nguoidung>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Nguoidung>()
                .Property(e => e.Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<Nguoidung>()
                .HasMany(e => e.Danhmucs)
                .WithRequired(e => e.Nguoidung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nguoidung>()
                .HasMany(e => e.Tintucs)
                .WithRequired(e => e.Nguoidung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tintuc>()
                .Property(e => e.Picture)
                .IsUnicode(false);
        }
    }
}
