
using QLTT.BusinessAccessLayer;
using QLTT.Controls.Admin;
using QLTT.Controls.User;
using QLTT.DataAccessLayer.Enities;
using QLTT.DTO;
using QLTT.GUI.Admin;
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

namespace QLTT
{
    public partial class LapHoaDon : Form
    {

        public getDelegate getMaNVDelegate;

        private readonly HoaDonBAL _hoaDonBAL;
        private readonly ChiTietHoaDonBAL _chiTietHoaDonBAL;
        private readonly NhanVienBAL _nhanVienBAL;
        private readonly ThuocBAL _thuocBAL;
        int maHoaDon;
        private UserForm temp;

        public LapHoaDon(UserForm x)
        {
            InitializeComponent();
            _nhanVienBAL = new NhanVienBAL();
            _thuocBAL = new ThuocBAL();
            _hoaDonBAL = new HoaDonBAL();
            _chiTietHoaDonBAL = new ChiTietHoaDonBAL();
            temp = x;
            getMaNVDelegate = new getDelegate(GetMessage);
        }

        private void GetMessage(string Message)
        {
            txt_NV.Text = Message;
        }

        private void LapHoaDon_Load(object sender, EventArgs e)
        {
            Tai_cbbThuoc();
            Tai_cbbNV();
            TaiDanhSachHoaDon();
        }
        private void Tai_cbbNV()
        {
            cbbMaNV.DisplayMember = "TenNV";
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

        public void reload()
        {
            TaiDanhSachHoaDon();
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
                dgv_CTHD.Rows[index].Cells[0].Value = item.Id;
                dgv_CTHD.Rows[index].Cells[1].Value = item.MaHoaDon;
                dgv_CTHD.Rows[index].Cells[2].Value = item.SoLuongMua;
                dgv_CTHD.Rows[index].Cells[3].Value = item.TenThuoc;
                dgv_CTHD.Rows[index].Cells[4].Value = item.GiaTien;

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
                    //  txtTongTien.Text = dgv_HoaDon.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    cbbMaNV.SelectedIndex = cbbMaNV.FindString(dgv_HoaDon.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());

                    //Search CTHD
                    int rowIndex = e.RowIndex;
                    maHoaDon = int.Parse(dgv_HoaDon.Rows[rowIndex].Cells[0].Value.ToString());
                    List<ChiTietHoaDonDTO> chiTietHoaDonDTOs = _chiTietHoaDonBAL.GetChiTietHoaDonsByMaHoaDon(maHoaDon);
                    fillDGV_CTHD(chiTietHoaDonDTOs);
                    TongTien();

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

                    txtMaHD.Text = dgv_CTHD.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
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


        private void btnThem_Click(object sender, EventArgs e)
        {
            string error;
            HoaDon hd = new HoaDon();


            hd.MaNV = Convert.ToInt32(cbbMaNV.SelectedValue.ToString());
            hd.NgayLap = (DateTime)dtpNgayBan.Value;
            if (txtTongTien.Text.Trim() == "")
            {
                hd.TongTien = 0;
            }
            else
            {
                hd.TongTien = int.Parse(txtTongTien.Text.Trim());
            }

            hd.TongTien = 0;
            if (_hoaDonBAL.LuuHoaDon(hd, out error))
            {
                MessageBox.Show("Thêm thành công!");
                TaiDanhSachHoaDon();
                clear();
                TongTien();
            }
            else
            {
                MessageBox.Show("Thêm mới không thành công! " + error);
            }


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

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Vui Lòng chọn Hóa Đơn");
            }
            else
            {


                temp.showChiTiet(txtMaHD.Text);
                // dgv_CTHD.Rows.Clear();
                this.Close();
            }

        }
        

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maHoaDon == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên!");
                return;
            }
            else
            {

                string error;
                HoaDon hd = new HoaDon();
                hd.MaNV = Convert.ToInt32(cbbMaNV.SelectedValue.ToString());
                hd.NgayLap = (DateTime)dtpNgayBan.Value;
                hd.TongTien = int.Parse(txtTongTien.Text);
                hd.MaHD = maHoaDon;

                if (_hoaDonBAL.LuuHoaDon(hd, out error))
                {

                    TaiDanhSachHoaDon();
                    clear();
                    TongTien();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công! " + error);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (maHoaDon == 0)
            {
                MessageBox.Show("vui lòng chọn hóa đơn  cần xoá");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Chắc chắn xoá hóa đơn này không?",
                    "Bạn đang xóa 1 hóa đơn ....", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string error;
                    HoaDon hd = new HoaDon();
                    hd.MaHD = maHoaDon;
                    if (_hoaDonBAL.xoaHD(hd, out error))
                    {
                        MessageBox.Show("Xóa thành công!");
                        TaiDanhSachHoaDon();
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

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if(txtMaHD.Text=="")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in");
            }
            else
            {
                frmReport frm = new frmReport();
                frm.getDelegate(txtMaHD.Text);
                frm.Show();
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void panelTitel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
