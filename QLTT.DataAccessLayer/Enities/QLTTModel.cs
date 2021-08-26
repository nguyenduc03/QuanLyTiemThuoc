using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTT.DataAccessLayer.Enities
{
    public partial class QLTTModel : DbContext
    {
        public QLTTModel()
            : base("name=QLTTModel1")
        {
        }


        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<LoaiThuoc> LoaiThuocs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Thuoc> Thuocs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiThuoc>()
                .Property(e => e.MaLoai)
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
                .HasOptional(e => e.CTHD)
                .WithRequired(e => e.Thuoc);
        }
    }
}
