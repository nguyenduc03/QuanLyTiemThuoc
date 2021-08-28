using QLTT.DataAccessLayer.Enities;
using QLTT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.DataAccessLayer
{
    public class NhanVienDAL
    {

        public List<NhanVienDTO> LayDanhSachNV()
        {
            using (var dbcontext = new QLTTModel())
            {
                var nvDTO = from nv in dbcontext.NhanViens
                            select new NhanVienDTO()
                            {
                                MaNV = (int)nv.MaNV,
                                TenNV = nv.TenNV,
                                NgaySinh = (DateTime)nv.NgaySinh,
                                SDT = (int)nv.SDT,
                                Email = nv.Email,
                                MatKhau = nv.MatKhau,
                                Role = (bool)nv.Role
                            };
                return nvDTO.ToList();
            }
        }

        public bool timKiemNV(int maNV, string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    return dbcontext.NhanViens.Any(nv => nv.MaNV == maNV);
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool KiemTraHoaDonByMaNhanVien(int maNV)
        {
            using (var dbcontext = new QLTTModel())
            {
                return dbcontext.HoaDons.Any(s => s.NhanVien.MaNV == maNV);
            }
        }

        public bool xoaNV(NhanVien nv, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    var NVUpdate = dbcontext.NhanViens.Find(nv.MaNV);
                    if (NVUpdate == null)
                    {
                        error = "Không tìm thấy NV";
                        return false;
                    }
                    dbcontext.NhanViens.Remove(NVUpdate);
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


        public bool CapNhatNV(NhanVien nv, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    var NVUpdate = dbcontext.NhanViens.Find(nv.MaNV);
                    if (NVUpdate == null)
                    {
                        error = "Không tìm thấy nhân viên";
                        return false;
                    }
                    NVUpdate.TenNV = nv.TenNV;
                    NVUpdate.NgaySinh = nv.NgaySinh;
                    NVUpdate.SDT = nv.SDT;
                    NVUpdate.Email = nv.Email;
                    NVUpdate.MatKhau = nv.MatKhau;
                    NVUpdate.Role = nv.Role;
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

        public bool TaoMoiNV(NhanVien nv, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    dbcontext.NhanViens.Add(nv);
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

        public List<NhanVienDTO> layDSNVTimKiem(string name)
        {
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    var nvDTO = from nv in dbcontext.NhanViens where nv.TenNV.Contains(name) == true
                                select new NhanVienDTO()
                                {
                                    MaNV = (int)nv.MaNV,
                                    TenNV = nv.TenNV,
                                    NgaySinh = (DateTime)nv.NgaySinh,
                                    SDT = (int)nv.SDT,
                                    Email = nv.Email,
                                    MatKhau = nv.MatKhau,
                                    Role = (bool)nv.Role
                                };
                    return nvDTO.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }



        }
    }
}
