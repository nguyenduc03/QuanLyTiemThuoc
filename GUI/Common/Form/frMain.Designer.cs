
namespace QLTT.Controls.User
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btnQuanLyNV = new FontAwesome.Sharp.IconButton();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.btnSanPham = new FontAwesome.Sharp.IconButton();
            this.btnLapHoaDon = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnTrangChu = new FontAwesome.Sharp.IconButton();
            this.pnContent = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTime = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Titel = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.IconCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.LabellTiTle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.pnContent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel_Menu.Controls.Add(this.btnQuanLyNV);
            this.panel_Menu.Controls.Add(this.btnDangXuat);
            this.panel_Menu.Controls.Add(this.btnSanPham);
            this.panel_Menu.Controls.Add(this.btnLapHoaDon);
            this.panel_Menu.Controls.Add(this.panel1);
            this.panel_Menu.Controls.Add(this.btnTrangChu);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(222, 671);
            this.panel_Menu.TabIndex = 2;
            // 
            // btnQuanLyNV
            // 
            this.btnQuanLyNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnQuanLyNV.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNV.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuanLyNV.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnQuanLyNV.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQuanLyNV.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnQuanLyNV.IconSize = 45;
            this.btnQuanLyNV.Location = new System.Drawing.Point(3, 350);
            this.btnQuanLyNV.Name = "btnQuanLyNV";
            this.btnQuanLyNV.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQuanLyNV.Size = new System.Drawing.Size(216, 60);
            this.btnQuanLyNV.TabIndex = 9;
            this.btnQuanLyNV.Text = "     Quản Lý          Nhân Viên";
            this.btnQuanLyNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyNV.UseVisualStyleBackColor = false;
            this.btnQuanLyNV.Click += new System.EventHandler(this.BTNQuanLyNV_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoSize = true;
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnDangXuat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDangXuat.IconSize = 45;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 599);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(222, 72);
            this.btnDangXuat.TabIndex = 9;
            this.btnDangXuat.Text = "Đăng Xuất    ";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSanPham.IconChar = FontAwesome.Sharp.IconChar.Capsules;
            this.btnSanPham.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSanPham.IconSize = 45;
            this.btnSanPham.Location = new System.Drawing.Point(0, 284);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSanPham.Size = new System.Drawing.Size(220, 60);
            this.btnSanPham.TabIndex = 7;
            this.btnSanPham.Text = "Sản Phẩm     ";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.BTNSanPham_Click);
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnLapHoaDon.FlatAppearance.BorderSize = 0;
            this.btnLapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHoaDon.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDon.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLapHoaDon.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.btnLapHoaDon.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLapHoaDon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLapHoaDon.IconSize = 45;
            this.btnLapHoaDon.Location = new System.Drawing.Point(0, 202);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLapHoaDon.Size = new System.Drawing.Size(220, 60);
            this.btnLapHoaDon.TabIndex = 6;
            this.btnLapHoaDon.Text = "Lập Hóa Đơn";
            this.btnLapHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLapHoaDon.UseVisualStyleBackColor = false;
            this.btnLapHoaDon.Click += new System.EventHandler(this.BTNLapHoaDon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 100);
            this.panel1.TabIndex = 5;
            // 
            // Logo
            // 
            this.Logo.Image = global::QLTT.Properties.Resources.LogoFinal2;
            this.Logo.Location = new System.Drawing.Point(33, 8);
            this.Logo.Name = "Logo";
            this.Logo.Padding = new System.Windows.Forms.Padding(10);
            this.Logo.Size = new System.Drawing.Size(169, 92);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTrangChu.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnTrangChu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTrangChu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTrangChu.IconSize = 45;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 125);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(220, 60);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang Chủ    ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.BTNTrangChu_Click);
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.panel2);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(222, 0);
            this.pnContent.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pnContent.Name = "pnContent";
            this.pnContent.Padding = new System.Windows.Forms.Padding(10);
            this.pnContent.Size = new System.Drawing.Size(962, 671);
            this.pnContent.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelTime);
            this.panel2.Controls.Add(this.panelTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 100);
            this.panel2.TabIndex = 0;
            // 
            // panelTime
            // 
            this.panelTime.Controls.Add(this.lblUser);
            this.panelTime.Controls.Add(this.lbl_Name);
            this.panelTime.Controls.Add(this.label1);
            this.panelTime.Controls.Add(this.Titel);
            this.panelTime.Controls.Add(this.lbDate);
            this.panelTime.Controls.Add(this.lbTime);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTime.Location = new System.Drawing.Point(373, 0);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(569, 100);
            this.panelTime.TabIndex = 4;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUser.Location = new System.Drawing.Point(523, 17);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 19;
            this.lblUser.Visible = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Name.Location = new System.Drawing.Point(399, 44);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(57, 20);
            this.lbl_Name.TabIndex = 18;
            this.lbl_Name.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(302, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Chào mừng";
            // 
            // Titel
            // 
            this.Titel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Titel.AutoSize = true;
            this.Titel.Font = new System.Drawing.Font("Mongolian Baiti", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titel.ForeColor = System.Drawing.Color.Gainsboro;
            this.Titel.Location = new System.Drawing.Point(175, -103);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(295, 24);
            this.Titel.TabIndex = 13;
            this.Titel.Text = "Mang bình an đến mọi người";
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbDate.Location = new System.Drawing.Point(61, 60);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(159, 30);
            this.lbDate.TabIndex = 12;
            this.lbDate.Text = "15/15/2021";
            // 
            // lbTime
            // 
            this.lbTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTime.Location = new System.Drawing.Point(73, 17);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(120, 31);
            this.lbTime.TabIndex = 10;
            this.lbTime.Text = "20:20:20";
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.IconCurrent);
            this.panelTitle.Controls.Add(this.LabellTiTle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(373, 100);
            this.panelTitle.TabIndex = 2;
            // 
            // IconCurrent
            // 
            this.IconCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.IconCurrent.ForeColor = System.Drawing.Color.Coral;
            this.IconCurrent.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IconCurrent.IconColor = System.Drawing.Color.Coral;
            this.IconCurrent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrent.IconSize = 39;
            this.IconCurrent.Location = new System.Drawing.Point(56, 32);
            this.IconCurrent.Name = "IconCurrent";
            this.IconCurrent.Size = new System.Drawing.Size(51, 39);
            this.IconCurrent.TabIndex = 2;
            this.IconCurrent.TabStop = false;
            // 
            // LabellTiTle
            // 
            this.LabellTiTle.AutoSize = true;
            this.LabellTiTle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabellTiTle.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabellTiTle.Location = new System.Drawing.Point(136, 39);
            this.LabellTiTle.Name = "LabellTiTle";
            this.LabellTiTle.Size = new System.Drawing.Size(122, 25);
            this.LabellTiTle.TabIndex = 1;
            this.LabellTiTle.Text = "Trang Chủ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1184, 671);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1200, 710);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tiệm Thuốc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.pnContent.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnSanPham;
        private FontAwesome.Sharp.IconButton btnLapHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private FontAwesome.Sharp.IconButton btnTrangChu;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label LabellTiTle;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private FontAwesome.Sharp.IconPictureBox IconCurrent;
        private FontAwesome.Sharp.IconButton btnQuanLyNV;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
    }
}