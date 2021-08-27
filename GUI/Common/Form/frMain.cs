using FontAwesome.Sharp;
using QLTT.Common;
using QLTT.Controls.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTT.Controls.User
{
    public partial class UserForm : Form
    {
        private IconButton CurrentBTN = new IconButton();

        private Form CurrentChildForm;
        public UserForm()
        {
            InitializeComponent();
            OpenChildForm(new TrangChu());
            ShowCurrentBTN(btnTrangChu, ClassColor.color1);

        }


        private void UserForm_Load(object sender, EventArgs e)
        {
            initMenu(false);
        }
        private  void OpenChildForm (Form ChildForm)
        {
            if (CurrentChildForm !=null)
            {
                CurrentChildForm.Close();
            }
            CurrentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnContent.Controls.Add(ChildForm);
            pnContent.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            LabellTiTle.Text = ChildForm.Text;
        }

        public void ShowCurrentBTN(object senderBTN, Color colorInput)
        {
            if (senderBTN != null)
            {
                ResetBTN();
                CurrentBTN = (IconButton)senderBTN;
                CurrentBTN.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBTN.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentBTN.BackColor = Color.FromArgb(70, 252, 252, 252);
                CurrentBTN.IconColor = colorInput;


                /// icon current 
                IconCurrent.IconChar = CurrentBTN.IconChar;
                IconCurrent.IconColor = CurrentBTN.IconColor;

            }
        }
        public void ResetBTN()
        {
            if (CurrentBTN != null)
            {
                CurrentBTN.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBTN.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentBTN.BackColor = Color.FromArgb(47, 49, 49);
                CurrentBTN.IconColor = Color.Gainsboro;
            }
        }

        private void BTNTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TrangChu());
            ShowCurrentBTN(sender, ClassColor.color1);


        }

        private void BTNLapHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LapHoaDon());
            ShowCurrentBTN(sender, ClassColor.color2);


        }

        private void BTNSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SanPham());
            ShowCurrentBTN(sender, ClassColor.color3);


        }

        private void BTNQuanLyNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanVien());
            ShowCurrentBTN(sender, ClassColor.color4);
        }

        private void BTNThongKe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing here");
        }

        private void btnDangNhap2_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<DangNhap>().FirstOrDefault();
            if(frm == null)
            {
                DangNhap frmLogin = new DangNhap();
                frmLogin.loginSucess += FrmLogin_loginSucess;
                frmLogin.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void FrmLogin_loginSucess()
        {
            initMenu(true);
        }

        private void initMenu(bool login)
        {
            btnTrangChu.Enabled = login;
            pnContent.Enabled = login;
            btnLapHoaDon.Enabled = login;
            btnQuanLyNV.Enabled = login;
            btnSanPham.Enabled = login;
            btnThongke.Enabled = login;
            btnDangXuat.Enabled = login;
            btnDangNhap2.Enabled = !login;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            initMenu(false);
            DangNhap frmLogin = new DangNhap();
            frmLogin.loginSucess += FrmLogin_loginSucess;
            frmLogin.Show();
        }
    }
}