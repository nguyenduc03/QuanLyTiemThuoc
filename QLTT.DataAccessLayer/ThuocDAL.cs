using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTT.DTO;
using QLTT.DataAccessLayer.Enities;

namespace QLTT.DataAccessLayer
{
    public class ThuocDAL
    {
        public List<ThuocDTO> LayDanhSachThuoc()
        {
            using (var dbcontext = new QLTTModel())
            {   
                var thuocDTO = from thuoc in dbcontext.Thuocs
                               select new ThuocDTO()
                               {
                                   MaThuoc = thuoc.MaThuoc,
                                   TenThuoc = thuoc.TenThuoc,
                                   DonGia = (int)thuoc.DonGia,
                                   SoLuong = (int)thuoc.SoLuong,
                                   MoTa = thuoc.MoTa,
                                };
                return thuocDTO.ToList();
            }
        }

        public bool timKiemThuoc(string maThuoc, string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    return dbcontext.Thuocs.Any(thuoc => thuoc.MaThuoc == maThuoc);
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public string xoaThuoc(string maThuoc, string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    Thuoc temp = dbcontext.Thuocs.Where
                        (thuoc => thuoc.MaThuoc == maThuoc).FirstOrDefault();
                    dbcontext.Thuocs.Remove(temp);
                    dbcontext.SaveChanges();
                    return "xoá thành công";
                }
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                return "Lỗi! Xoá thất bại! " + error;
            }
        }

        public string capNhatThuoc(Thuoc newThuoc, string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    Thuoc temp = dbcontext.Thuocs.Where
                        (thuoc => thuoc.MaThuoc == newThuoc.MaThuoc).FirstOrDefault();
                    if (temp == null)
                    {
                        dbcontext.Thuocs.Add(newThuoc);
                        dbcontext.SaveChanges();
                        return "Thêm thành công";
                    }

                    temp.DonGia = newThuoc.DonGia;
                    temp.MoTa = newThuoc.MoTa;
                    temp.TenThuoc = newThuoc.TenThuoc;
                    temp.SoLuong = newThuoc.SoLuong;
                    dbcontext.SaveChanges();
                    return "cập nhật thành công";
                }
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                return "Lỗi! Cập nhật thất bại! " + error;
            }
        }
    }
}
