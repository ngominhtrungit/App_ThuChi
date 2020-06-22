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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using ThuChi.Class;

namespace ThuChi
{
    public partial class userCtrl_ChiPhi : DevExpress.XtraEditors.XtraUserControl
    {
        public userCtrl_ChiPhi()
        {
            InitializeComponent();
        }

        private void userCtrl_ChiPhi_Load(object sender, EventArgs e)
        {
            LoadDataChiPhi();

            //add button into gridview
            AddUnboundColumn();
            AddRepository();
            //LoadDoanhThuIDtoComboBox();

            //mouse click row in gridview
            //chọn dòng chiphiID
            ClickMouseOnGridviewbyComlumn();

            txt_caID.Text = null;


        }



        void LoadDataChiPhi()
        {
            string query = "exec proc_ShowChiPhi";
            gridControl1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            //format show datetime show in gridview
            if (gridView1.Columns.Count > 1)
            {
                gridView1.Columns[2].DisplayFormat.FormatType = FormatType.DateTime;
                gridView1.Columns[2].DisplayFormat.FormatString = "d/M/yyyy";
            }
            DisableEditColumnsGridView.CustomEditColumnsGridView(gridView1, new int[] { 0, 1, 2 ,3});

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
            string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            string ngay = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            DateTime dt = DateTime.Parse(ngay, new CultureInfo("en-CA"));
            try
            {
                if (MessageBox.Show("Xóa Chi phí ID " + id + ", thuộc ngày " + dt.ToString("d/M/yyyy"), "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "exec [dbo].[proc_DeleteChiPhiTheoCa] @chiphitcID ";
                    DataProvider.Instance.ExecuteQuery(query,new object[] { id });
                    LoadDataChiPhi();
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

        private void LoadDoanhThuIDtoComboBox()
        {
            //DataProvider.Instance.LoadComboBox(cb_ngaytao);
        }

        private void cb_ngaytao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataProvider.Instance.ChoseComboBoxChangeTextBox(cb_ngaytao, txt_doanhthuid);
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider.Instance.InsertDataChiPhiTheoCa(date_ChoseDoanhThuID.Value, txt_caID.Text);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi, bạn phải chọn ngày ");
            }

            LoadDataChiPhi();
        }

        #region show data CTCP by chiphiID
        /*
         khi click trên 1 row bất kỳ trên gridview ChiPhi
         thì gridview CTChiPhi sẽ hiển thị chi tiết tương ứng thông qua chiphiID
             */
        private void ClickMouseOnGridviewbyComlumn()
        {
            gridView1.Columns["chiphitcID"].View.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp;
            gridView1.RowClick += gridView1_RowClick;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var id = (sender as GridView).GetFocusedRowCellValue("chiphitcID");
            //textEdit1.EditValue = (sender as GridView).GetFocusedRowCellValue("chiphiID");
            //MessageBox.Show("ok,"+abc);
            if (id == null)
            {
                return;
            }
            LoadDataBychiphitcID(id.ToString());
        }

        private void LoadDataBychiphitcID(string id)
        {
            try
            {

                string query = "exec proc_ShowCTCP_by_chiphiID @chiphitcID='" + id + "'";
                gridControl2.DataSource = DataProvider.Instance.ExecuteQuery(query);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("lỗi ngoại lệ: " + ex + ". Liên hệ Trung: 0902669115");
            }
        }
        #endregion

        //private void txt_chiphiID_Leave(object sender, EventArgs e)
        //{
        //    RegexCustom.Instance.CheckInput(@"^[A-Za-z0-9]+$", txt_chiphiID, pictureBox1);
        //}

        private void cb_ngaytao_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    DataProvider.Instance.ChoseComboBoxChangeTextBox(cb_ngaytao, txt_doanhthuid);
            //}
        }

        private void bt_ctcp_Click(object sender, EventArgs e)
        {
            frm_ChiTietChiPhi frmCTCP = new frm_ChiTietChiPhi();
            frmCTCP.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_caID.Clear();
            cb_tenCa.Text = null;
            cb_tenCa.Items.Clear();
            //DateTime parsedDate = DateTime.ParseExact(date_ChoseDoanhThuID.Value,
            //                              "yyyyMMdd",
            //                              CultureInfo.InvariantCulture);
            //string query = "exec proc_RetrieveDoanhThuID @ngay ";//= '"+ date_ChoseDoanhThuID.Value +"'";
            DataProvider.Instance.LoadtenCa_by_NgayTaoDT(date_ChoseDoanhThuID.Value.ToString(), cb_tenCa);
        }

        private void gridView2_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            //if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            //{
            //    DXMenuItem item = new DXMenuItem("Thêm Chi Tiết CP theo ca");
            //    item.Click += (o, args) => {
            //    };
            //    e.Menu.Items.Add(item);
            //}

        }

        private void bt_CreateCTCPTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frm_ChiTietChiPhi frmCTCP = new frm_ChiTietChiPhi())
            {
                frmCTCP.ShowDialog();

            }
        }

        private void gridView2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void cb_tenCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider.Instance.ChoseComboBoxChangeTextBoxChiPhiTC(date_ChoseDoanhThuID.Value, cb_tenCa, txt_caID);
        }
    }
}
