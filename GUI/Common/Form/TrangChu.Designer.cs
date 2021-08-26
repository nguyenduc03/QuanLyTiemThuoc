
namespace QLTT.Common
{
    partial class TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Titel = new System.Windows.Forms.Label();
            this.ThongTinNSX = new System.Windows.Forms.Label();
            this.lbDate2 = new System.Windows.Forms.Label();
            this.lbTime2 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Titel);
            this.panel1.Controls.Add(this.ThongTinNSX);
            this.panel1.Controls.Add(this.lbDate2);
            this.panel1.Controls.Add(this.lbTime2);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 528);
            this.panel1.TabIndex = 0;
            // 
            // Titel
            // 
            this.Titel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Titel.AutoSize = true;
            this.Titel.Font = new System.Drawing.Font("Mongolian Baiti", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titel.ForeColor = System.Drawing.Color.Gainsboro;
            this.Titel.Location = new System.Drawing.Point(506, 242);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(295, 24);
            this.Titel.TabIndex = 4;
            this.Titel.Text = "Mang bình an đến mọi người";
            // 
            // ThongTinNSX
            // 
            this.ThongTinNSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ThongTinNSX.AutoSize = true;
            this.ThongTinNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongTinNSX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ThongTinNSX.Location = new System.Drawing.Point(607, 500);
            this.ThongTinNSX.Name = "ThongTinNSX";
            this.ThongTinNSX.Size = new System.Drawing.Size(220, 20);
            this.ThongTinNSX.TabIndex = 3;
            this.ThongTinNSX.Text = "power by Gà Mờ Tập Code";
            // 
            // lbDate2
            // 
            this.lbDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbDate2.AutoSize = true;
            this.lbDate2.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbDate2.Location = new System.Drawing.Point(570, 407);
            this.lbDate2.Name = "lbDate2";
            this.lbDate2.Size = new System.Drawing.Size(159, 30);
            this.lbDate2.TabIndex = 2;
            this.lbDate2.Text = "15/15/2021";
            // 
            // lbTime2
            // 
            this.lbTime2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTime2.AutoSize = true;
            this.lbTime2.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTime2.Location = new System.Drawing.Point(591, 355);
            this.lbTime2.Name = "lbTime2";
            this.lbTime2.Size = new System.Drawing.Size(86, 30);
            this.lbTime2.TabIndex = 1;
            this.lbTime2.Text = "20:20";
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Logo.Image = global::QLTT.Properties.Resources.LogoFinal2;
            this.Logo.Location = new System.Drawing.Point(500, 65);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(290, 174);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTT.Properties.Resources.test1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 528);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "TrangChu";
            this.ShowIcon = false;
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.TrangChu_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lbDate2;
        private System.Windows.Forms.Label lbTime2;
        private System.Windows.Forms.Label ThongTinNSX;
        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Timer timer1;
    }
}