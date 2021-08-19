
namespace QLTT.Controls
{
    partial class SanPham
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
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GBThongTin = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.labelMota = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTenThuoc = new System.Windows.Forms.Label();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.labelMaThuoc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgrvDanhMucThuoc = new System.Windows.Forms.DataGridView();
            this.panelTieuDe.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GBThongTin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDanhMucThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.Controls.Add(this.labelTieuDe);
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Location = new System.Drawing.Point(0, 0);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(800, 53);
            this.panelTieuDe.TabIndex = 0;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieuDe.Location = new System.Drawing.Point(290, 16);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(214, 26);
            this.labelTieuDe.TabIndex = 0;
            this.labelTieuDe.Text = "DANH MỤC THUỐC";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnSua);
            this.panelMenu.Controls.Add(this.btnHuy);
            this.panelMenu.Controls.Add(this.btnXoa);
            this.panelMenu.Controls.Add(this.btnLuu);
            this.panelMenu.Controls.Add(this.btnThem);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(5, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelMenu.Size = new System.Drawing.Size(790, 37);
            this.panelMenu.TabIndex = 18;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 40;
            this.btnSua.Location = new System.Drawing.Point(342, -3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(146, 35);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnHuy.IconColor = System.Drawing.Color.White;
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuy.IconSize = 40;
            this.btnHuy.Location = new System.Drawing.Point(171, -3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(146, 35);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 40;
            this.btnXoa.Location = new System.Drawing.Point(646, -3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(146, 35);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnLuu.IconColor = System.Drawing.Color.White;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 40;
            this.btnLuu.Location = new System.Drawing.Point(494, -3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(146, 35);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 40;
            this.btnThem.Location = new System.Drawing.Point(7, -3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(146, 35);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GBThongTin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(800, 142);
            this.panel1.TabIndex = 0;
            // 
            // GBThongTin
            // 
            this.GBThongTin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GBThongTin.Controls.Add(this.panel8);
            this.GBThongTin.Controls.Add(this.txtMoTa);
            this.GBThongTin.Controls.Add(this.labelMota);
            this.GBThongTin.Controls.Add(this.panel6);
            this.GBThongTin.Controls.Add(this.txtSoLuong);
            this.GBThongTin.Controls.Add(this.panel5);
            this.GBThongTin.Controls.Add(this.labelSoLuong);
            this.GBThongTin.Controls.Add(this.txtDonGia);
            this.GBThongTin.Controls.Add(this.panel4);
            this.GBThongTin.Controls.Add(this.labelDonGia);
            this.GBThongTin.Controls.Add(this.txtTenThuoc);
            this.GBThongTin.Controls.Add(this.panel3);
            this.GBThongTin.Controls.Add(this.labelTenThuoc);
            this.GBThongTin.Controls.Add(this.txtMaThuoc);
            this.GBThongTin.Controls.Add(this.labelMaThuoc);
            this.GBThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBThongTin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GBThongTin.Location = new System.Drawing.Point(5, 5);
            this.GBThongTin.Name = "GBThongTin";
            this.GBThongTin.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.GBThongTin.Size = new System.Drawing.Size(790, 132);
            this.GBThongTin.TabIndex = 0;
            this.GBThongTin.TabStop = false;
            this.GBThongTin.Text = "Các Thông Tin Chi Tiết";
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(543, 68);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(40, 2);
            this.panel8.TabIndex = 5;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMoTa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoTa.ForeColor = System.Drawing.Color.White;
            this.txtMoTa.Location = new System.Drawing.Point(592, 49);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(159, 66);
            this.txtMoTa.TabIndex = 7;
            this.txtMoTa.Text = "đoán xem nè ";
            // 
            // labelMota
            // 
            this.labelMota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMota.AutoSize = true;
            this.labelMota.Location = new System.Drawing.Point(540, 49);
            this.labelMota.Name = "labelMota";
            this.labelMota.Size = new System.Drawing.Size(43, 17);
            this.labelMota.TabIndex = 3;
            this.labelMota.Text = "Mô tả";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(271, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 2);
            this.panel6.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuong.ForeColor = System.Drawing.Color.White;
            this.txtSoLuong.Location = new System.Drawing.Point(367, 46);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 16);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.Text = "đoán xem nè ";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(292, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 2);
            this.panel5.TabIndex = 5;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Location = new System.Drawing.Point(258, 46);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(69, 17);
            this.labelSoLuong.TabIndex = 3;
            this.labelSoLuong.Text = "Số Lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDonGia.ForeColor = System.Drawing.Color.White;
            this.txtDonGia.Location = new System.Drawing.Point(342, 86);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(124, 16);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.Text = "15.000 đ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(44, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 2);
            this.panel4.TabIndex = 5;
            // 
            // labelDonGia
            // 
            this.labelDonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Location = new System.Drawing.Point(261, 86);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(60, 17);
            this.labelDonGia.TabIndex = 3;
            this.labelDonGia.Text = "Đơn Giá";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtTenThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenThuoc.ForeColor = System.Drawing.Color.White;
            this.txtTenThuoc.Location = new System.Drawing.Point(94, 87);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(124, 16);
            this.txtTenThuoc.TabIndex = 1;
            this.txtTenThuoc.Text = "đoán xem nè ";
            this.txtTenThuoc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(46, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 2);
            this.panel3.TabIndex = 2;
            // 
            // labelTenThuoc
            // 
            this.labelTenThuoc.AutoSize = true;
            this.labelTenThuoc.Location = new System.Drawing.Point(13, 86);
            this.labelTenThuoc.Name = "labelTenThuoc";
            this.labelTenThuoc.Size = new System.Drawing.Size(77, 17);
            this.labelTenThuoc.TabIndex = 3;
            this.labelTenThuoc.Text = "Tên Thuốc";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtMaThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThuoc.ForeColor = System.Drawing.Color.White;
            this.txtMaThuoc.Location = new System.Drawing.Point(96, 46);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(124, 19);
            this.txtMaThuoc.TabIndex = 0;
            this.txtMaThuoc.Text = "T123";
            // 
            // labelMaThuoc
            // 
            this.labelMaThuoc.AutoSize = true;
            this.labelMaThuoc.Location = new System.Drawing.Point(15, 46);
            this.labelMaThuoc.Name = "labelMaThuoc";
            this.labelMaThuoc.Size = new System.Drawing.Size(75, 17);
            this.labelMaThuoc.TabIndex = 0;
            this.labelMaThuoc.Text = "Mã Thuốc ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgrvDanhMucThuoc);
            this.panel2.Controls.Add(this.panelMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 195);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(800, 255);
            this.panel2.TabIndex = 20;
            // 
            // dgrvDanhMucThuoc
            // 
            this.dgrvDanhMucThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvDanhMucThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvDanhMucThuoc.Location = new System.Drawing.Point(5, 42);
            this.dgrvDanhMucThuoc.Name = "dgrvDanhMucThuoc";
            this.dgrvDanhMucThuoc.Size = new System.Drawing.Size(790, 208);
            this.dgrvDanhMucThuoc.TabIndex = 0;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTieuDe);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SanPham";
            this.ShowIcon = false;
            this.Text = "Quản Lý Sản Phẩm";
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.GBThongTin.ResumeLayout(false);
            this.GBThongTin.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDanhMucThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHuy;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnLuu;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GBThongTin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgrvDanhMucThuoc;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label labelMota;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTenThuoc;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label labelMaThuoc;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton btnSua;
    }
}