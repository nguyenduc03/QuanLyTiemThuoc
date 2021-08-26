
using QLTT.BusinessAccessLayer;
using QLTT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTT
{
    public partial class LapHoaDon : Form
    {
        private readonly HoaDonBAL _hoaDonBAL;
        private readonly ChiTietHoaDonBAL _chiTietHoaDonBAL;
        private readonly NhanVienBAL _nhanVienBAL;
        private readonly ThuocBAL _thuocBAL;
        public LapHoaDon()
        {
            InitializeComponent();
            _nhanVienBAL = new NhanVienBAL();
            _thuocBAL = new ThuocBAL();
            _hoaDonBAL = new HoaDonBAL();
            _chiTietHoaDonBAL = new ChiTietHoaDonBAL();
        }

        private void LapHoaDon_Load(object sender, EventArgs e)
        {
            Tai_cbbThuoc();
            Tai_cbbNV();
            TaiDanhSachHoaDon();
        }
        private void Tai_cbbNV()
        {
            cbbMaNV.DisplayMember ="TenNV";
            cbbMaNV.ValueMember = "MaNV";
            List<NhanVienDTO> dsNV = _nhanVienBAL.LayDanhSachNV();
            cbbMaNV.DataSource = dsNV;
        }

        private void Tai_cbbThuoc()
        {
            cbbMaThuoc.DisplayMember = "TenThuoc";
            cbbMaThuoc.ValueMember = "MaThuoc";
            List<ThuocDTO> dsThuoc = _thuocBAL.LayDanhSachThuoc();
            cbbMaThuoc.DataSource = dsThuoc;
        }

        private void TaiDanhSachHoaDon()
        {
            List<HoaDonDTO> danhSachHoaDon = _hoaDonBAL.LayDanhSachHD();
            fillDGVHD(danhSachHoaDon);
        }
        private void fillDGVHD(List<HoaDonDTO> dsHD)
        {
            dgv_HoaDon.Rows.Clear();
            foreach (var item in dsHD)
            {
                int index = dgv_HoaDon.Rows.Add();
                dgv_HoaDon.Rows[index].Cells[0].Value = item.MaHoaDon;
                dgv_HoaDon.Rows[index].Cells[1].Value = item.NgayLap;
                dgv_HoaDon.Rows[index].Cells[2].Value = item.TongTien;
                dgv_HoaDon.Rows[index].Cells[3].Value = item.TenNhanVien;

            }
        }

        private void fillDGV_CTHD(List<ChiTietHoaDonDTO> dsCTHD)
        {
            dgv_CTHD.Rows.Clear();
            foreach (var item in dsCTHD)
            {
                int index = dgv_CTHD.Rows.Add();
                dgv_CTHD.Rows[index].Cells[0].Value = item.MaHoaDon;              
                dgv_CTHD.Rows[index].Cells[1].Value = item.SoLuongMua;
                dgv_CTHD.Rows[index].Cells[2].Value = item.TenThuoc;
                dgv_CTHD.Rows[index].Cells[3].Value = item.GiaTien;

            }
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                if (dgv_HoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                   
                    dgv_HoaDon.CurrentRow.Selected = true;

                    txtMaHD.Text = dgv_HoaDon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();                 
                    dtpNgayBan.Value = Convert.ToDateTime(dgv_HoaDon.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                    txtTongTien.Text = dgv_HoaDon.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    cbbMaNV.SelectedIndex = cbbMaNV.FindString(dgv_HoaDon.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());

                    int rowIndex = e.RowIndex;
                    int maHoaDon = int.Parse(dgv_HoaDon.Rows[rowIndex].Cells[0].Value.ToString());
                    List<ChiTietHoaDonDTO> chiTietHoaDonDTOs = _chiTietHoaDonBAL.GetChiTietHoaDonsByMaHoaDon(maHoaDon);
                    fillDGV_CTHD(chiTietHoaDonDTOs);
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có vẻ bạn chọn sai chỗ!", "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void clear()
        {
            txtMaHD.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
        }

        private void dgv_CTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_CTHD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgv_CTHD.CurrentRow.Selected = true;

                    txtMaHD.Text = dgv_CTHD.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtSoLuong.Text = dgv_CTHD.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();                  
                    cbbMaThuoc.SelectedIndex = cbbMaThuoc.FindString(dgv_CTHD.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    txtDonGia.Text = dgv_CTHD.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();

                    int rowIndex = e.RowIndex;
                  //  int maHoaDon = int.Parse(dgv_HoaDon.Rows[rowIndex].Cells[0].Value.ToString());


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có vẻ bạn chọn sai chỗ!", "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
