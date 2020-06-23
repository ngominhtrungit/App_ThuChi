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
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using System.Globalization;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;

namespace ThuChi.UserControl
{
    public partial class userCtrl_DoanhThuTheoCa : DevExpress.XtraEditors.XtraUserControl
    {
        public userCtrl_DoanhThuTheoCa()
        {
            InitializeComponent();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            InsertDataDoanhThuTheoCa();
        }

        private void InsertDataDoanhThuTheoCa()
        {
            try
            {
                if (txt_TenCa.Text != "" && txt_doanhthuID.Text != "" && txt_Tiendelai.Text != "" && txt_Dttrongngay.Text != "")
                {
                    string query = "exec [dbo].[proc_InsertDoanhThuTheoCa] @tenCa , @doanhthuID , @tiendelai , @doanhthutheoca , @doanhthukhac ";
                    gridControl1.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { txt_TenCa.Text, txt_doanhthuID.Text, txt_Tiendelai.Text, txt_Dttrongngay.Text, txt_Dtkhac.Text });
                    LoadDoanhThuTheoCa();
                    ClearInput();
                }
                else if (txt_TenCa.Text == "")
                {
                    MessageBox.Show("trường Tên Ca không được bỏ trống!","Thông Báo!");
                    return;
                }
                else if (txt_doanhthuID.Text == "")
                {
                    MessageBox.Show("Phải chọn ngày để tạo doanh thu theo ca. \n'Ngày Hiện Tại'!", "Thông Báo!");
                    return;
                }
                else if (txt_Tiendelai.Text == "")
                {
                    MessageBox.Show("Phải chọn ngày, sau đó chọn ca gần nhất để Chọn Tiền để lại!", "Thông Báo!");
                    return;
                }
                else if (txt_Dttrongngay.Text == "")
                {
                    MessageBox.Show("Nhập vào doanh thu trong ngày, không được bỏ trống!", "Thông Báo!");
                    return;
                }
                else
                {
                    MessageBox.Show("Bạn đã bỏ trống toàn bộ các trường input dữ liệu, xin mời nhập!", "Thông Báo!");
                    return;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("lỗi trùng tên hoặc lỗi khác!","Thông Báo!!");
            }
           
        }

        private void ClearInput()
        {
            txt_TenCa.Clear();
            txt_Tiendelai.Clear();
            txt_doanhthuID.Clear();
            txt_Dttrongngay.Clear();
            txt_Dtkhac.Clear();
        }

        private void userCtrl_DoanhThuTheoCa_Load(object sender, EventArgs e)
        {
            LoadDoanhThuTheoCa();
            AddUnboundColumn();
            AddRepository();
            CustomCellMergeColumnGridView();
            //LoadtenCatoComboBox();
        }

        public void LoadDoanhThuTheoCa()
        {
            string query = "exec proc_ShowDoanhThuTheoCa";
            gridControl1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            if (gridView1.Columns.Count > 1)
            {
                gridView1.Columns[2].DisplayFormat.FormatType = FormatType.DateTime;
                gridView1.Columns[2].DisplayFormat.FormatString = "d/M/yyyy";
            }
            
            //CustomCellMergeColumnGridView();
            DisableEditColumnsGridView.CustomEditColumnsGridView(gridView1, new int[] { 0, 1, 2});
            

        }

        private void datetime_ChoseNgay_ValueChanged(object sender, EventArgs e)
        {
            DataProvider.Instance.GetDataDoanhThuIdbyNgay(datetime_ChoseNgay.Value, txt_doanhthuID);
        }

        private void datetime_ChoseTiendelai_ValueChanged(object sender, EventArgs e)
        {
            cb_tenCa.Items.Clear();
            cb_tenCa.Text = "";
            LoadtenCatoComboBox();

           
        }

        private void LoadtenCatoComboBox()
        {
            DataProvider.Instance.LoadCB_tenCa_by_Ngay(datetime_ChoseNgaytenCA.Value.ToString(), cb_tenCa);
        }

        private void cb_tenCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Tiendelai.Clear();
            DataProvider.Instance.ChoseComboBoxChangeTextBoxDTTC(datetime_ChoseNgaytenCA.Value,cb_tenCa, txt_Tiendelai);
            if (txt_Tiendelai.Text == "")
            {
                DialogResult result= MessageBox.Show("'" + txt_Tiendelai.Text + "' hiện tại chưa có tổng hợp tiền. Chỉ cần qua Tab 'Tiền Còn Lại Cuối Ca' ==> Save là được!","Thông báo!",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (result==DialogResult.Yes)
                {
                    //mở frm TienConLaiCuoiNgay
                }
            }
        }

        private void CustomCellMergeColumnGridView()
        {
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                if (gridView1.Columns[i].FieldName == "ngaytaodt")
                {
                    gridView1.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                    gridView1.Columns[i-1].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                }
                else
                {
                    gridView1.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                }
            }
                
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView currentView = sender as GridView;
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                int abc = int.Parse(gridView1.Columns[i].VisibleIndex.ToString());
                if (e.Column.VisibleIndex == abc)
                {
                    if (abc % 2 == 0)
                    {
                        e.Appearance.BackColor = Color.Pink;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.White;
                    }
                }
               
            }
            
            //if (e.Column.VisibleIndex == )
            //{
            //    bool value = Convert.ToBoolean(currentView.GetRowCellValue(e.RowHandle, "Flag_Customer"));
            //    if (value)
            //        e.Appearance.BackColor = Color.Red;
            //}
            //if (e.Column.FieldName == "Vendor")
            //{
            //    bool value = Convert.ToBoolean(currentView.GetRowCellValue(e.RowHandle, "Flat_Vendor"));
            //    if (value)
            //        e.Appearance.BackColor = Color.Red;
            //}
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
            int id = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]);
            string ngay = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            DateTime dt = DateTime.Parse(ngay, new CultureInfo("en-CA"));
            try
            {
                if (MessageBox.Show("Xóa Chi phí ID " + id + ", thuộc ngày " + dt.ToString("d/M/yyyy"), "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "exec [dbo].[proc_DeleteDoanhThuTheoCa] @caID ";
                    DataProvider.Instance.ExecuteQuery(query, new object[] { id.ToString() });
                    LoadDoanhThuTheoCa();
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

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void txt_TenCa_Leave(object sender, EventArgs e)
        {
            RegexCustom.Instance.CheckInput("^[a-z0-9]+( [a-z0-9]+)*$", "Không đúng định dạng, không được có khoảng trắng ở đầu chuỗi và ở cuối chuỗi, ở giữa chỉ chứa 1 khoảng trắng. \n VD: 'ca 1': hợp lệ \n ' ca 1':không hợp lệ ", txt_TenCa, pictureBox1);
        }

        private void txt_Tiendelai_Leave(object sender, EventArgs e)
        {
            RegexCustom.Instance.CheckInput("^[-]?[0-9]+[,.]?[0-9]*([\'/][0-9]+[,.]?[0-9]*)*$", "Không đúng định dạng, định dạng đúng phải là số, \n Vd: 100000 \nVd: 654321,5", txt_Tiendelai, pictureBox4);
        }

        private void txt_Dtkhac_Leave(object sender, EventArgs e)
        {
            RegexCustom.Instance.CheckInput("^[-]?[0-9]+[,.]?[0-9]*([\'/][0-9]+[,.]?[0-9]*)*$", "Không đúng định dạng, định dạng đúng phải là số, \n Vd: 100000 \nVd: 654321,5", txt_Dtkhac, pictureBox3);
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int id = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]);
            int doanhthuID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]);
            string ngay = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            DateTime dt = DateTime.Parse(ngay, new CultureInfo("en-CA"));
            string tenCa = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            float tiendelai = float.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString());
            float dttrongngay = float.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString());
            float dtkhac = float.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]).ToString());
            try
            {
                if (MessageBox.Show("update caID " + id + ", thuộc ngày " + dt.ToString("d/M/yyyy"), "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query1 = "exec [dbo].[proc_UpdateDoanhThuTheoCa] @caID , @tenCa , @doanhthuID , @tiendelai , @doanhthutheoca , @doanhthukhac ";
                    DataProvider.Instance.ExecuteQuery(query1, new object[] { id, tenCa, doanhthuID.ToString(), tiendelai.ToString(), dttrongngay.ToString(), dtkhac.ToString() });
                    AutoCloseMessageBox.Show("Update caID " + id + " thành công!", "Thông Báo!!", 1000);
                    //DataProvider.Instance.UpdateDataDoanhThu(id, dt.ToString());
                    //LoadDoanhThu();
                }
                //else
                //{
                LoadDoanhThuTheoCa();
                //}
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi không update được " + id + ", thuộc ngày " + ngay + "! Nếu có bất kỳ thắc mắc gì vui lòng liên hệ Trung sdt: 0902669115", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
