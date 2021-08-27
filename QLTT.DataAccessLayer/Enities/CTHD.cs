namespace QLTT.DataAccessLayer.Enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHD")]
    public partial class CTHD
    {
        public int Id { get; set; }

        public int MaHD { get; set; }

        [Required]
        [StringLength(50)]
        public string MaThuoc { get; set; }

        public int? SoLuongMua { get; set; }

        public int? DonGia { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual Thuoc Thuoc { get; set; }
    }
}
