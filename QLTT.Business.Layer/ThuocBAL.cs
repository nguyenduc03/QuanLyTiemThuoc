using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTT.DataAccessLayer.Enities;
using QLTT.DataAccessLayer;
using QLTT.DTO;

namespace QLTT.BusinessAccessLayer
{
    public class ThuocBAL
    {
        private readonly ThuocDAL _thuocDAL;

        public ThuocBAL()
        {
            _thuocDAL = new ThuocDAL();
        }

        public List<ThuocDTO> LayDanhSachThuoc()
        {
            return _thuocDAL.LayDanhSachThuoc();
        }

        public bool timKiemThuoc(string maThuoc, string error)
        {
            return _thuocDAL.timKiemThuoc(maThuoc, error);
        }

        public string xoaThuoc(string maThuoc, string error)
        {
            return _thuocDAL.xoaThuoc(maThuoc, error);
        }

        public string capNhatThuoc(Thuoc thuocMoi, string error)
        {
            return _thuocDAL.capNhatThuoc(thuocMoi, error);
        }
    }
}
