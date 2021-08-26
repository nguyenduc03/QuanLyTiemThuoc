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
   public class ChiTietHoaDonBAL
    {
        private readonly ChiTietHoaDonDAL _chiTietHoaDonDAL;

        public ChiTietHoaDonBAL()
        {
            _chiTietHoaDonDAL = new ChiTietHoaDonDAL();
        }

        public List<CTHD> GetChiTietHoaDons()
        {
            return _chiTietHoaDonDAL.GetChiTietHoaDons();
        }


        public List<ChiTietHoaDonDTO> GetChiTietHoaDonsByMaHoaDon(int maHoaDon)
        {
            return _chiTietHoaDonDAL.GetChiTietHoaDonsByMaHoaDon(maHoaDon);
        }

        public bool LuuChiTietHoaDon(CTHD chiTietHoaDon, out string error)
        {
            return _chiTietHoaDonDAL.TaoMoiChiTietHoaDon(chiTietHoaDon, out error);
        }
    }
}
