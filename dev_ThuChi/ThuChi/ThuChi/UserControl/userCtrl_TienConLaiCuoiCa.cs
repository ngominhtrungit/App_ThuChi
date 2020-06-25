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
    }
}
