using QLTT.DataAccessLayer.Enities;
using QLTT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.DataAccessLayer
{
  public  class HoaDonDAL
    {

        public List<HoaDonDTO> LayDanhSachHD()
        {
            using (var dbcontext = new QLTTModel())
            {
                var hoaDonDTO = from b in dbcontext.HoaDons
                                select new HoaDonDTO()
                                {
                                    MaHoaDon = b.MaHD,
                                    NgayLap = (DateTime)b.NgayLap,
                                    TongTien = (int)b.TongTien,
                                    TenNhanVien = b.NhanVien.TenNV
                                };
                return hoaDonDTO.ToList();
            }

        }

        public bool KiemTraHoaDonByMaNhanVien(int maNV)
        {
            using (var dbcontext = new QLTTModel())
            {
                return dbcontext.HoaDons.Any(s => s.NhanVien.MaNV == maNV);
            }
        }

   

        public bool TaoMoiHoaDon(HoaDon hoaDon, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    dbcontext.HoaDons.Add(hoaDon);
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
        public bool xoaHD(HoaDon hd, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    var HDUpdate = dbcontext.HoaDons.Find(hd.MaHD);
              
                    if (HDUpdate == null)
                    {
                        error = "Không tìm thấy Hóa Đơn";
                        return false;
                    }
                    dbcontext.HoaDons.Remove(HDUpdate);
                
                    dbcontext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                return false;
            }
        }


        public bool CapNhatHD(HoaDon hd, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    var HDUpdate = dbcontext.HoaDons.Find(hd.MaHD);
                    if (HDUpdate == null)
                    {
                        error = "Không tìm thấy hóa đơn";
                        return false;
                    }
                    HDUpdate.NgayLap = hd.NgayLap;
                    HDUpdate.TongTien = hd.TongTien;
                    HDUpdate.MaNV = hd.MaNV;
                
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

