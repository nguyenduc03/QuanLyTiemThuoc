using QLTT.DataAccessLayer.Enities;
using QLTT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.DataAccessLayer
{
   public class ChiTietHoaDonDAL
    {
 
        public List<ChiTietHoaDonDTO> GetChiTietHoaDonsByMaHoaDon(int maHoaDon)
        {
            using (var dbcontext = new QLTTModel())
            {
                var chiTietHoaDonDTO = from b in dbcontext.CTHDs
                                       where b.MaHD == maHoaDon
                                       select new ChiTietHoaDonDTO()
                                       {
                                           MaHoaDon = b.MaHD,
                                           TenThuoc = b.Thuoc.TenThuoc,
                                           SoLuongMua =(int) b.SoLuongMua,
                                           GiaTien = (int)b.GiaTien
                                       };
                return chiTietHoaDonDTO.ToList();
            }
        }

        public List<CTHD> GetChiTietHoaDons()
        {
            using (var dbcontext = new QLTTModel())
            {
                return dbcontext.CTHDs.ToList();
            }
        }

        public bool TaoMoiChiTietHoaDon(CTHD chiTietHoaDon, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    dbcontext.CTHDs.Add(chiTietHoaDon);
                    dbcontext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
