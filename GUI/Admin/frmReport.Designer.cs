
namespace QLTT.GUI.Admin
{
    partial class frmReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_in = new System.Windows.Forms.Button();
            this.txt_MHD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(128, 150);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(561, 287);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(300, 54);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(199, 59);
            this.btn_in.TabIndex = 1;
            this.btn_in.Text = "button1";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // txt_MHD
            // 
            this.txt_MHD.Location = new System.Drawing.Point(66, 27);
            this.txt_MHD.Name = "txt_MHD";
            this.txt_MHD.Size = new System.Drawing.Size(110, 20);
            this.txt_MHD.TabIndex = 2;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 460);
            this.Controls.Add(this.txt_MHD);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.TextBox txt_MHD;
    }
}