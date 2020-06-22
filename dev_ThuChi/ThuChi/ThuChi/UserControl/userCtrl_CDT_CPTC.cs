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
    }
}
