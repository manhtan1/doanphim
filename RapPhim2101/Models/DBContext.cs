using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RapPhim2101.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<ChiTietHD> ChiTietHDs { get; set; }
        public virtual DbSet<ChiTietPhong> ChiTietPhongs { get; set; }
        public virtual DbSet<CT_CMT> CT_CMT { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<DinhDangPhim> DinhDangPhims { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiVe> LoaiVes { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phim> Phims { get; set; }
        public virtual DbSet<PhongChieu> PhongChieux { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TheLoaiPhim> TheLoaiPhims { get; set; }
        public virtual DbSet<UuDai> UuDais { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietPhong>()
                .HasMany(e => e.Ves)
                .WithRequired(e => e.ChiTietPhong)
                .HasForeignKey(e => new { e.MaPhong, e.MaPhim })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.ChiTietHDs)
                .WithRequired(e => e.DichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DinhDangPhim>()
                .HasMany(e => e.Phims)
                .WithRequired(e => e.DinhDangPhim)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hoadon>()
                .Property(e => e.TongTien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoadon>()
                .HasMany(e => e.ChiTietHDs)
                .WithRequired(e => e.Hoadon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDTKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.CT_CMT)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.Hoadons)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.Phims)
                .WithMany(e => e.KhachHangs)
                .Map(m => m.ToTable("Phim_Theo_Doi").MapLeftKey("MaKH").MapRightKey("MaPhim"));

            modelBuilder.Entity<LoaiVe>()
                .HasMany(e => e.Ves)
                .WithRequired(e => e.LoaiVe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.Hoadons)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phim>()
                .HasMany(e => e.ChiTietPhongs)
                .WithRequired(e => e.Phim)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phim>()
                .HasMany(e => e.CT_CMT)
                .WithRequired(e => e.Phim)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhongChieu>()
                .HasMany(e => e.ChiTietPhongs)
                .WithRequired(e => e.PhongChieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TheLoaiPhim>()
                .HasMany(e => e.Phims)
                .WithRequired(e => e.TheLoaiPhim)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UuDai>()
                .HasMany(e => e.ChiTietHDs)
                .WithRequired(e => e.UuDai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ve>()
                .HasMany(e => e.ChiTietHDs)
                .WithRequired(e => e.Ve)
                .WillCascadeOnDelete(false);
        }
    }
}
