using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTT.ThucThe
{
    public partial class QLTTModel : DbContext
    {
        public QLTTModel()
            : base("name=QLTTModel")
        {
        }

        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<LoaiThuoc> LoaiThuocs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Thuoc> Thuocs { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiThuoc>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.Thuoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaHD)
                .IsUnicode(false);
        }
    }
}
