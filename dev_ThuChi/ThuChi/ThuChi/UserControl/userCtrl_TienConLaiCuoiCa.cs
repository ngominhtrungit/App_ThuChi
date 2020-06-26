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
using ThuChi.Class;
using DevExpress.XtraEditors.Repository;
using System.Globalization;
using DevExpress.XtraGrid.Columns;

namespace ThuChi.UserControl
{
    public partial class userCtrl_TienConLaiCuoiCa : DevExpress.XtraEditors.XtraUserControl
    {
        public userCtrl_TienConLaiCuoiCa()
        {
            InitializeComponent();
        }

        private void userCtrl_TienConLaiCuoiCa_Load(object sender, EventArgs e)
        {
            LoadDataTienConLaiTheoCa();
            CustomCellMergeColumnGridView customCellMergeColumnGrid = new CustomCellMergeColumnGridView(gridView1, "ngaytaodt");
            customCellMergeColumnGrid.CellMergeColumnGridViewTienCC();
        }

        public void LoadDataTienConLaiTheoCa()
        {
            string query = "exec [dbo].[proc_ShowTienConLaiTheoCa]";
            gridControl1.DataSource = DataProvider.Instance.ExecuteQuery(query);

            //format show datetime show in gridview
            if (gridView1.Columns.Count > 1)
            {
                gridView1.Columns[2].DisplayFormat.FormatType = FormatType.DateTime;
                gridView1.Columns[2].DisplayFormat.FormatString = "d/M/yyyy";
                gridView1.Columns[4].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                gridView1.Columns[4].DisplayFormat.FormatString = "n0";
            }
            AddUnboundColumn();
            AddRepository();
            DisableEditColumnsGridView.CustomEditColumnsGridView(gridView1, new int[] {0,1,2,3,4 });
        }

        private void date_ChoseNgaySave_ValueChanged(object sender, EventArgs e)
        {
            cb_tenCa.Items.Clear();
            txt_caID.Clear();
            cb_tenCa.Text = "";
            DataProvider.Instance.LoadtenCa_by_NgayTaoDT(date_ChoseNgaySave.Value.ToString(),cb_tenCa);
        }

        private void cb_tenCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider.Instance.ChoseComboBoxChangeTextBox_caID_byTenCa_TenNgayDT(date_ChoseNgaySave.Value, cb_tenCa, txt_caID);
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_caID.Text=="")
                {
                    MessageBox.Show("Phải chọn ca theo ngày:\n1,Chọn ngày muốn tổng hợp.\n2,Chọn tên Ca muốn tính toán tổng tiền còn lại của ca đó.");
                    return;
                }
                string query = "exec [dbo].[proc_InsertTienConLaiTheoCa] @caID ";
                DataProvider.Instance.ExecuteQuery(query, new object[] { txt_caID.Text });
                LoadDataTienConLaiTheoCa();
            }
            catch (Exception)
            {
                MessageBox.Show("'"+cb_tenCa.Text+"', thuộc ngày '"+date_ChoseNgaySave.Value+"' bạn đang thêm đã có sẵn rồi. xin mời kiểm tra lại!");
            }
           
        }

        #region button xóa
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
            int id = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]);
            string ngay = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            DateTime dt = DateTime.Parse(ngay, new CultureInfo("en-CA"));
            string tenCa = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            try
            {
                if (MessageBox.Show("Xóa '" + tenCa + "', thuộc ngày '" + dt.ToString("d/M/yyyy")+"'?", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "exec [dbo].[proc_DeleteTienConLaiTheoCa] @tlID ";
                    DataProvider.Instance.ExecuteQuery(query, new object[] { id.ToString() });
                    AutoCloseMessageBox.Show("Xóa '" + tenCa + "', thuộc ngày '" + dt.ToString("d/M/yyyy") + "' thành công!", "thông báo!", 2500);
                    LoadDataTienConLaiTheoCa();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không Xóa '" + tenCa + "', thuộc ngày '" + dt.ToString("d/M/yyyy") + "'! Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddUnboundColumn()
        {
            if (gridView1.Columns["Button"]==null)
            {
                GridColumn unbColumn = gridView1.Columns.AddField("Button");
                unbColumn.VisibleIndex = gridView1.Columns.Count;
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
