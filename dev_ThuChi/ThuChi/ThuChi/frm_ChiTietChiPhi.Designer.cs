namespace ThuChi
{
    partial class frm_ChiTietChiPhi
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
            this.userCtrl_CTCP1 = new ThuChi.userCtrl_CTCP();
            this.SuspendLayout();
            // 
            // userCtrl_CTCP1
            // 
            this.userCtrl_CTCP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrl_CTCP1.Location = new System.Drawing.Point(0, 0);
            this.userCtrl_CTCP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userCtrl_CTCP1.Name = "userCtrl_CTCP1";
            this.userCtrl_CTCP1.Size = new System.Drawing.Size(913, 558);
            this.userCtrl_CTCP1.TabIndex = 0;
            // 
            // frm_ChiTietChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 558);
            this.Controls.Add(this.userCtrl_CTCP1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_ChiTietChiPhi";
            this.Text = "frm_ChiTietChiPhi";
            this.ResumeLayout(false);

        }

        #endregion

        private userCtrl_CTCP userCtrl_CTCP1;
    }
}