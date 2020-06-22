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
            this.cb_ChoseTen = new System.Windows.Forms.ComboBox();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cdtID = new System.Windows.Forms.TextBox();
            this.txt_chiphitcID = new System.Windows.Forms.TextBox();
            this.bt_Save = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_TenCa = new System.Windows.Forms.ComboBox();
            this.date_ChoseNgayCp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(1324, 28);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 25);
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
            this.panel2.Controls.Add(this.txt_dc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_cdtID);
            this.panel2.Controls.Add(this.txt_chiphitcID);
            this.panel2.Controls.Add(this.bt_Save);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1324, 202);
            this.panel2.TabIndex = 33;
            // 
            // cb_ChoseTen
            // 
            this.cb_ChoseTen.FormattingEnabled = true;
            this.cb_ChoseTen.Location = new System.Drawing.Point(543, 28);
            this.cb_ChoseTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_ChoseTen.Name = "cb_ChoseTen";
            this.cb_ChoseTen.Size = new System.Drawing.Size(98, 25);
            this.cb_ChoseTen.TabIndex = 45;
            this.cb_ChoseTen.SelectedIndexChanged += new System.EventHandler(this.cb_ChoseTen_SelectedIndexChanged);
            // 
            // txt_dc
            // 
            this.txt_dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dc.Location = new System.Drawing.Point(454, 115);
            this.txt_dc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dc.Multiline = true;
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(166, 24);
            this.txt_dc.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
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
            this.txt_cdtID.Location = new System.Drawing.Point(454, 28);
            this.txt_cdtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cdtID.Multiline = true;
            this.txt_cdtID.Name = "txt_cdtID";
            this.txt_cdtID.ReadOnly = true;
            this.txt_cdtID.Size = new System.Drawing.Size(85, 24);
            this.txt_cdtID.TabIndex = 42;
            // 
            // txt_chiphitcID
            // 
            this.txt_chiphitcID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chiphitcID.Location = new System.Drawing.Point(454, 87);
            this.txt_chiphitcID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_chiphitcID.Multiline = true;
            this.txt_chiphitcID.Name = "txt_chiphitcID";
            this.txt_chiphitcID.ReadOnly = true;
            this.txt_chiphitcID.Size = new System.Drawing.Size(85, 24);
            this.txt_chiphitcID.TabIndex = 40;
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(656, 140);
            this.bt_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(89, 28);
            this.bt_Save.TabIndex = 34;
            this.bt_Save.Text = "Save";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "chiphitc ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "cdt ID:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 230);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1324, 567);
            this.gridControl1.TabIndex = 34;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Chọn tên CĐT:";
            // 
            // cb_TenCa
            // 
            this.cb_TenCa.FormattingEnabled = true;
            this.cb_TenCa.Location = new System.Drawing.Point(543, 87);
            this.cb_TenCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_TenCa.Name = "cb_TenCa";
            this.cb_TenCa.Size = new System.Drawing.Size(73, 25);
            this.cb_TenCa.TabIndex = 47;
            this.cb_TenCa.SelectedIndexChanged += new System.EventHandler(this.cb_TenCa_SelectedIndexChanged);
            // 
            // date_ChoseNgayCp
            // 
            this.date_ChoseNgayCp.CustomFormat = "d/M/yyyy";
            this.date_ChoseNgayCp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ChoseNgayCp.Location = new System.Drawing.Point(622, 89);
            this.date_ChoseNgayCp.Name = "date_ChoseNgayCp";
            this.date_ChoseNgayCp.Size = new System.Drawing.Size(110, 23);
            this.date_ChoseNgayCp.TabIndex = 48;
            this.date_ChoseNgayCp.ValueChanged += new System.EventHandler(this.date_ChoseNgayCp_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(543, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tên Ca:";
            // 
            // userCtrl_CDT_CPTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "userCtrl_CDT_CPTC";
            this.Size = new System.Drawing.Size(1324, 797);
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
        private System.Windows.Forms.TextBox txt_dc;
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
