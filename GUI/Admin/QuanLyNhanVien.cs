using QLTT.BusinessAccessLayer;
using QLTT.DataAccessLayer.Enities;
using QLTT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTT.Controls
{
    public partial class QuanLyNhanVien : Form
    {
        private readonly NhanVienBAL _nhanVienBAL;
        private readonly HoaDonBAL _hoaDonnBAL;
        private string error = "";
        int maNV;

        public QuanLyNhanVien()
        {
            InitializeComponent();
            _nhanVienBAL = new NhanVienBAL();
            _hoaDonnBAL = new HoaDonBAL();
    
        }


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


        private void fillDGV(List<NhanVienDTO> dsNV)
        {
            dgv_NV.Rows.Clear();
            foreach (var item in dsNV)
            {
                int index = dgv_NV.Rows.Add();
                dgv_NV.Rows[index].Cells[0].Value = item.MaNV;
                dgv_NV.Rows[index].Cells[1].Value = item.TenNV;
                dgv_NV.Rows[index].Cells[2].Value = item.NgaySinh;
                dgv_NV.Rows[index].Cells[3].Value = item.SDT;
                dgv_NV.Rows[index].Cells[4].Value = item.Email;
                dgv_NV.Rows[index].Cells[5].Value = item.MatKhau;
                dgv_NV.Rows[index].Cells[6].Value = item.Role;
        
            }
        }

       
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            TaiDanhSachNV();
        }


        private bool checkNull()
        {
            if (txtSDT.Text == "" || txtTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return false;
            }

            return true;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email");
                return false;
            }
        }

        private void TaiDanhSachNV()
        {
            List<NhanVienDTO> dsNV = _nhanVienBAL.LayDanhSachNV();
            fillDGV(dsNV);
        }

        private bool checkAD()
        {
            int role;
            if (chkAdmin.Checked == false)
            {
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {           

            string error;
            NhanVien nv = new NhanVien();
           
            if (checkNull())
            {
                nv.TenNV = txtTenNV.Text;
                nv.SDT = Convert.ToInt32(txtSDT.Text);
                nv.Email = txtMailNV.Text;
                nv.NgaySinh = (DateTime)dtpNgaySinh.Value;
                nv.MatKhau =MD5Hash(txt_MK.Text);
                nv.Role = checkAD();
                if(IsValidEmail(nv.Email))
                {
                    if (_nhanVienBAL.LuuNhanVien(nv, out error))
                    {
                        MessageBox.Show("Thêm thành công!");
                        TaiDanhSachNV();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới không thành công! " + error);
                    }
                }
             
            }
            
        }

        private void dgv_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_NV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgv_NV.CurrentRow.Selected = true;
                    maNV = Convert.ToInt32(dgv_NV.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtMaNV.Text = dgv_NV.Rows[e.RowIndex].Cells[0].Value.ToString();
                   
                    txtTenNV.Text = dgv_NV.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    dtpNgaySinh.Value = Convert.ToDateTime(dgv_NV.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    txtSDT.Text = dgv_NV.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtMailNV.Text = dgv_NV.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    txt_MK.Text = "";
                    string z;
                    z = dgv_NV.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    if (z.Equals( "False"))
                    {
                        chkAdmin.Checked = false;
                    }
                    else
                    {
                        chkAdmin.Checked = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có vẻ bạn chọn sai chỗ!", "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            txtMailNV.Text = "";
            txtMaNV.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";
            txtTimKiem.Text = "";
            txt_MK.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (maNV == 0)
            {
                MessageBox.Show("vui lòng chọn nhân viên  cần xoá");
            }
            if (_hoaDonnBAL.KiemTraHoaDonByMaNhanVien(maNV))
            {
                MessageBox.Show("Không thể xóa\nNhân viên tồn tại trong hóa đơn!");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show($"Chắc chắn xoá nhân viên { txtTenNV.Text} không?",
                    "Bạn đang xóa 1 nhân viên ....", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string error;
                    NhanVien nv = new NhanVien();
                    nv.MaNV = maNV;
                    if (_nhanVienBAL.xoaNV(nv, out error))
                    {
                        MessageBox.Show("Xóa thành công!");
                        TaiDanhSachNV();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công! " + error);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
            if (maNV == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên!");
                return;
            }
            string error;
            NhanVien nv = new NhanVien();
            nv.TenNV = txtTenNV.Text;
            nv.NgaySinh = (DateTime)dtpNgaySinh.Value;
            nv.SDT = Convert.ToInt32(txtSDT.Text);
            nv.Email = txtMailNV.Text;
            nv.MatKhau = MD5Hash(txt_MK.Text);
            nv.Role = checkAD();
            nv.MaNV = maNV;
            if (_nhanVienBAL.LuuNhanVien(nv, out error))
            {
                MessageBox.Show("Cập nhật thành công!");
                TaiDanhSachNV();
                clear();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công! " + error);
            }
        }

        private void panelNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }
    }
}
