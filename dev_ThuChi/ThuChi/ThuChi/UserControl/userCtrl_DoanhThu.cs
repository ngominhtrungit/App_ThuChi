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
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Columns;
using System.Globalization;
using DevExpress.XtraEditors.Repository;
using ThuChi.Class;

namespace ThuChi.UserControl
{
    public partial class userCtrl_DoanhThu : DevExpress.XtraEditors.XtraUserControl
    {
        public userCtrl_DoanhThu()
        {
            InitializeComponent();
        }

        private void userCtrl_DoanhThu_Load(object sender, EventArgs e)
        {
            LoadDoanhThu();


            ClickMouseOnGridviewbyComlumn();

            AddUnboundColumn();
            AddRepository();
            
        }

        public void LoadDoanhThu()
        {
            string query = "exec proc_ShowDoanhThu";
            gridControl1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            //format show datetime show in gridview
            if (gridView1.Columns.Count > 1)
            {
                gridView1.Columns[1].DisplayFormat.FormatType = FormatType.DateTime;
                gridView1.Columns[1].DisplayFormat.FormatString = "d/M/yyyy";
            }
            DisableEditColumnsGridView.CustomEditColumnsGridView(gridView1, new int[] { 0, 1 });
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.InsertDataDoanhThu(datetime_Ngaytao.Value);
            LoadDoanhThu();
        }


        private void ClickMouseOnGridviewbyComlumn()
        {
            gridView1.Columns["doanhthuID"].View.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp;
            gridView1.RowClick += gridView1_RowClick;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var id = (sender as GridView).GetFocusedRowCellValue("doanhthuID");
            //textEdit1.EditValue = (sender as GridView).GetFocusedRowCellValue("chiphiID");
            //MessageBox.Show("ok,"+abc);
            LoadDataByDoanhThuID((int)id);
            DisableEditColumnsGridView.CustomEditColumnsGridView(gridView2, new int[] { 0, 1 ,2});
        }

        private void LoadDataByDoanhThuID(int id)
        {
            try
            {
                string query = "exec proc_ShowDoanhThuTheoCa_by_doanhthuID @doanhthuID='" + id + "'";
                gridControl2.DataSource = DataProvider.Instance.ExecuteQuery(query);
                

            }
            catch (SqlException ex)
            {
                MessageBox.Show("lỗi ngoại lệ: " + ex + ". Liên hệ Trung: 0902669115");
            }
        }
        #region xóa doanh thu
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
            int id =(int) gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]);
            string ngay = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            DateTime dt = DateTime.Parse(ngay, new CultureInfo("en-CA"));
            try
            {
                if (MessageBox.Show("Xóa Chi phí ID " + id + ", thuộc ngày " + dt.ToString("d/M/yyyy"), "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "exec proc_DeleteDoanhThu @doanhthuID ";
                    DataProvider.Instance.ExecuteQuery(query,new object[] { id.ToString() });
                    LoadDoanhThu();
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

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int id = (int)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[0]);
            int doanhthuID = (int)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[1]);
            string ngay = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[2]).ToString();
            DateTime dt = DateTime.Parse(ngay, new CultureInfo("en-CA"));
            string tenCa = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[3]).ToString();
            float tiendelai = float.Parse(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[4]).ToString());
            float dttrongngay = float.Parse(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[5]).ToString());
            float dtkhac = float.Parse(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[6]).ToString());
            try
            {
                if (MessageBox.Show("update caID " + id + ", thuộc ngày " + dt.ToString("d/M/yyyy"), "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query1 = "exec [dbo].[proc_UpdateDoanhThuTheoCa] @caID , @tenCa , @doanhthuID , @tiendelai , @doanhthutheoca , @doanhthukhac ";
                    DataProvider.Instance.ExecuteQuery(query1, new object[] { id, tenCa, doanhthuID.ToString(), tiendelai.ToString(), dttrongngay.ToString(), dtkhac.ToString() });
                    AutoCloseMessageBox.Show("Update caID " + id + " thành công!", "Thông Báo!!", 1000);

                }

                //LoadDataByDoanhThuID(id);


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi không update được " + id + ", thuộc ngày " + ngay + "! Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
