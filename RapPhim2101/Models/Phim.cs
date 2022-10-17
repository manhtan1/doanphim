namespace RapPhim2101.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phim")]
    public partial class Phim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phim()
        {
            ChiTietPhongs = new HashSet<ChiTietPhong>();
        }

        [Key]
        public int MaPhim { get; set; }

        public int MaDP { get; set; }

        [StringLength(250)]
        public string TenPhim { get; set; }

        [StringLength(50)]
        public string QuocGia { get; set; }

        public int MaLP { get; set; }

        [Required]
        [StringLength(50)]
        public string traller { get; set; }

        [Required]
        [StringLength(50)]
        public string hinhtraller { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string MoTa { get; set; }

        [StringLength(10)]
        public string thoiluong { get; set; }

        public DateTime? ThoigianChieu { get; set; }

        public int? luotxem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhong> ChiTietPhongs { get; set; }

        public virtual DinhDangPhim DinhDangPhim { get; set; }

        public virtual TheLoaiPhim TheLoaiPhim { get; set; }
    }
}
