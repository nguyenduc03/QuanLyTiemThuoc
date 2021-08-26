namespace QLTT.DataAccessLayer.Enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thuoc")]
    public partial class Thuoc
    {
        [Key]
        [StringLength(50)]
        public string MaThuoc { get; set; }

        [StringLength(50)]
        public string MaLoai { get; set; }

        [StringLength(50)]
        public string TenThuoc { get; set; }

        public int? DonGia { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public virtual CTHD CTHD { get; set; }

        public virtual LoaiThuoc LoaiThuoc { get; set; }
    }
}
