using Microsoft.Reporting.WinForms;
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

namespace QLTT.GUI.Admin
{
    public partial class frmReport : Form
    {
        //   QLTTModel contextDB = new QLTTModel();
        public getMaHDDelegate getDelegate;
        public frmReport()
        {
            InitializeComponent();
            getDelegate = new getMaHDDelegate(GetMessage);
        }

        private void GetMessage(string Message)
        {
            txt_MHD.Text = Message;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
            HienThiHD();
        }

        private void HienThiHD()
        {
            using (var _dbContext = new QLTTModel())
            {
                string truyVanSQL = "select HD.MaHD, NgayLap,CT.DonGia, T.TenThuoc,CT.SoLuongMua from HoaDon HD, CTHD CT, Thuoc T where HD.MaHD = CT.MaHD and CT.MaThuoc = T.MaThuoc";

                List<ReportDTO> ds = _dbContext.Database.SqlQuery<ReportDTO>(truyVanSQL).ToList();

                if (txt_MHD.Text != "")
                {
                    ds = ds.Where(hd => hd.MaHD == int.Parse(txt_MHD.Text)).ToList();
                }

                //HoaDon invoiceeIDHoaDon = _dbContext.HoaDons
                //       .FirstOrDefault(p => p.MaHD == int.Parse(txt_MHD.Text));// lấy đối tượng Invoice trùng với value của text

                ////Sử dụng 2 tham số truyển vào cho report
                //ReportParameter[] param = new ReportParameter[2];
                //param[0] = new ReportParameter("NgayLap", string.Format("Ngày "
                //    + invoiceeIDHoaDon.NgayLap.Value));

                //param[1] = new ReportParameter("MaHD", invoiceeIDHoaDon.MaHD.ToString());


                this.reportViewer1.LocalReport.ReportPath = "rptHoaDon.rdlc";
                var reportDataSource = new ReportDataSource("HDDataset", ds);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
        }

    }
}
