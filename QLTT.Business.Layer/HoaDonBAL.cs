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
            error = string.Empty;
            try
            {
                //cập nhật
                if (hoaDon.MaHD > 0)
                {
                    if (!_hoaDonDAL.CapNhatHD(hoaDon, out error))
                    {
                        return false;
                    }
                }
                //tạo mới
                else
                {
                    if (!_hoaDonDAL.TaoMoiHoaDon(hoaDon, out error))
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

        public bool xoaHD(HoaDon hoaDon, out string error)
        {
            try
            {
                if (!_hoaDonDAL.xoaHD(hoaDon, out error))
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

        public bool KiemTraHoaDonByMaNhanVien(int maNV)
        {
            return _hoaDonDAL.KiemTraHoaDonByMaNhanVien(maNV);
        }
    }
}
