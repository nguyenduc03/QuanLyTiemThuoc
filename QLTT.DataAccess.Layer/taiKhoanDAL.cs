using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTT.DataAccess.Layer.Enities;

namespace QLTT.DataAccessLayer
{
    public class taiKhoanDAL
    {
        public bool KiemTraDangNhap(string useremail, string password, out string error)
        {
            error = string.Empty;
            try
            {
                bool check = true;
                using (var dbcontext = new QLTTModel())
                {
                    check = dbcontext.NhanViens.Any(nv => nv.Email == useremail && nv.MatKhau == password);
                }

                return check;
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }
    }
}
