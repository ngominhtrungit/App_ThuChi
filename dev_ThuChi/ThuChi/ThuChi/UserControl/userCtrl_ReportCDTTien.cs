﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ThuChi.UserControl
{
    public partial class userCtrl_ReportCDTTien : DevExpress.XtraEditors.XtraUserControl
    {
        public userCtrl_ReportCDTTien()
        {
            InitializeComponent();
        }

        public void ReloadData()
        {
            dashboardViewer1.ReloadData();
        }
    }
}
