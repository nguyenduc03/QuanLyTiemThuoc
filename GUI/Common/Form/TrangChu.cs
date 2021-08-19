using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTT.Common
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

       

        private void TrangChu_Load_1(object sender, EventArgs e)
        {
            Logo.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
            lbDate.BackColor =Color.FromArgb(0, 0, 0, 0);
            lbTime.BackColor = Color.FromArgb(0, 0, 0, 0);
            ThongTinNSX.BackColor = Color.FromArgb(0, 0, 0, 0);
            Titel.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void Titel_Click(object sender, EventArgs e)
        {

        }
    }
}
