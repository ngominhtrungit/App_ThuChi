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
using DevExpress.Utils;
using System.Globalization;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;

namespace ThuChi
{
    public partial class userCtrl_CTCP : DevExpress.XtraEditors.XtraUserControl
    {
        public userCtrl_CTCP()
        {
            InitializeComponent();
        }

        private void userCtrl_CTCP_Load(object sender, EventArgs e)
        {
            LoadCTCP();
            AddUnboundColumn();
            AddRepository();
            CustomCellMergeColumnGridView();
        }

        public void LoadCTCP()
        {
            string query = "exec proc_ShowCTCPTC";
            gridControl1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            //format show datetime show in gridview
            //if (gridView1.Columns.Count > 1)
            //{
            //    gridView1.Columns[4].DisplayFormat.FormatType = FormatType.DateTime;
            //    gridView1.Columns[4].DisplayFormat.FormatString = "d/M/yyyy";
            //}
            CustomCellMergeColumnGridView();
        }

        private void CustomCellMergeColumnGridView()
        {
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                if (gridView1.Columns[i].FieldName == "ngaytaocp")
                {
                    //gridView1.Columns[i + 1].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                    gridView1.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                    gridView1.Columns[i - 1].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                    
                }
                else
                {
                    gridView1.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                }
            }

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string query = "exec [dbo].[proc_InsertCTChiPhiTheoCa] @chiphitcID , @mota , @donvitinh , @soluong , @dongia ";
            DataProvider.Instance.ExecuteQuery(query,new object[] { txt_chiphitcID.Text, txt_moTa.Text, cb_dVT.Text, txt_SL.Text, txt_donGia.Text });
            LoadCTCP();
        }

        private void date_ChoseNgayTen_MouseUp(object sender, MouseEventArgs e)
        {
            txt_chiphitcID.Clear();
            cb_tenCa.Text = null;
            cb_tenCa.Items.Clear();
            //DateTime parsedDate = DateTime.ParseExact(date_ChoseDoanhThuID.Value,
            //                              "yyyyMMdd",
            //                              CultureInfo.InvariantCulture);
            //string query = "exec proc_RetrieveDoanhThuID @ngay ";//= '"+ date_ChoseDoanhThuID.Value +"'";
            DataProvider.Instance.LoadCB_tenCa_by_NgayTaoCP(date_ChoseNgayTen.Value.ToString(), cb_tenCa);
        }

        private void date_ChoseNgayTen_ValueChanged(object sender, EventArgs e)
        {
            txt_chiphitcID.Clear();
            cb_tenCa.Text = null;
            cb_tenCa.Items.Clear();
            //DateTime parsedDate = DateTime.ParseExact(date_ChoseDoanhThuID.Value,
            //                              "yyyyMMdd",
            //                              CultureInfo.InvariantCulture);
            //string query = "exec proc_RetrieveDoanhThuID @ngay ";//= '"+ date_ChoseDoanhThuID.Value +"'";
            DataProvider.Instance.LoadCB_tenCa_by_NgayTaoCP(date_ChoseNgayTen.Value.ToString(), cb_tenCa);
        }

        private void cb_tenCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider.Instance.ChoseComboBoxChangeTextBoxCDTNhanTien(date_ChoseNgayTen.Value, cb_tenCa, txt_chiphitcID);
        }

        #region Add button xóa into gridview
        private void AddRepository()
        {

            RepositoryItemButtonEdit edit = new RepositoryItemButtonEdit();
            edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            edit.Appearance.BackColor = ColorTranslator.FromHtml("#B2D6ea");
            edit.ButtonClick += edit_ButtonClick;
            edit.Buttons[0].Caption = "Xóa";
            edit.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            gridView1.Columns["Button"].ColumnEdit = edit;
        }

        void edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string tenCa = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            string ngay = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            DateTime dt = DateTime.Parse(ngay, new CultureInfo("en-CA"));
            try
            {
                if (MessageBox.Show("Xóa CT Chi phí Theo Ca ID: '" + id + "', tên ca: '" + tenCa + "', ngày '" + dt.ToString("d/M/yyyy") + "'", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "exec [dbo].[proc_DeleteCTChiPhiTheoCa] @ctcptcID ";
                    DataProvider.Instance.ExecuteQuery(query,new object[] { id.ToString() });
                    LoadCTCP();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi không xóa được, vì đã có dữ liệu liên quan tới Mã Chi Phí: " + id + ", thuộc ngày " + ngay + "! Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddUnboundColumn()
        {
            GridColumn unbColumn = gridView1.Columns.AddField("Button");
            unbColumn.VisibleIndex = gridView1.Columns.Count;
            unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
        }
        #endregion
    }
}
