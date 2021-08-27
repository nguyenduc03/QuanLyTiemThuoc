using QLTT.BusinessAccessLayer;
using QLTT.DataAccessLayer.Enities;
using QLTT.DTO;
using QLTT.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTT.Controls.Admin
{
    public partial class ChiTietHoaDon : Form
    {
        public CTHDDelegate cthdDelegate;

        private readonly HoaDonBAL _hoaDonBAL;
        private readonly ChiTietHoaDonBAL _chiTietHoaDonBAL;
        private readonly NhanVienBAL _nhanVienBAL;
        private readonly ThuocBAL _thuocBAL;
        int maHoaDon;
        int Id;
        public ChiTietHoaDon()
        {
            InitializeComponent();
            cthdDelegate = new CTHDDelegate(GetMessage);
            _nhanVienBAL = new NhanVienBAL();
            _thuocBAL = new ThuocBAL();
            _hoaDonBAL = new HoaDonBAL();
            _chiTietHoaDonBAL = new ChiTietHoaDonBAL();
        }

        private void GetMessage(string Message)
        {
            txtMaHD.Text = Message;
        }

        private void fillDGV_CTHD(List<ChiTietHoaDonDTO> dsCTHD)
        {
            dgv_CTHD.Rows.Clear();
            foreach (var item in dsCTHD)
            {
                int index = dgv_CTHD.Rows.Add();
                dgv_CTHD.Rows[index].Cells[0].Value = item.Id;
                dgv_CTHD.Rows[index].Cells[1].Value = item.MaHoaDon;
                dgv_CTHD.Rows[index].Cells[2].Value = item.SoLuongMua;
                dgv_CTHD.Rows[index].Cells[3].Value = item.TenThuoc;
                dgv_CTHD.Rows[index].Cells[4].Value = item.GiaTien;

            }
        }

        private void Tai_cbbThuoc()
        {
            cbbMaThuoc.DisplayMember = "TenThuoc";
            cbbMaThuoc.ValueMember = "MaThuoc";
            List<ThuocDTO> dsThuoc = _thuocBAL.LayDanhSachThuoc();
            cbbMaThuoc.DataSource = dsThuoc;
        }

        private void TaiCTHD()
        {
            maHoaDon = int.Parse(txtMaHD.Text);
            List<ChiTietHoaDonDTO> chiTietHoaDonDTOs = _chiTietHoaDonBAL.GetChiTietHoaDonsByMaHoaDon(maHoaDon);
            fillDGV_CTHD(chiTietHoaDonDTOs);
            TongTien();
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            TaiCTHD();
            Tai_cbbThuoc();
        }
        void TongTien()
        {
            int sCount = 0;
            for (int i = 0; i < dgv_CTHD.Rows.Count; i++)
            {
                if (dgv_CTHD.Rows[i].Cells[4].Value != null)
                {
                    sCount += int.Parse(dgv_CTHD.Rows[i].Cells[4].Value.ToString()) * int.Parse(dgv_CTHD.Rows[i].Cells[2].Value.ToString());
                }
            }
            txtTongTien.Text = sCount.ToString();
        }
        void clear()
        {
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";        
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
            txtTongTien.Text = "";
        }

        private void dgv_CTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_CTHD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgv_CTHD.CurrentRow.Selected = true;
                    Id = Convert.ToInt32(dgv_CTHD.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtMaHD.Text = dgv_CTHD.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    maHoaDon = Convert.ToInt32(dgv_CTHD.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                    txtSoLuong.Text = dgv_CTHD.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    cbbMaThuoc.SelectedIndex = cbbMaThuoc.FindString(dgv_CTHD.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                    txtDonGia.Text = dgv_CTHD.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    int sl = int.Parse(dgv_CTHD.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    int dongia = int.Parse(dgv_CTHD.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                    txtThanhTien.Text = (sl * dongia).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có vẻ bạn chọn sai chỗ!", "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkNull()
        {
            if (txtDonGia.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string error;
            CTHD cthd = new CTHD();

            if (checkNull())
            {
                cthd.MaHD = int.Parse( txtMaHD.Text);
                cthd.MaThuoc = cbbMaThuoc.SelectedValue.ToString();
                cthd.SoLuongMua = int.Parse(txtSoLuong.Text);
                cthd.DonGia = int.Parse(txtDonGia.Text);
               
              
                    if (_chiTietHoaDonBAL.LuuChiTietHoaDon(cthd, out error))
                    {
                        MessageBox.Show("Thêm thành công!");
                        TaiCTHD();
                        TongTien();
                }
                    else
                    {
                        MessageBox.Show("Thêm mới không thành công! " + error);
                    }
                

            }
        }

        private void UpdateTT()
        {
            string error;
            //Update TT Hóa đơn
            HoaDon hd = new HoaDon();
            hd.MaHD = maHoaDon;
            hd.TongTien = int.Parse(txtTongTien.Text);
            ////
            if (_chiTietHoaDonBAL.CapnhatTongTien(hd, out error))
            {

                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật tổng tiền thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên!");
                return;
            }
            else
            {
                if (checkNull())
                {
                    string error;
                    CTHD cthd = new CTHD();                  
                    cthd.MaHD = int.Parse(txtMaHD.Text);
                    cthd.MaThuoc = cbbMaThuoc.SelectedValue.ToString();
                    cthd.SoLuongMua = int.Parse(txtSoLuong.Text);
                    cthd.DonGia = int.Parse(txtDonGia.Text);
                    cthd.Id = Id;

                   
                    if (_chiTietHoaDonBAL.LuuChiTietHoaDon(cthd, out error))
                    {
                       
                        TaiCTHD();
                        clear();
                        TongTien();
                        UpdateTT();


                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công! " + error);
                    }
                }
                   
            }
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                MessageBox.Show("vui lòng chọn chi tiết hóa đơn  cần xoá");
            }          
            else
            {
                DialogResult result = MessageBox.Show($"Chắc chắn xoá chi tiết hóa đơn này không?",
                    "Bạn đang xóa 1 chi tiết hóa đơn ....", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string error;
                    CTHD cthd = new CTHD();
                    cthd.Id = Id;
                    if (_chiTietHoaDonBAL.xoaCTHD(cthd, out error))
                    {
                        MessageBox.Show("Xóa thành công!");
                        TaiCTHD();
                        clear();
                        TongTien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công! " + error);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LapHoaDon frm = new LapHoaDon();
            frm.Show();
        }
    }
}
