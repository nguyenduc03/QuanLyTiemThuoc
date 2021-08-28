using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using QLTT.DataAccessLayer;
using QLTT.DataAccessLayer.Enities;


namespace QLTT.BusinessAccessLayer
{
    public class TaiKhoanBAL
    {
        private readonly TaiKhoanDAL _taiKhoanDAL;

        public TaiKhoanBAL()
        {
            _taiKhoanDAL = new TaiKhoanDAL();
        }

        //kiểm tra đăng nhập
        public bool KiemTraDangNhap(int userID, string password, out string error)
        {
            return _taiKhoanDAL.KiemTraDangNhap(userID, MD5Hash(password), out error);
        }

        //lấy tài khoản
        public NhanVien layTaiKhoan(int userID, string password, out string error)
        {
            return _taiKhoanDAL.layTaiKhoan(userID, MD5Hash(password), out error);
        }

        //mã hoá mật khẩu
        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
