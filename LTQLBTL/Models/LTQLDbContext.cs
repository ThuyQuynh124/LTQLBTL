using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQLBTL.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        { }


        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONGs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<CTHOADON> CTHOADONs { get; set; }
        public virtual DbSet<PHIEUDANGKI> PHIEUDANGKIs { get; set; }
        public virtual DbSet<CTPHIEUDANGKI> CTPHIEUDANGKIs { get; set; }
    
    


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<NHANVIEN>()
              .Property(e => e.SoDT)
              .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
              .Property(e => e.TenNV)
              .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
              .Property(e => e.MaNV)
              .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
              .Property(e => e.DiaChi)
              .IsUnicode(false);

              
            modelBuilder.Entity<KHACHHANG>()
              .Property(e => e.MaKH)
              .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
             .Property(e => e.TenKH)
             .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
             .Property(e => e.NamSinh)
             .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
             .Property(e => e.DiaChi)
             .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
             .Property(e => e.MaKH)
             .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
             .Property(e => e.SoDienThoai)
             .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
             .Property(e => e.MaCV)
             .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
             .Property(e => e.TenCV)
             .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
             .Property(e => e.MaDV)
             .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
            .Property(e => e.TenDV)
            .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
            .Property(e => e.GiaDV);

            modelBuilder.Entity<DICHVU>()
            .Property(e => e.Luongton);

            modelBuilder.Entity<PHONG>()
             .Property(e => e.MaPhong)
             .IsUnicode(false);

            modelBuilder.Entity<LOAIPHONG>()
             .Property(e => e.MaLoai)
             .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
             .Property(e => e.MaHD)
             .IsUnicode(false);

            modelBuilder.Entity<CTHOADON>()
             .Property(e => e.MaCTHD)
             .IsUnicode(false);

            modelBuilder.Entity<PHIEUDANGKI>()
             .Property(e => e.MaPDK)
             .IsUnicode(false);

            modelBuilder.Entity<CTPHIEUDANGKI>()
            .Property(e => e.MaCTPDK)
            .IsUnicode(false);





        }

    }
}
