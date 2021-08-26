using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.DTO
{
   public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public int SDT { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public bool Role { get; set; }

    }
}
