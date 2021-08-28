using QLTT.DataAccessLayer.Enities;
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

namespace QLTT.GUI.Admin
{
    public partial class frmReport : Form
    {
     //   QLTTModel contextDB = new QLTTModel();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void HienThiHD()
        {
            using (var _dbContext = new QLTTModel())
            {
                string truyVanSQL = "select HD.MaHD, NgayLap,CT.DonGia, T.TenThuoc,CT.SoLuongMua " +
                    "from HoaDon HD, CTHD CT, Thuoc T " +
                    "where HD.MaHD = CT.MaHD and CT.MaThuoc = T.MaThuoc";

                List<ReportDTO> ds = _dbContext.Database.SqlQuery<ReportDTO>(truyVanSQL).ToList();
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            //HoaDon invoiceeIDHoaDon = contextDB.HoaDons
            //       .FirstOrDefault(p => p.MaHD == int.Parse(txt_MHD.Text));// lấy đối tượng Invoice trùng với value của text

            //List<ReportDTO> listOrder = contextDB.Orderr.Where(p => p.SoHoaDon == cbbMaGH.Text).ToList();
            //if (invoiceeIDHoaDon == null || listOrder.Count() == 0)
            //{
            //    MessageBox.Show("Không tìm thấy đơn hàng!", "Thông báo");
            //    return;
            //}
            ////Sử dụng 2 tham số truyển vào cho report
            //ReportParameter[] param = new ReportParameter[2];
            //param[0] = new ReportParameter("NgayGiaoHang", string.Format("Ngày "
            //    + invoiceeIDHoaDon.NgayGiaoHang.ToString("dd/MM/yyyy")));

            //param[1] = new ReportParameter("SoHoaDon", invoiceeIDHoaDon.SoHoaDon);


            ////-------------------------------------------------------
            //this.reportViewer1.LocalReport.ReportPath = "./Report/ReportDonHang.rdlc"; //nhớ copy report ra debug
            //reportViewer1.LocalReport.SetParameters(param);
            //ReportDataSource reportDataSource = new ReportDataSource("OrderDataSet", listOrder);
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            //reportViewer1.LocalReport.DisplayName = "Phiếu giao hàng"; //tên hiển thị
        }
    }
}
