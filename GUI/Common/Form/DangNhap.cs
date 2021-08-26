using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTT.BusinessAccessLayer;
using QLTT.Controls.User;
using QLTT.DataAccessLayer.Enities;
using QLTT.Helpers;


namespace QLTT.Common
{
    public partial class DangNhap : Form
    {
        private readonly TaiKhoanBAL _taiKhoanBAL;
        public event LoginSucessDelegate loginSucess;
        public DangNhap()
        {
            InitializeComponent();
            _taiKhoanBAL = new TaiKhoanBAL();
        }


        //nhấn nút đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //nhận thông tin nhập vào
            string userID = this.txtUserID.Text.Trim();
            string userMatKhau = this.txtMatKhau.Text.Trim();
            //kiểm tra rỗng
            if (userID == "" || userMatKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy dủ thông tin");
                return;
            }

            //kiểm tra tài khoản trong database
            string error = "";
            if (_taiKhoanBAL.KiemTraDangNhap(userID, userMatKhau, out error))
            {
                QLTTModel dbcontext = new QLTTModel();
                NhanVien nv = _taiKhoanBAL.layTaiKhoan(userID, userMatKhau, out error);
                UserForm frm = new UserForm(nv, this);
                loginSucess();
                MessageBox.Show("đăng nhập thành công!");
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập sai\n" + error);
            }
        }

        private void txtTaiKhoan_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(sender);
        }

        private bool ValidateInput(object sender)
        {
            TextBox txtInput = (TextBox)sender;
            if (txtInput.Text.Trim() == "")
            {
                errorProvider1.SetError(txtInput, "Vui lòng nhập thông tin!");
                return false;
            }

            errorProvider1.SetError(txtInput, "");
            return true;
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(sender);
        }

    }
}
