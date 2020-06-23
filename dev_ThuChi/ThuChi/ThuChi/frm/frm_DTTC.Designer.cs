namespace ThuChi.frm
{
    partial class frm_DTTC
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
            this.userCtrl_DoanhThuTheoCa1 = new ThuChi.UserControl.userCtrl_DoanhThuTheoCa();
            this.SuspendLayout();
            // 
            // userCtrl_DoanhThuTheoCa1
            // 
            this.userCtrl_DoanhThuTheoCa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrl_DoanhThuTheoCa1.Location = new System.Drawing.Point(0, 0);
            this.userCtrl_DoanhThuTheoCa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userCtrl_DoanhThuTheoCa1.Name = "userCtrl_DoanhThuTheoCa1";
            this.userCtrl_DoanhThuTheoCa1.Size = new System.Drawing.Size(1151, 644);
            this.userCtrl_DoanhThuTheoCa1.TabIndex = 0;
            // 
            // frm_DTTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 644);
            this.Controls.Add(this.userCtrl_DoanhThuTheoCa1);
            this.Name = "frm_DTTC";
            this.Text = "frm_DTTC";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.userCtrl_DoanhThuTheoCa userCtrl_DoanhThuTheoCa1;
    }
}