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
            error = string.Empty;
            try
            {
                //cập nhật
                if (chiTietHoaDon.MaHD > 0 && chiTietHoaDon.MaThuoc != "")
                {
                    if (!_chiTietHoaDonDAL.CapNhatCTHD(chiTietHoaDon, out error))
                    {
                        return false;
                    }
                }
                //tạo mới
                else
                {
                    if (!_chiTietHoaDonDAL.TaoMoiChiTietHoaDon(chiTietHoaDon, out error))
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }

        public bool xoaCTHD(CTHD chiTietHoaDon, out string error)
        {
            try
            {
                if (!_chiTietHoaDonDAL.xoaCTHD(chiTietHoaDon, out error))
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }

        public bool CapnhatTongTien(HoaDon HD, out string error)
        {
            try
            {
                if (!_chiTietHoaDonDAL.CapNhatTongTienHD(HD, out error))
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
    }
}
