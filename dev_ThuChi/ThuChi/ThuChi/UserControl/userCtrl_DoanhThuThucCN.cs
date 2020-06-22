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
using DevExpress.XtraEditors.Repository;
using System.Globalization;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Columns;

namespace ThuChi
{
    public partial class userCtrl_DoanhThuThucCN : DevExpress.XtraEditors.XtraUserControl
    {
        public userCtrl_DoanhThuThucCN()
        {
            InitializeComponent();
        }

        private void date_ChoseNgaySave_ValueChanged(object sender, EventArgs e)
        {
            DataProvider.Instance.GetDataDoanhThuIDbyNgay(date_ChoseNgaySave.Value,txt_doanhthuID);
        }

        private void userCtrl_DoanhThuThucCN_Load(object sender, EventArgs e)
        {
            ShowTienLoiCN();

            AddUnboundColumn();
            AddRepository();
        }

        void ShowTienLoiCN()
        {
            string query = "exec proc_ShowTienConLaiTheoCa";
            gridControl1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            //format show datetime show in gridview
            //if (gridView1.Columns.Count > 1)
            //{
            //    gridView1.Columns[4].DisplayFormat.FormatType = FormatType.DateTime;
            //    gridView1.Columns[4].DisplayFormat.FormatString = "d/M/yyyy";
            //}

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.InsertDataTienLoiCN(txt_cdtID.Text,txt_doanhthuID.Text);
            ShowTienLoiCN();
        }


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
            string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            try
            {
                if (MessageBox.Show("Xóa Doanh Thu ID " + id , "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataProvider.Instance.DeleteDataTienLoiCN(id);
                    ShowTienLoiCN();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi không xóa được, vì đã có dữ liệu liên quan tớitien lời: " + id + " Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddUnboundColumn()
        {
            GridColumn unbColumn = gridView1.Columns.AddField("Button");
            unbColumn.VisibleIndex = gridView1.Columns.Count;
            unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
        }
    }
}
