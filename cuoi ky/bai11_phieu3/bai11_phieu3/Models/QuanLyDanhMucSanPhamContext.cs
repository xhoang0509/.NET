using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace bai11_phieu3.Models
{
    public partial class QuanLyDanhMucSanPhamContext : DbContext
    {
        public QuanLyDanhMucSanPhamContext()
        {
        }

        public QuanLyDanhMucSanPhamContext(DbContextOptions<QuanLyDanhMucSanPhamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=XUANHOANG\\SQLEXPRESS;Initial Catalog=QuanLyDanhMucSanPham;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<LoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.MaLoaiSanPham)
                    .HasName("PK__LoaiSanP__ECCF699F03FB8800");

                entity.ToTable("LoaiSanPham");

                entity.Property(e => e.MaLoaiSanPham).ValueGeneratedNever();

                entity.Property(e => e.TenLoaiSanPham).HasMaxLength(255);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SanPham__FAC7442D3AF8C368");

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSanPham).ValueGeneratedNever();

                entity.Property(e => e.TenSanPham).HasMaxLength(255);

                entity.HasOne(d => d.MaLoaiSanPhamNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoaiSanPham)
                    .HasConstraintName("FK__SanPham__MaLoaiS__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
