
namespace QLTT.Controls
{
    partial class QuanLyNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNoiDung = new System.Windows.Forms.Panel();
            this.dgv_NV = new System.Windows.Forms.DataGridView();
            this.dgvMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSapXep = new System.Windows.Forms.Panel();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMailNV = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.labelTênNV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).BeginInit();
            this.panelSapXep.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            this.panelTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.Controls.Add(this.dgv_NV);
            this.panelNoiDung.Controls.Add(this.panelSapXep);
            this.panelNoiDung.Controls.Add(this.panelChucNang);
            this.panelNoiDung.Controls.Add(this.panelTieuDe);
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 0);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Padding = new System.Windows.Forms.Padding(6);
            this.panelNoiDung.Size = new System.Drawing.Size(816, 583);
            this.panelNoiDung.TabIndex = 2;
            this.panelNoiDung.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNoiDung_Paint);
            // 
            // dgv_NV
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgv_NV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaNV,
            this.dgvTenNV,
            this.dgvNS,
            this.dgvSDT,
            this.dgvEmail,
            this.dgvMK,
            this.dgvRole});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NV.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_NV.Location = new System.Drawing.Point(6, 341);
            this.dgv_NV.Name = "dgv_NV";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgv_NV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_NV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NV.Size = new System.Drawing.Size(804, 233);
            this.dgv_NV.TabIndex = 6;
            this.dgv_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NV_CellClick);
            // 
            // dgvMaNV
            // 
            this.dgvMaNV.HeaderText = "Mã Nhân Viên";
            this.dgvMaNV.Name = "dgvMaNV";
            // 
            // dgvTenNV
            // 
            this.dgvTenNV.HeaderText = "Tên Nhân Viên";
            this.dgvTenNV.Name = "dgvTenNV";
            this.dgvTenNV.Width = 150;
            // 
            // dgvNS
            // 
            this.dgvNS.HeaderText = "Ngày Sinh";
            this.dgvNS.Name = "dgvNS";
            // 
            // dgvSDT
            // 
            this.dgvSDT.HeaderText = "Số ĐIện Thoại";
            this.dgvSDT.Name = "dgvSDT";
            // 
            // dgvEmail
            // 
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.Width = 130;
            // 
            // dgvMK
            // 
            this.dgvMK.HeaderText = "Mật Khẩu";
            this.dgvMK.Name = "dgvMK";
            // 
            // dgvRole
            // 
            this.dgvRole.HeaderText = "Quyền";
            this.dgvRole.Name = "dgvRole";
            // 
            // panelSapXep
            // 
            this.panelSapXep.Controls.Add(this.label6);
            this.panelSapXep.Controls.Add(this.btnTimKiem);
            this.panelSapXep.Controls.Add(this.txtTimKiem);
            this.panelSapXep.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSapXep.Location = new System.Drawing.Point(6, 286);
            this.panelSapXep.Name = "panelSapXep";
            this.panelSapXep.Size = new System.Drawing.Size(804, 49);
            this.panelSapXep.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.White;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 35;
            this.btnTimKiem.Location = new System.Drawing.Point(749, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(54, 30);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(557, 7);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(196, 23);
            this.txtTimKiem.TabIndex = 16;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.panel1);
            this.panelChucNang.Controls.Add(this.txt_MK);
            this.panelChucNang.Controls.Add(this.label5);
            this.panelChucNang.Controls.Add(this.btnSua);
            this.panelChucNang.Controls.Add(this.chkAdmin);
            this.panelChucNang.Controls.Add(this.label1);
            this.panelChucNang.Controls.Add(this.dtpNgaySinh);
            this.panelChucNang.Controls.Add(this.panel5);
            this.panelChucNang.Controls.Add(this.label4);
            this.panelChucNang.Controls.Add(this.txtMailNV);
            this.panelChucNang.Controls.Add(this.panel4);
            this.panelChucNang.Controls.Add(this.label3);
            this.panelChucNang.Controls.Add(this.txtSDT);
            this.panelChucNang.Controls.Add(this.panel3);
            this.panelChucNang.Controls.Add(this.label2);
            this.panelChucNang.Controls.Add(this.txtTenNV);
            this.panelChucNang.Controls.Add(this.labelTênNV);
            this.panelChucNang.Controls.Add(this.panel2);
            this.panelChucNang.Controls.Add(this.txtMaNV);
            this.panelChucNang.Controls.Add(this.labelMaNV);
            this.panelChucNang.Controls.Add(this.btnReset);
            this.panelChucNang.Controls.Add(this.btnThem);
            this.panelChucNang.Controls.Add(this.btnXoa);
            this.panelChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChucNang.Location = new System.Drawing.Point(6, 55);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(804, 231);
            this.panelChucNang.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(346, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 23;
            // 
            // txt_MK
            // 
            this.txt_MK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txt_MK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK.ForeColor = System.Drawing.Color.White;
            this.txt_MK.Location = new System.Drawing.Point(381, 92);
            this.txt_MK.Multiline = true;
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(169, 20);
            this.txt_MK.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mật Khẩu:";
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
            this.btnSua.Location = new System.Drawing.Point(635, 128);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // chkAdmin
            // 
            this.chkAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmin.Location = new System.Drawing.Point(177, 201);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(15, 14);
            this.chkAdmin.TabIndex = 19;
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cấp Quyền Admin :";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(400, 139);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(146, 20);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(346, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 2);
            this.panel5.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày Sinh : ";
            // 
            // txtMailNV
            // 
            this.txtMailNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMailNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtMailNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMailNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailNV.ForeColor = System.Drawing.Color.White;
            this.txtMailNV.Location = new System.Drawing.Point(381, 43);
            this.txtMailNV.Multiline = true;
            this.txtMailNV.Name = "txtMailNV";
            this.txtMailNV.Size = new System.Drawing.Size(169, 20);
            this.txtMailNV.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(53, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 2);
            this.panel4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email : ";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.White;
            this.txtSDT.Location = new System.Drawing.Point(139, 159);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(109, 20);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(56, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số Điện Thoại : ";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.White;
            this.txtTenNV.Location = new System.Drawing.Point(144, 109);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(109, 20);
            this.txtTenNV.TabIndex = 1;
            // 
            // labelTênNV
            // 
            this.labelTênNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTênNV.AutoSize = true;
            this.labelTênNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTênNV.Location = new System.Drawing.Point(26, 110);
            this.labelTênNV.Name = "labelTênNV";
            this.labelTênNV.Size = new System.Drawing.Size(126, 20);
            this.labelTênNV.TabIndex = 13;
            this.labelTênNV.Text = "Tên Nhân Viên : ";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(56, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 12;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.White;
            this.txtMaNV.Location = new System.Drawing.Point(141, 46);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(109, 20);
            this.txtMaNV.TabIndex = 0;
            // 
            // labelMaNV
            // 
            this.labelMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Enabled = false;
            this.labelMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNV.Location = new System.Drawing.Point(26, 47);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(121, 20);
            this.labelMaNV.TabIndex = 10;
            this.labelMaNV.Text = "Mã Nhân Viên : ";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnReset.IconColor = System.Drawing.Color.White;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 40;
            this.btnReset.Location = new System.Drawing.Point(635, 180);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 35);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnThem.Location = new System.Drawing.Point(624, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(635, 77);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.Controls.Add(this.labelTieuDe);
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Location = new System.Drawing.Point(6, 6);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelTieuDe.Size = new System.Drawing.Size(804, 49);
            this.panelTieuDe.TabIndex = 0;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieuDe.Location = new System.Drawing.Point(315, 12);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(219, 26);
            this.labelTieuDe.TabIndex = 0;
            this.labelTieuDe.Text = "Quản Lý Nhân Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nhập tên NV bạn muốn tìm";
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(816, 583);
            this.Controls.Add(this.panelNoiDung);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "QuanLyNhanVien";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.panelNoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).EndInit();
            this.panelSapXep.ResumeLayout(false);
            this.panelSapXep.PerformLayout();
            this.panelChucNang.ResumeLayout(false);
            this.panelChucNang.PerformLayout();
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNoiDung;
        private System.Windows.Forms.Panel panelTieuDe;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Panel panelChucNang;
        private FontAwesome.Sharp.IconButton btnReset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMailNV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label labelTênNV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSapXep;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgv_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRole;
        private FontAwesome.Sharp.IconButton btnSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}