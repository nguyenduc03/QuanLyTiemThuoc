namespace QLTT.ThucThe
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHD")]
    public partial class CTHD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaThuoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaHD { get; set; }

        public int? SoLuongMua { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual Thuoc Thuoc { get; set; }
    }
}
