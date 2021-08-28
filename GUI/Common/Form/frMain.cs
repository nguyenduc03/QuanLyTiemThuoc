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
using QLTT.DataAccessLayer.Enities;
using QLTT.Helpers;
using QLTT.BusinessAccessLayer;
using QLTT.DTO;

namespace QLTT.Controls.User
{
    public partial class UserForm : Form
    {
        private IconButton CurrentBTN = new IconButton();

        private Form CurrentChildForm;

        private DangNhap dangNhap;

        private NhanVien nhanVien;

        public getDelegate getMaNVDelegate;
        private readonly NhanVienBAL _nhanVienBAL;
        public UserForm(NhanVien nv, DangNhap temp)
        {
            InitializeComponent();

            getMaNVDelegate = new getDelegate(GetMessage);

            _nhanVienBAL = new NhanVienBAL();

            OpenChildForm(new TrangChu());
            ShowCurrentBTN(btnTrangChu, ClassColor.color1);
            this.nhanVien = nv;
            this.dangNhap = temp;
            this.dangNhap.loginSucess += FrmLogin_loginSucess;
        }

        private void GetMessage(string Message)
        {
            lblUser.Text = Message;
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentChildForm != null)
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
            LapHoaDon f = new LapHoaDon(this);
            f.getMaNVDelegate(lblUser.Text);
            OpenChildForm(f);
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

        public void showChiTiet(string maHD)
        {
            ChiTietHoaDon frm = new ChiTietHoaDon(this);
            frm.getMaHDDelegate(maHD);
            OpenChildForm(frm);
        }

        public void showLapHoaDon(UserForm x)
        {
            OpenChildForm(new LapHoaDon(this));
        }

        private void BTNThongKe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing here");
        }


        private void FrmLogin_loginSucess()
        {
            initMenu(bool.Parse(nhanVien.Role.ToString()));
        }

        private void initMenu(bool role)
        {
            btnSanPham.Visible = role;
            btnQuanLyNV.Visible = role;
            btnTrangChu.Visible = true;
            btnLapHoaDon.Visible = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.dangNhap.Show();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
            loadNV();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void loadNV()
        {
            List<NhanVienDTO> dsNV = _nhanVienBAL.LayDanhSachNV();
            var nv = (from s in dsNV
                      where s.MaNV == int.Parse(lblUser.Text)
                      select s).First();
            lbl_Name.Text = nv.TenNV.ToString();
        }
    }
}