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

        }

        private void userCtrl_CDT_CPTC_Load(object sender, EventArgs e)
        {
            LoadTenCDTtoComboBox();
        }

        private void LoadTenCDTtoComboBox()
        {
            DataProvider.Instance.LoadCB_tenCDT(cb_ChoseTen);
        }
    }
}
