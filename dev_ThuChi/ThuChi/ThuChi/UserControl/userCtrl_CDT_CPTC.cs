using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ThuChi.DAO;
using ThuChi.Class;
using System.Globalization;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;

namespace ThuChi.UserControl
{
    public partial class userCtrl_CDT_CPTC : DevExpress.XtraEditors.XtraUserControl
    {
        public userCtrl_CDT_CPTC()
        {
            InitializeComponent();
        }

        //chose item in comboBox
        private void cb_ChoseTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cdtID.Clear();
            DataProvider.Instance.ChoseComboBoxChangeTextBox_cdtID(cb_ChoseTen,txt_cdtID);
        }

        private void userCtrl_CDT_CPTC_Load(object sender, EventArgs e)
        {
            LoadCTCDT_CPTC();
            LoadTenCDTtoComboBox();
        }


        public void LoadCTCDT_CPTC()
        {
            string query = "exec [dbo].[proc_ShowCDT_CPTC]";
            gridControl1.DataSource= DataProvider.Instance.ExecuteQuery(query);

            CultureInfo cultureInfo = new CultureInfo("vi-VN");

            //for mat số tiền lấy thành vnd
            if (gridView1.Columns.Count > 1)
            {
                gridView1.Columns[6].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns[6].DisplayFormat.FormatString = "#,###";
                //string a = double.Parse("12345").ToString("#,###", cultureInfo.NumberFormat);
            }
            DisableEditColumnsGridView.CustomEditColumnsGridView(gridView1, new int[] { 0,1,2,3,4,5 });

        }

        private void LoadTenCDTtoComboBox()
        {
            DataProvider.Instance.LoadCB_tenCDT(cb_ChoseTen);
        }

        private void date_ChoseNgayCp_ValueChanged(object sender, EventArgs e)
        {
            cb_TenCa.Items.Clear();
            cb_TenCa.Text = "";
            LoadtenCatoComboBox();
        }

        private void LoadtenCatoComboBox()
        {
            DataProvider.Instance.LoadCB_tenCa_by_NgayTaoCP(date_ChoseNgayCp.Value.ToString(), cb_TenCa) ;
        }

        private void cb_TenCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider.Instance.ChoseComboBoxChangeTextBox_CPtcID_by_TenNgayCP(date_ChoseNgayCp.Value, cb_TenCa, txt_chiphitcID);

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            string query = "exec [dbo].[proc_insertCDTChiPhiTheoCa] @cdtID , @chiphitcID , @sotienlay ";
            DataProvider.Instance.ExecuteQuery(query,new object[] { txt_cdtID.Text,txt_chiphitcID.Text,txt_soTienLay.Text });
            LoadCTCDT_CPTC();
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int ctcdtID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]);
            int cdtID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]);
            int chiphitcID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]);
            string ngay = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            DateTime dt = DateTime.Parse(ngay, new CultureInfo("en-CA"));

            string tenCa = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
            string tenCDT = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString();
            float sotienlay = float.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]).ToString());
            try
            {
                if (MessageBox.Show(" Bạn có muốn Update CDT: '"+tenCDT+"' '"+dt.ToString("d/M/yyyy")+"', thuộc '"+tenCa+"' không?", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query1 = "exec [dbo].[proc_UpdateCDT_CPTheoCa] @ctcdtID , @cdtID , @chiphitcID , @sotienlay ";
                    DataProvider.Instance.ExecuteQuery(query1, new object[] { ctcdtID, cdtID, chiphitcID, sotienlay.ToString()});
                    AutoCloseMessageBox.Show("Update CDT: '" + tenCDT + "' '" + dt.ToString("d/M/yyyy") + "', thuộc '" + tenCa + "' thành công!", "Thông Báo!!", 1000);
                }
                LoadCTCDT_CPTC();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi không Update CDT: '" + tenCDT + "' '" + dt.ToString("d/M/yyyy") + "', thuộc '" + tenCa + "' được! Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gridView1.CloseEditor();
                gridView1.UpdateCurrentRow();
                e.Handled = true;
            }
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string priority = View.GetRowCellDisplayText(e.RowHandle, View.Columns["sotienlay"]).ToString();
                float cv = float.Parse(priority);
                if (cv > 5000000)
                {
                    // if thỏa dk thì thêm RGB 
                    e.Appearance.BackColor = Color.FromArgb(150, Color.LightCoral);
                    e.Appearance.BackColor2 = Color.Pink;
                }
            }
        }
    }
}
