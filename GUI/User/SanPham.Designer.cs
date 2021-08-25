
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.labelTieuDe = new System.Windows.Forms.Label();
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
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.dgvDanhMucThuoc = new System.Windows.Forms.DataGridView();
            this.dgvMaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTieuDe.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GBThongTin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 40;
            this.btnThem.Location = new System.Drawing.Point(5, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(189, 38);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm/Cập Nhật";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.panel8.Location = new System.Drawing.Point(543, 63);
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
            this.txtMoTa.Location = new System.Drawing.Point(592, 45);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(159, 20);
            this.txtMoTa.TabIndex = 7;
            this.txtMoTa.Text = "đoán xem nè ";
            // 
            // labelMota
            // 
            this.labelMota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMota.AutoSize = true;
            this.labelMota.Location = new System.Drawing.Point(543, 45);
            this.labelMota.Name = "labelMota";
            this.labelMota.Size = new System.Drawing.Size(51, 17);
            this.labelMota.TabIndex = 3;
            this.labelMota.Text = "Mô tả :";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(290, 63);
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
            this.txtSoLuong.Location = new System.Drawing.Point(333, 46);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 16);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.Text = "đoán xem nè ";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(290, 103);
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
            this.labelSoLuong.Size = new System.Drawing.Size(77, 17);
            this.labelSoLuong.TabIndex = 3;
            this.labelSoLuong.Text = "Số Lượng :";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDonGia.ForeColor = System.Drawing.Color.White;
            this.txtDonGia.Location = new System.Drawing.Point(333, 86);
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
            this.labelDonGia.Size = new System.Drawing.Size(68, 17);
            this.labelDonGia.TabIndex = 3;
            this.labelDonGia.Text = "Đơn Giá :";
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
            this.labelTenThuoc.Size = new System.Drawing.Size(85, 17);
            this.labelTenThuoc.TabIndex = 3;
            this.labelTenThuoc.Text = "Tên Thuốc :";
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
            this.labelMaThuoc.Size = new System.Drawing.Size(79, 17);
            this.labelMaThuoc.TabIndex = 0;
            this.labelMaThuoc.Text = "Mã Thuốc :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.dgvDanhMucThuoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 195);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(800, 255);
            this.panel2.TabIndex = 20;
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
            this.btnXoa.Location = new System.Drawing.Point(649, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(146, 45);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnReset.IconColor = System.Drawing.Color.White;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 40;
            this.btnReset.Location = new System.Drawing.Point(295, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(189, 44);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Tải Lại";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvDanhMucThuoc
            // 
            this.dgvDanhMucThuoc.AllowUserToAddRows = false;
            this.dgvDanhMucThuoc.AllowUserToDeleteRows = false;
            this.dgvDanhMucThuoc.AllowUserToResizeColumns = false;
            this.dgvDanhMucThuoc.AllowUserToResizeRows = false;
            this.dgvDanhMucThuoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDanhMucThuoc.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDanhMucThuoc.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvDanhMucThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaThuoc,
            this.dgvTenThuoc,
            this.dgvSoLuong,
            this.dgvDonGia,
            this.dgvMoTa});
            this.dgvDanhMucThuoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhMucThuoc.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDanhMucThuoc.Location = new System.Drawing.Point(5, 50);
            this.dgvDanhMucThuoc.Name = "dgvDanhMucThuoc";
            this.dgvDanhMucThuoc.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgvDanhMucThuoc.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhMucThuoc.Size = new System.Drawing.Size(790, 200);
            this.dgvDanhMucThuoc.TabIndex = 0;
            this.dgvDanhMucThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMucThuoc_CellClick);
            this.dgvDanhMucThuoc.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhMucThuoc_RowHeaderMouseClick);
            // 
            // dgvMaThuoc
            // 
            this.dgvMaThuoc.Frozen = true;
            this.dgvMaThuoc.HeaderText = "Mã Thuôc";
            this.dgvMaThuoc.Name = "dgvMaThuoc";
            this.dgvMaThuoc.ReadOnly = true;
            this.dgvMaThuoc.Width = 80;
            // 
            // dgvTenThuoc
            // 
            this.dgvTenThuoc.Frozen = true;
            this.dgvTenThuoc.HeaderText = "Tên Thuốc";
            this.dgvTenThuoc.Name = "dgvTenThuoc";
            this.dgvTenThuoc.ReadOnly = true;
            this.dgvTenThuoc.Width = 200;
            // 
            // dgvSoLuong
            // 
            this.dgvSoLuong.Frozen = true;
            this.dgvSoLuong.HeaderText = "Số Lượng";
            this.dgvSoLuong.Name = "dgvSoLuong";
            this.dgvSoLuong.ReadOnly = true;
            this.dgvSoLuong.Width = 110;
            // 
            // dgvDonGia
            // 
            this.dgvDonGia.Frozen = true;
            this.dgvDonGia.HeaderText = "Đơn Giá";
            this.dgvDonGia.Name = "dgvDonGia";
            this.dgvDonGia.ReadOnly = true;
            // 
            // dgvMoTa
            // 
            this.dgvMoTa.Frozen = true;
            this.dgvMoTa.HeaderText = "Mô Tả";
            this.dgvMoTa.Name = "dgvMoTa";
            this.dgvMoTa.ReadOnly = true;
            this.dgvMoTa.Width = 250;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.GBThongTin.ResumeLayout(false);
            this.GBThongTin.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Label labelTieuDe;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GBThongTin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhMucThuoc;
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
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMoTa;
    }
}