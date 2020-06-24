namespace ThuChi
{
    partial class userCtrl_DoanhThuThucCN
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.date_ChoseNgaySave = new System.Windows.Forms.DateTimePicker();
            this.txt_doanhthuID = new System.Windows.Forms.TextBox();
            this.bt_Save = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.date_ChoseNgaySave);
            this.panel2.Controls.Add(this.txt_doanhthuID);
            this.panel2.Controls.Add(this.bt_Save);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 106);
            this.panel2.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên Ca:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(521, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 44;
            // 
            // date_ChoseNgaySave
            // 
            this.date_ChoseNgaySave.CustomFormat = "d/M/yyyy";
            this.date_ChoseNgaySave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ChoseNgaySave.Location = new System.Drawing.Point(648, 53);
            this.date_ChoseNgaySave.Name = "date_ChoseNgaySave";
            this.date_ChoseNgaySave.Size = new System.Drawing.Size(142, 27);
            this.date_ChoseNgaySave.TabIndex = 43;
            this.date_ChoseNgaySave.ValueChanged += new System.EventHandler(this.date_ChoseNgaySave_ValueChanged);
            // 
            // txt_doanhthuID
            // 
            this.txt_doanhthuID.AutoCompleteCustomSource.AddRange(new string[] {
            "cp0",
            "cp1",
            "cp2",
            "cp3",
            "cp4",
            "cp5",
            "cp6",
            "cp7"});
            this.txt_doanhthuID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_doanhthuID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_doanhthuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doanhthuID.Location = new System.Drawing.Point(322, 52);
            this.txt_doanhthuID.Multiline = true;
            this.txt_doanhthuID.Name = "txt_doanhthuID";
            this.txt_doanhthuID.Size = new System.Drawing.Size(193, 28);
            this.txt_doanhthuID.TabIndex = 42;
            // 
            // bt_Save
            // 
            this.bt_Save.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_Save.Appearance.Options.UseBackColor = true;
            this.bt_Save.Location = new System.Drawing.Point(828, 49);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(104, 34);
            this.bt_Save.TabIndex = 34;
            this.bt_Save.Text = "Save";
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Doanh Thu ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 35);
            this.panel1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Tổng Doanh Thu Thực 1 Ngày";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 141);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1159, 529);
            this.gridControl1.TabIndex = 35;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // userCtrl_DoanhThuThucCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "userCtrl_DoanhThuThucCN";
            this.Size = new System.Drawing.Size(1159, 670);
            this.Load += new System.EventHandler(this.userCtrl_DoanhThuThucCN_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker date_ChoseNgaySave;
        private System.Windows.Forms.TextBox txt_doanhthuID;
        private DevExpress.XtraEditors.SimpleButton bt_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
