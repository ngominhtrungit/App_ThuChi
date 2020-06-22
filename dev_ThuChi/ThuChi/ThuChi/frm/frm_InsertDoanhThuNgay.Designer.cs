namespace ThuChi.frm
{
    partial class frm_InsertDoanhThuNgay
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
            this.userCtrl_DoanhThu1 = new ThuChi.UserControl.userCtrl_DoanhThu();
            this.SuspendLayout();
            // 
            // userCtrl_DoanhThu1
            // 
            this.userCtrl_DoanhThu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrl_DoanhThu1.Location = new System.Drawing.Point(0, 0);
            this.userCtrl_DoanhThu1.Name = "userCtrl_DoanhThu1";
            this.userCtrl_DoanhThu1.Size = new System.Drawing.Size(1257, 588);
            this.userCtrl_DoanhThu1.TabIndex = 0;
            // 
            // frm_InsertDoanhThuNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 588);
            this.Controls.Add(this.userCtrl_DoanhThu1);
            this.Name = "frm_InsertDoanhThuNgay";
            this.Text = "frm_InsertDoanhThuNgay";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.userCtrl_DoanhThu userCtrl_DoanhThu1;
    }
}