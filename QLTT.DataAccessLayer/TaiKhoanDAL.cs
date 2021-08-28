using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTT.DataAccessLayer.Enities;

namespace QLTT.DataAccessLayer
{
    public class TaiKhoanDAL
    {
        public bool KiemTraDangNhap(int userID, string password, out string error)
        {
            error = string.Empty;
            try
            {
                bool check = true;
                using (var dbcontext = new QLTTModel())
                {
                    check = dbcontext.NhanViens.Any(nv => nv.MaNV == userID && nv.MatKhau == password);
                }

                return check;
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }
        public NhanVien layTaiKhoan(int userID, string password, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    return dbcontext.NhanViens.Where(nv => nv.MaNV == userID && nv.MatKhau == password).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }

        }
    }
}
