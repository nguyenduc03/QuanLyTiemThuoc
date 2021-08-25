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
        public bool KiemTraDangNhap(string useremail, string password, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    return dbcontext.NhanViens.Any(nv => nv.Email == useremail && nv.MatKhau == password);
                }
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }


        public NhanVien layTaiKhoan(string useremail, string password, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new QLTTModel())
                {
                    return dbcontext.NhanViens.Where(nv => nv.Email == useremail && nv.MatKhau == password).FirstOrDefault();
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
