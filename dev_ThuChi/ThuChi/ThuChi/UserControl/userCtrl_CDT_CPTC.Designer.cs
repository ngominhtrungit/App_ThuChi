namespace ThuChi.UserControl
{
    partial class userCtrl_CDT_CPTC
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
            this.label6 = new System.Windows.Forms.Label();
            this.date_ChoseNgayCp = new System.Windows.Forms.DateTimePicker();
            this.cb_TenCa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ChoseTen = new System.Windows.Forms.ComboBox();
            this.txt_soTienLay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cdtID = new System.Windows.Forms.TextBox();
            this.txt_chiphitcID = new System.Windows.Forms.TextBox();
            this.bt_Save = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1545, 34);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo chi tiết Chủ Đầu Tư Nhận Tiền";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.date_ChoseNgayCp);
            this.panel2.Controls.Add(this.cb_TenCa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cb_ChoseTen);
            this.panel2.Controls.Add(this.txt_soTienLay);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_cdtID);
            this.panel2.Controls.Add(this.txt_chiphitcID);
            this.panel2.Controls.Add(this.bt_Save);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1545, 249);
            this.panel2.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(633, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tên Ca:";
            // 
            // date_ChoseNgayCp
            // 
            this.date_ChoseNgayCp.CustomFormat = "d/M/yyyy";
            this.date_ChoseNgayCp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ChoseNgayCp.Location = new System.Drawing.Point(726, 110);
            this.date_ChoseNgayCp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_ChoseNgayCp.Name = "date_ChoseNgayCp";
            this.date_ChoseNgayCp.Size = new System.Drawing.Size(128, 27);
            this.date_ChoseNgayCp.TabIndex = 48;
            this.date_ChoseNgayCp.ValueChanged += new System.EventHandler(this.date_ChoseNgayCp_ValueChanged);
            // 
            // cb_TenCa
            // 
            this.cb_TenCa.FormattingEnabled = true;
            this.cb_TenCa.Location = new System.Drawing.Point(633, 107);
            this.cb_TenCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_TenCa.Name = "cb_TenCa";
            this.cb_TenCa.Size = new System.Drawing.Size(84, 28);
            this.cb_TenCa.TabIndex = 47;
            this.cb_TenCa.SelectedIndexChanged += new System.EventHandler(this.cb_TenCa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(633, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Chọn tên CĐT:";
            // 
            // cb_ChoseTen
            // 
            this.cb_ChoseTen.FormattingEnabled = true;
            this.cb_ChoseTen.Location = new System.Drawing.Point(633, 34);
            this.cb_ChoseTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_ChoseTen.Name = "cb_ChoseTen";
            this.cb_ChoseTen.Size = new System.Drawing.Size(114, 28);
            this.cb_ChoseTen.TabIndex = 45;
            this.cb_ChoseTen.SelectedIndexChanged += new System.EventHandler(this.cb_ChoseTen_SelectedIndexChanged);
            // 
            // txt_soTienLay
            // 
            this.txt_soTienLay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soTienLay.Location = new System.Drawing.Point(530, 142);
            this.txt_soTienLay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_soTienLay.Multiline = true;
            this.txt_soTienLay.Name = "txt_soTienLay";
            this.txt_soTienLay.Size = new System.Drawing.Size(193, 29);
            this.txt_soTienLay.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Số tiền lấy:";
            // 
            // txt_cdtID
            // 
            this.txt_cdtID.AutoCompleteCustomSource.AddRange(new string[] {
            "cp0",
            "cp1",
            "cp2",
            "cp3",
            "cp4",
            "cp5",
            "cp6",
            "cp7"});
            this.txt_cdtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_cdtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cdtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cdtID.Location = new System.Drawing.Point(530, 34);
            this.txt_cdtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cdtID.Multiline = true;
            this.txt_cdtID.Name = "txt_cdtID";
            this.txt_cdtID.ReadOnly = true;
            this.txt_cdtID.Size = new System.Drawing.Size(98, 29);
            this.txt_cdtID.TabIndex = 42;
            // 
            // txt_chiphitcID
            // 
            this.txt_chiphitcID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chiphitcID.Location = new System.Drawing.Point(530, 107);
            this.txt_chiphitcID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_chiphitcID.Multiline = true;
            this.txt_chiphitcID.Name = "txt_chiphitcID";
            this.txt_chiphitcID.ReadOnly = true;
            this.txt_chiphitcID.Size = new System.Drawing.Size(98, 29);
            this.txt_chiphitcID.TabIndex = 40;
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(765, 172);
            this.bt_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(104, 34);
            this.bt_Save.TabIndex = 34;
            this.bt_Save.Text = "Save";
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "chiphitc ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "cdt ID:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 283);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1545, 698);
            this.gridControl1.TabIndex = 34;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // userCtrl_CDT_CPTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "userCtrl_CDT_CPTC";
            this.Size = new System.Drawing.Size(1545, 981);
            this.Load += new System.EventHandler(this.userCtrl_CDT_CPTC_Load);
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
        private System.Windows.Forms.TextBox txt_soTienLay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cdtID;
        private System.Windows.Forms.TextBox txt_chiphitcID;
        private DevExpress.XtraEditors.SimpleButton bt_Save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_ChoseTen;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_ChoseNgayCp;
        private System.Windows.Forms.ComboBox cb_TenCa;
        private System.Windows.Forms.Label label6;
    }
}
