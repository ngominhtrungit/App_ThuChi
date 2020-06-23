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
            }
        }

        private void date_ChoseNgaySave_ValueChanged(object sender, EventArgs e)
        {
            cb_tenCa.Items.Clear();
            txt_doanhthuID.Clear();
            cb_tenCa.Text = "";
            DataProvider.Instance.LoadtenCa_by_NgayTaoDT(date_ChoseNgaySave.Value.ToString(),cb_tenCa);
        }

        private void cb_tenCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider.Instance.ChoseComboBoxChangeTextBox_caID_byTenCa_TenNgayDT(date_ChoseNgaySave.Value, cb_tenCa, txt_doanhthuID);
        }
    }
}
