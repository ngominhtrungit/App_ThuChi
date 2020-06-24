namespace ThuChi.UserControl
{
    partial class userCtrl_TienConLaiCuoiCa
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_tenCa = new System.Windows.Forms.ComboBox();
            this.date_ChoseNgaySave = new System.Windows.Forms.DateTimePicker();
            this.txt_caID = new System.Windows.Forms.TextBox();
            this.bt_Save = new DevExpress.XtraEditors.SimpleButton();
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
            this.panel1.Size = new System.Drawing.Size(1344, 48);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khởi Tạo Doanh Thu Cuối Ca";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cb_tenCa);
            this.panel2.Controls.Add(this.date_ChoseNgaySave);
            this.panel2.Controls.Add(this.txt_caID);
            this.panel2.Controls.Add(this.bt_Save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 106);
            this.panel2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(660, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Chọn Ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên Ca:";
            // 
            // cb_tenCa
            // 
            this.cb_tenCa.FormattingEnabled = true;
            this.cb_tenCa.Location = new System.Drawing.Point(570, 48);
            this.cb_tenCa.Name = "cb_tenCa";
            this.cb_tenCa.Size = new System.Drawing.Size(83, 28);
            this.cb_tenCa.TabIndex = 44;
            this.cb_tenCa.SelectedIndexChanged += new System.EventHandler(this.cb_tenCa_SelectedIndexChanged);
            // 
            // date_ChoseNgaySave
            // 
            this.date_ChoseNgaySave.CustomFormat = "d/M/yyyy";
            this.date_ChoseNgaySave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ChoseNgaySave.Location = new System.Drawing.Point(659, 49);
            this.date_ChoseNgaySave.Name = "date_ChoseNgaySave";
            this.date_ChoseNgaySave.Size = new System.Drawing.Size(128, 27);
            this.date_ChoseNgaySave.TabIndex = 43;
            this.date_ChoseNgaySave.ValueChanged += new System.EventHandler(this.date_ChoseNgaySave_ValueChanged);
            // 
            // txt_caID
            // 
            this.txt_caID.AutoCompleteCustomSource.AddRange(new string[] {
            "cp0",
            "cp1",
            "cp2",
            "cp3",
            "cp4",
            "cp5",
            "cp6",
            "cp7"});
            this.txt_caID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_caID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_caID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_caID.Location = new System.Drawing.Point(481, 48);
            this.txt_caID.Multiline = true;
            this.txt_caID.Name = "txt_caID";
            this.txt_caID.ReadOnly = true;
            this.txt_caID.Size = new System.Drawing.Size(83, 28);
            this.txt_caID.TabIndex = 42;
            // 
            // bt_Save
            // 
            this.bt_Save.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_Save.Appearance.Options.UseBackColor = true;
            this.bt_Save.Location = new System.Drawing.Point(793, 45);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(104, 34);
            this.bt_Save.TabIndex = 34;
            this.bt_Save.Text = "Save";
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 154);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1344, 679);
            this.gridControl1.TabIndex = 36;
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
            // userCtrl_TienConLaiCuoiCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "userCtrl_TienConLaiCuoiCa";
            this.Size = new System.Drawing.Size(1344, 833);
            this.Load += new System.EventHandler(this.userCtrl_TienConLaiCuoiCa_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_tenCa;
        private System.Windows.Forms.DateTimePicker date_ChoseNgaySave;
        private System.Windows.Forms.TextBox txt_caID;
        private DevExpress.XtraEditors.SimpleButton bt_Save;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
