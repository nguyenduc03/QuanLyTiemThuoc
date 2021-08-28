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
   public class NhanVienBAL
    {
        private readonly NhanVienDAL _nhanvienDAL;

        public NhanVienBAL()
        {
            _nhanvienDAL = new NhanVienDAL();
        }

        public List<NhanVienDTO> LayDanhSachNV()
        {
            return _nhanvienDAL.LayDanhSachNV();
        }

        public bool timKiemNV(int maNV, string error)
        {
            return _nhanvienDAL.timKiemNV(maNV, error);
        }

        public bool xoaNV(NhanVien nv, out string error)
        {
            try
            {
                if (!_nhanvienDAL.xoaNV(nv, out error))
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

        public bool checkNull()
        {

            return true;
        }

        public bool LuuNhanVien(NhanVien nv, out string error)
        {
            error = string.Empty;    
            try
            {
                //cập nhật
                if (nv.MaNV >0)
                {
                    if (!_nhanvienDAL.CapNhatNV(nv, out error))
                    {
                        return false;
                    }
                    
                }
                //tạo mới
                else
                {
                    if (!_nhanvienDAL.TaoMoiNV(nv, out error))
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
        public List<NhanVienDTO> layDSNVTimKiem(string name)
        {
            return _nhanvienDAL.layDSNVTimKiem(name);
        }
    }
}
