
namespace QLTT.Common
{
    partial class DangNhap
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
            this.panelDangNhap = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.IconMatKhau = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconDangNhap = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new FontAwesome.Sharp.IconButton();
            this.labelDangNhap = new System.Windows.Forms.Label();
            this.ThongTinNSX = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDangNhap
            // 
            this.panelDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDangNhap.Controls.Add(this.label2);
            this.panelDangNhap.Controls.Add(this.IconMatKhau);
            this.panelDangNhap.Controls.Add(this.label1);
            this.panelDangNhap.Controls.Add(this.txtMatKhau);
            this.panelDangNhap.Controls.Add(this.panel3);
            this.panelDangNhap.Controls.Add(this.iconDangNhap);
            this.panelDangNhap.Controls.Add(this.panel2);
            this.panelDangNhap.Controls.Add(this.Logo);
            this.panelDangNhap.Controls.Add(this.txtEmail);
            this.panelDangNhap.Controls.Add(this.btnDangNhap);
            this.panelDangNhap.Controls.Add(this.labelDangNhap);
            this.panelDangNhap.Location = new System.Drawing.Point(12, 69);
            this.panelDangNhap.Name = "panelDangNhap";
            this.panelDangNhap.Size = new System.Drawing.Size(408, 417);
            this.panelDangNhap.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(122, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email";
            // 
            // IconMatKhau
            // 
            this.IconMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IconMatKhau.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.IconMatKhau.IconColor = System.Drawing.Color.White;
            this.IconMatKhau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconMatKhau.IconSize = 35;
            this.IconMatKhau.Location = new System.Drawing.Point(84, 263);
            this.IconMatKhau.Name = "IconMatKhau";
            this.IconMatKhau.Size = new System.Drawing.Size(40, 35);
            this.IconMatKhau.TabIndex = 12;
            this.IconMatKhau.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(122, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mật Khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Gray;
            this.txtMatKhau.Location = new System.Drawing.Point(126, 274);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(186, 24);
            this.txtMatKhau.TabIndex = 11;
            this.txtMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhau_Validating);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(97, 304);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 10;
            // 
            // iconDangNhap
            // 
            this.iconDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconDangNhap.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconDangNhap.IconColor = System.Drawing.Color.White;
            this.iconDangNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDangNhap.IconSize = 35;
            this.iconDangNhap.Location = new System.Drawing.Point(84, 207);
            this.iconDangNhap.Name = "iconDangNhap";
            this.iconDangNhap.Size = new System.Drawing.Size(40, 35);
            this.iconDangNhap.TabIndex = 7;
            this.iconDangNhap.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(101, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Logo.Image = global::QLTT.Properties.Resources.LogoFinal2;
            this.Logo.Location = new System.Drawing.Point(84, 22);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(248, 115);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.HideSelection = false;
            this.txtEmail.Location = new System.Drawing.Point(126, 211);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 24);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtTaiKhoan_Validating);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnDangNhap.IconColor = System.Drawing.Color.White;
            this.btnDangNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangNhap.IconSize = 40;
            this.btnDangNhap.Location = new System.Drawing.Point(119, 354);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(169, 37);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // labelDangNhap
            // 
            this.labelDangNhap.AutoSize = true;
            this.labelDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDangNhap.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDangNhap.ForeColor = System.Drawing.Color.White;
            this.labelDangNhap.Location = new System.Drawing.Point(115, 140);
            this.labelDangNhap.Name = "labelDangNhap";
            this.labelDangNhap.Size = new System.Drawing.Size(173, 40);
            this.labelDangNhap.TabIndex = 0;
            this.labelDangNhap.Text = "Đăng Nhập";
            // 
            // ThongTinNSX
            // 
            this.ThongTinNSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ThongTinNSX.AutoSize = true;
            this.ThongTinNSX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ThongTinNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongTinNSX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ThongTinNSX.Location = new System.Drawing.Point(197, 532);
            this.ThongTinNSX.Name = "ThongTinNSX";
            this.ThongTinNSX.Size = new System.Drawing.Size(221, 20);
            this.ThongTinNSX.TabIndex = 9;
            this.ThongTinNSX.Text = "Power by Gà Mờ Tập Code";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(103)))));
            this.BackgroundImage = global::QLTT.Properties.Resources.banner1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(429, 561);
            this.Controls.Add(this.ThongTinNSX);
            this.Controls.Add(this.panelDangNhap);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(445, 600);
            this.Name = "DangNhap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelDangNhap.ResumeLayout(false);
            this.panelDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDangNhap;
        private System.Windows.Forms.TextBox txtEmail;
        private FontAwesome.Sharp.IconButton btnDangNhap;
        private System.Windows.Forms.Label labelDangNhap;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconDangNhap;
        private System.Windows.Forms.Label ThongTinNSX;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox IconMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Panel panel3;
    }
}