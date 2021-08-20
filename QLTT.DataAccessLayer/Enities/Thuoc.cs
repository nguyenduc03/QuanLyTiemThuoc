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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuoc()
        {
            CTHDs = new HashSet<CTHD>();
        }

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

        public virtual LoaiThuoc LoaiThuoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }
    }
}
