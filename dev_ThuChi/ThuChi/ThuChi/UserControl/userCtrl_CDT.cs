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
using DevExpress.XtraEditors.Repository;
using ThuChi.Class;
using DevExpress.XtraGrid.Views.BandedGrid;
using System.Globalization;

namespace ThuChi
{
    public partial class userCtrl_CDT : DevExpress.XtraEditors.XtraUserControl
    {
        string nameButtonTxt = "Button";
        public userCtrl_CDT()
        {
            InitializeComponent();
        }

        private void userCtrl_CDT_Load(object sender, EventArgs e)
        {
            LoadCDT();


            AddUnboundColumn(nameButtonTxt);
            AddRepository(nameButtonTxt);
            //click show data gridview2 by cdtID
            ClickMouseOnGridviewbyComlumn();
        }

        public void LoadCDT()
        {
            string query = "exec proc_ShowCDT";
            gridControl1.DataSource = DataProvider.Instance.ExecuteQuery(query);

            DisableEditColumnsGridView.CustomEditColumnsGridView(gridView1, new int[] { 0 });

        }

        #region Add button xóa into gridview
        private void AddRepository(string buttonText)
        {

            RepositoryItemButtonEdit edit = new RepositoryItemButtonEdit();
            edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            edit.Appearance.BackColor = ColorTranslator.FromHtml("#B2D6ea");
            edit.ButtonClick += edit_ButtonClick;
            edit.Buttons[0].Caption = "Xóa";
            edit.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            gridView1.Columns[buttonText].ColumnEdit = edit;
        }

        void edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            string ten = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            try
            {
                if (MessageBox.Show("Xóa CDTID " + id + ", thuộc tên " + ten, "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataProvider.Instance.DeleteDataCDT(id);
                    LoadCDT();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi không xóa được, vì đã có dữ liệu liên quan tới Mã Chi Phí: " + id + ", thuộc tên " + ten + "! Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddUnboundColumn(string buttonText)
        {
            GridColumn unbColumn = gridView1.Columns.AddField(buttonText);
            unbColumn.VisibleIndex = gridView1.Columns.Count;
            unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
        }
        #endregion

        #region click gridview 1 load data gridview 2
        private void ClickMouseOnGridviewbyComlumn()
        {
            gridView1.Columns["cdtID"].View.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp;
            gridView1.RowClick += gridView1_RowClick;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var id = (sender as GridView).GetFocusedRowCellValue("cdtID");
            //textEdit1.EditValue = (sender as GridView).GetFocusedRowCellValue("chiphiID");
            //MessageBox.Show("ok,"+abc);
            if (id == null)
            {
                return;
            }
            LoadDataBycdtID((int)id);
        }
        private void LoadDataBycdtID(int id)
        {
            try
            {
                string query = "exec proc_ShowCTCP_by_cdtID @cdtID='" + id + "'";
                gridControl2.DataSource = DataProvider.Instance.ExecuteQuery(query);

                if (gridView2.Columns.Count>1)
                {
                    gridView2.Columns[3].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    gridView2.Columns[3].DisplayFormat.FormatString = "d/M/yyyy";

                    gridView2.Columns[6].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                    gridView2.Columns[6].DisplayFormat.FormatString = "n0";
                }
                AddUnboundColumn2();
                AddRepository2();
                DisableEditColumnsGridView.CustomEditColumnsGridView(gridView2,new int[] {0,1,2,3,4,5 });
            }
            catch (SqlException ex)
            {
                MessageBox.Show("lỗi ngoại lệ: " + ex + ". Liên hệ Trung: 0902669115");
            }
        }

        #endregion

        private void txt_sdt_Leave(object sender, EventArgs e)
        {

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            string query = "exec proc_InsertCDT @tenCDT , @sdtCDT , @diachiCDT ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { txt_Ten.Text, txt_sdt.Text, txt_dc.Text });
            LoadCDT();
        }

        private void gridView2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void bt_CreateCDT_CPTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        //ok
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int id = (int)gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[0]);
            string tenCDT = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[1]).ToString();
            int sdtCDT = (int)gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[2]);
            string diachiCDT = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[3]).ToString();

            DialogResult res = MessageBox.Show("update tênCDT " + tenCDT + ", có ID:" + id.ToString() + "", "Thông Báo!", MessageBoxButtons.YesNo);
            try
            {
                if (res == DialogResult.Yes)
                {
                    string query1 = "exec [dbo].[proc_UpdateCDT] @cdtID , @tenCDT , @sdtCDT , @diachiCDT ";
                    DataProvider.Instance.ExecuteQuery(query1, new object[] { id, tenCDT, sdtCDT.ToString(), diachiCDT });
                    AutoCloseMessageBox.Show("Update chủ đầu tư:'" + tenCDT + "' thành công!", "Thông Báo!!", 1000);
                }
                LoadCDT();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi không update được " + id + ", Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //key press enter save
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gridView1.CloseEditor();
                gridView1.UpdateCurrentRow();
                e.Handled = true;
            }
        }

        private void gridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int ctcdtID = (int)gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[0]);
            int cdtID = (int)gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[1]);
            int chiphitcID = (int)gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[2]);
            string tenCDT = gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[5]).ToString();
            float sotienlay = float.Parse(gridView2.GetRowCellValue(e.RowHandle, gridView2.Columns[6]).ToString());
            DialogResult res = MessageBox.Show("update so tiền:'" + sotienlay.ToString() + "' của tênCDT: '" + tenCDT + "'?", "Thông Báo!", MessageBoxButtons.YesNo);
            try
            {
                if (res == DialogResult.Yes)
                {
                    string query1 = "exec [dbo].[proc_UpdateCDT_CPTheoCa] @ctcdtID , @cdtID , @chiphitcID , @sotienlay ";
                    DataProvider.Instance.ExecuteQuery(query1, new object[] { ctcdtID, cdtID, chiphitcID, sotienlay.ToString() });
                    AutoCloseMessageBox.Show("Update so tiền:'" + sotienlay.ToString() + "' của tênCDT: '" + tenCDT + "' Thành công!", "Thông Báo!!", 1000);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi không so tiền:'" + sotienlay.ToString() + "' của tênCDT: '" + tenCDT + "'?, Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gridView2.CloseEditor();
                gridView2.UpdateCurrentRow();
                e.Handled = true;
            }
        }

        #region Add button xóa into gridview
        private void AddRepository2()
        {

            RepositoryItemButtonEdit edit = new RepositoryItemButtonEdit();
            edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            edit.Appearance.BackColor = ColorTranslator.FromHtml("#B2D6ea");
            edit.ButtonClick += edit_ButtonClick2;
            edit.Buttons[0].Caption = "Xóa";
            edit.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            gridView2.Columns["Button"].ColumnEdit = edit;
        }

        void edit_ButtonClick2(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            string tenCa = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[4]).ToString();
            string id = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[0]).ToString();
            string ngay = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[3]).ToString();
            string sotienlay = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[6]).ToString();
            DateTime dt = DateTime.Parse(ngay, new CultureInfo("en-CA"));
            try
            {
                if (MessageBox.Show("Xóa tên ca: '" + tenCa + "', ngày '" + dt.ToString("d/M/yyyy") + "' với số tiền lấy: '"+sotienlay+"'", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "exec [dbo].[proc_DeleteCDT_CPTheoCa] @ctcdtID ";
                    DataProvider.Instance.ExecuteQuery(query, new object[] { id.ToString() });
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi không Xóa tên ca: '" + tenCa + "', ngày '" + dt.ToString("d/M/yyyy") + "'! Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddUnboundColumn2()
        {
            if (gridView2.Columns["Button"]==null)
            {
                GridColumn unbColumn = gridView2.Columns.AddField("Button");
                unbColumn.VisibleIndex = gridView2.Columns.Count;
                unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            }
            else
            {
                return;
            }
        }
        #endregion
    }
}
