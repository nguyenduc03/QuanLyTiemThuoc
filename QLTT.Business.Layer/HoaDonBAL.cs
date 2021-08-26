using QLTT.DataAccessLayer;
using QLTT.DataAccessLayer.Enities;
using QLTT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.BusinessAccessLayer
{
    public class HoaDonBAL
    {
        private readonly HoaDonDAL _hoaDonDAL;
        public HoaDonBAL()
        {
            _hoaDonDAL = new HoaDonDAL();
        }

        public List<HoaDonDTO> LayDanhSachHD()
        {
            return _hoaDonDAL.LayDanhSachHD();
        }
        public bool LuuHoaDon(HoaDon hoaDon, out string error)
        {
            return _hoaDonDAL.TaoMoiHoaDon(hoaDon, out error);
        }

        public bool KiemTraHoaDonByMaNhanVien(int maNV)
        {
            return _hoaDonDAL.KiemTraHoaDonByMaNhanVien(maNV);
        }
    }
}
