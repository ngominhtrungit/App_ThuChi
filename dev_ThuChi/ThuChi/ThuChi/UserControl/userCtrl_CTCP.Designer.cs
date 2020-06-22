namespace ThuChi
{
    partial class userCtrl_CTCP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.date_ChoseNgayTen = new System.Windows.Forms.DateTimePicker();
            this.txt_chiphitcID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.cb_dVT = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_moTa = new System.Windows.Forms.TextBox();
            this.cb_tenCa = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 53);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo, chỉnh sửa Chi Tiết Chi Phí";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.date_ChoseNgayTen);
            this.panel2.Controls.Add(this.txt_chiphitcID);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_donGia);
            this.panel2.Controls.Add(this.cb_dVT);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_SL);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txt_moTa);
            this.panel2.Controls.Add(this.cb_tenCa);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.bt_save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 177);
            this.panel2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(494, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tên Ca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(566, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Chọn ngày:";
            // 
            // date_ChoseNgayTen
            // 
            this.date_ChoseNgayTen.CustomFormat = "d/M/yyyy";
            this.date_ChoseNgayTen.Font = new System.Drawing.Font("Tahoma", 10F);
            this.date_ChoseNgayTen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ChoseNgayTen.Location = new System.Drawing.Point(566, 36);
            this.date_ChoseNgayTen.Name = "date_ChoseNgayTen";
            this.date_ChoseNgayTen.Size = new System.Drawing.Size(118, 28);
            this.date_ChoseNgayTen.TabIndex = 31;
            this.date_ChoseNgayTen.ValueChanged += new System.EventHandler(this.date_ChoseNgayTen_ValueChanged);
            this.date_ChoseNgayTen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.date_ChoseNgayTen_MouseUp);
            // 
            // txt_chiphitcID
            // 
            this.txt_chiphitcID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chiphitcID.Location = new System.Drawing.Point(380, 36);
            this.txt_chiphitcID.Name = "txt_chiphitcID";
            this.txt_chiphitcID.ReadOnly = true;
            this.txt_chiphitcID.Size = new System.Drawing.Size(107, 28);
            this.txt_chiphitcID.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Đơn Giá:";
            // 
            // txt_donGia
            // 
            this.txt_donGia.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donGia.Location = new System.Drawing.Point(380, 105);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(107, 28);
            this.txt_donGia.TabIndex = 28;
            // 
            // cb_dVT
            // 
            this.cb_dVT.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dVT.FormattingEnabled = true;
            this.cb_dVT.Location = new System.Drawing.Point(566, 126);
            this.cb_dVT.Name = "cb_dVT";
            this.cb_dVT.Size = new System.Drawing.Size(63, 29);
            this.cb_dVT.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(304, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Số Lượng:";
            // 
            // txt_SL
            // 
            this.txt_SL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Location = new System.Drawing.Point(380, 71);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(107, 28);
            this.txt_SL.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(521, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "DVT:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(513, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Mô Tả:";
            // 
            // txt_moTa
            // 
            this.txt_moTa.Location = new System.Drawing.Point(566, 71);
            this.txt_moTa.Multiline = true;
            this.txt_moTa.Name = "txt_moTa";
            this.txt_moTa.Size = new System.Drawing.Size(246, 55);
            this.txt_moTa.TabIndex = 22;
            // 
            // cb_tenCa
            // 
            this.cb_tenCa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tenCa.FormattingEnabled = true;
            this.cb_tenCa.Location = new System.Drawing.Point(493, 36);
            this.cb_tenCa.Name = "cb_tenCa";
            this.cb_tenCa.Size = new System.Drawing.Size(67, 29);
            this.cb_tenCa.TabIndex = 21;
            this.cb_tenCa.SelectedIndexChanged += new System.EventHandler(this.cb_tenCa_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(302, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Chi Phí ID:";
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_save.Location = new System.Drawing.Point(813, 126);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(110, 35);
            this.bt_save.TabIndex = 12;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 230);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1190, 473);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // userCtrl_CTCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "userCtrl_CTCP";
            this.Size = new System.Drawing.Size(1190, 703);
            this.Load += new System.EventHandler(this.userCtrl_CTCP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_save;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_ChoseNgayTen;
        private System.Windows.Forms.TextBox txt_chiphitcID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.ComboBox cb_dVT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_moTa;
        private System.Windows.Forms.ComboBox cb_tenCa;
        private System.Windows.Forms.Label label14;
    }
}
