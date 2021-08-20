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
using QLTT.DTO;
using QLTT.DataAccessLayer.Enities;

namespace QLTT.Controls
{
    public partial class SanPham : Form
    {
        private readonly ThuocBAL _thuocBAL;
        private string error;
        public SanPham()
        {
            InitializeComponent();
            _thuocBAL = new ThuocBAL();
        }

        private void clearTxtInput()
        {
            txtMaThuoc.Text = "";
            txtSoLuong.Text = "";
            txtMoTa.Text = "";
            txtTenThuoc.Text = "";
            txtDonGia.Text = "";
            txtLoaiThuoc.Text = "";
        }

        private void fillDGV(List<ThuocDTO> dsThuoc)
        {
            dgvDanhMucThuoc.Rows.Clear();
            foreach (ThuocDTO thuoc in dsThuoc)
            {
                dgvDanhMucThuoc.Rows.Add(thuoc.MaThuoc, thuoc.MaLoai, thuoc.TenThuoc, thuoc.SoLuong.ToString(),
                    thuoc.DonGia.ToString(), thuoc.MoTa);
            }
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            clearTxtInput();
            List<ThuocDTO> dsThuoc = _thuocBAL.LayDanhSachThuoc();
            fillDGV(dsThuoc);
        }

        private void dgvDanhMucThuoc_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            txtTenThuoc.Text = dgvDanhMucThuoc.Rows[index].Cells[2].Value.ToString();
            txtMaThuoc.Text = dgvDanhMucThuoc.Rows[index].Cells[0].Value.ToString();
            txtMoTa.Text = dgvDanhMucThuoc.Rows[index].Cells[5].Value.ToString();
            txtDonGia.Text = dgvDanhMucThuoc.Rows[index].Cells[4].Value.ToString();
            txtSoLuong.Text = dgvDanhMucThuoc.Rows[index].Cells[3].Value.ToString();
            txtLoaiThuoc.Text = dgvDanhMucThuoc.Rows[index].Cells[1].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SanPham_Load(sender, e);
        }

        private bool validate()
        {
            if (txtTenThuoc.Text == "" || txtMaThuoc.Text == "" 
                || txtMoTa.Text == "" || txtDonGia.Text == "" 
                || txtSoLuong.Text == "" || txtLoaiThuoc.Text == "")
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin");
                return false;
            }

            if (int.TryParse(txtDonGia.Text, out int test1))
            {
                if (test1<0)
                {
                    MessageBox.Show("vui lòng điền đúng định dạng đơn giá");
                    return false;
                }
                    
            } else
            {
                MessageBox.Show("vui lòng điền đúng định dạng đơn giá");
                return false;
            }

            if (int.TryParse(txtSoLuong.Text, out int test2))
            {
                if (test2 < 0)
                {
                    MessageBox.Show("vui lòng điền đúng định dạng số lượng");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("vui lòng điền đúng định dạng số lượng");
                return false;
            }

            if (txtLoaiThuoc.Text != "DB" && txtLoaiThuoc.Text != "ND" 
                && txtLoaiThuoc.Text != "GD" && txtLoaiThuoc.Text != "TN")
            {
                MessageBox.Show("vui lòng điền đúng mã loại thuốc");
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Thuoc thuocMoi = new Thuoc();
                thuocMoi.MaThuoc = txtMaThuoc.Text;
                thuocMoi.TenThuoc = txtTenThuoc.Text;
                thuocMoi.MoTa = txtMoTa.Text;
                thuocMoi.SoLuong = int.Parse(txtSoLuong.Text);
                thuocMoi.DonGia = int.Parse(txtDonGia.Text);
                thuocMoi.MaLoai = txtLoaiThuoc.Text;
                DialogResult result = MessageBox.Show($"Chắc chắn muốn cập nhật thuốc { txtMaThuoc.Text} không?",
                    "Muốn cập nhật database à", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show(_thuocBAL.capNhatThuoc(thuocMoi, error));
                    SanPham_Load(sender, e);
                }
                
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaThuoc.Text == "")
            {
                MessageBox.Show("vui lòng nhập mã thuốc cần xoá");
            } else if (!_thuocBAL.timKiemThuoc(txtMaThuoc.Text, error))
            {
                MessageBox.Show("không tồn tại thuốc này trong danh sách");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Chắc chắn xoá thuốc { txtMaThuoc.Text} không?", 
                    "Muốn Xoá à", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if(result == DialogResult.Yes)
                {
                    MessageBox.Show(_thuocBAL.xoaThuoc(txtMaThuoc.Text, error));
                    SanPham_Load(sender, e);
                }
            }
            
        }

    }
}
