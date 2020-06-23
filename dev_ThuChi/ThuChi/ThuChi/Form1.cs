using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ThuChi.UserControl;

namespace ThuChi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ribbonControl1.Minimized = !ribbonControl1.Minimized;
            userCtrl_DoanhThu1.Hide();
            userCtrl_DoanhThuTheoCa1.Hide();
            userCtrl_Dashboard1.Hide();
            userCtrl_DTBanHang1.Hide();
            userCtrl_ChiPhi2.Hide();
            userCtrl_ChiPhi2.ResetText();
            userCtrl_CTCP2.Hide();
            userCtrl_CDT1.Hide();
            userCtrl_CDT_CPTC1.Hide();
            userCtrl_ReportChiPhiTheoCa1.Hide();
            userCtrl_ReportCDTTien1.Hide();
            userCtrl_TienConLaiCuoiCa1.Hide();
        }

        void LoadData()
        {
            for (int i = 0; i < 250; i++)
            {
                Thread.Sleep(1);
            }
        }

        private void bt_ShowDashboard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (userCtrl_Loading usercontrl = new userCtrl_Loading(LoadData))
            {
                usercontrl.ShowDialog(this);

                userCtrl_DoanhThu1.Hide();
                userCtrl_DoanhThuTheoCa1.Hide();
                userCtrl_Dashboard1.Hide();
                userCtrl_DTBanHang1.Hide();
                userCtrl_ChiPhi2.Hide();
                userCtrl_ChiPhi2.ResetText();
                userCtrl_CTCP2.Hide();
                userCtrl_CDT1.Hide();
                userCtrl_CDT_CPTC1.Hide();
                userCtrl_ReportChiPhiTheoCa1.Hide();
                userCtrl_ReportCDTTien1.Hide();
                userCtrl_TienConLaiCuoiCa1.Hide();


            }


        }

        private void bt_CreateEditDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (userCtrl_Loading usercontrl = new userCtrl_Loading(LoadData))
            {
                usercontrl.ShowDialog(this);
                userCtrl_DoanhThuTheoCa1.Show();
                userCtrl_DoanhThuTheoCa1.BringToFront();
                userCtrl_DoanhThuTheoCa1.LoadDoanhThuTheoCa();

                userCtrl_DoanhThu1.Hide();
                userCtrl_Dashboard1.Hide();
                userCtrl_DTBanHang1.Hide();
                userCtrl_ChiPhi2.Hide();
                userCtrl_ChiPhi2.ResetText();
                userCtrl_CTCP2.Hide();
                userCtrl_CDT1.Hide();
                userCtrl_CDT_CPTC1.Hide();
                userCtrl_ReportChiPhiTheoCa1.Hide();
                userCtrl_ReportCDTTien1.Hide();
                userCtrl_TienConLaiCuoiCa1.Hide();

            }
        }

        private void bt_DTBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (userCtrl_Loading usercontrl = new userCtrl_Loading(LoadData))
            {
                usercontrl.ShowDialog(this);
                userCtrl_DTBanHang1.Show();
                userCtrl_DTBanHang1.BringToFront();
                userCtrl_DTBanHang1.ReloadData();

                userCtrl_DoanhThu1.Hide();
                userCtrl_DoanhThuTheoCa1.Hide();
                userCtrl_Dashboard1.Hide();
                userCtrl_ChiPhi2.Hide();
                userCtrl_ChiPhi2.ResetText();
                userCtrl_CTCP2.Hide();
                userCtrl_CDT1.Hide();
                userCtrl_CDT_CPTC1.Hide();
                userCtrl_ReportChiPhiTheoCa1.Hide();
                userCtrl_ReportCDTTien1.Hide();
                userCtrl_TienConLaiCuoiCa1.Hide();


            }
        }

        private void bt_CTCP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (userCtrl_Loading usercontrl = new userCtrl_Loading(LoadData))
            {
                usercontrl.ShowDialog(this);

                userCtrl_CTCP2.LoadCTCP();
                userCtrl_CTCP2.Show();
                userCtrl_CTCP2.BringToFront();

                userCtrl_DoanhThu1.Hide();
                userCtrl_DoanhThuTheoCa1.Hide();
                userCtrl_Dashboard1.Hide();
                userCtrl_DTBanHang1.Hide();
                userCtrl_ChiPhi2.Hide();
                userCtrl_ChiPhi2.ResetText();
                userCtrl_CDT1.Hide();
                userCtrl_CDT_CPTC1.Hide();
                userCtrl_ReportChiPhiTheoCa1.Hide();
                userCtrl_ReportCDTTien1.Hide();
                userCtrl_TienConLaiCuoiCa1.Hide();

            }
        }

        private void bt_CreateEditCP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (userCtrl_Loading usercontrl = new userCtrl_Loading(LoadData))
            {
                usercontrl.ShowDialog(this);
                userCtrl_ChiPhi2.ResetText();

                userCtrl_ChiPhi2.Show();
                userCtrl_ChiPhi2.BringToFront();

                userCtrl_DoanhThu1.Hide();
                userCtrl_DoanhThuTheoCa1.Hide();
                userCtrl_Dashboard1.Hide();
                userCtrl_DTBanHang1.Hide();
                userCtrl_CTCP2.Hide();
                userCtrl_CDT1.Hide();
                userCtrl_CDT_CPTC1.Hide();
                userCtrl_ReportChiPhiTheoCa1.Hide();
                userCtrl_ReportCDTTien1.Hide();
                userCtrl_TienConLaiCuoiCa1.Hide();

            }
        }

        private void bt_AddEditCDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (userCtrl_Loading usercontrl = new userCtrl_Loading(LoadData))
            {
                usercontrl.ShowDialog(this);
                userCtrl_CDT1.Show();
                userCtrl_CDT1.BringToFront();
                userCtrl_CDT1.LoadCDT();

                userCtrl_DoanhThu1.Hide();
                userCtrl_DoanhThuTheoCa1.Hide();
                userCtrl_Dashboard1.Hide();
                userCtrl_DTBanHang1.Hide();
                userCtrl_ChiPhi2.Hide();
                userCtrl_ChiPhi2.ResetText();
                userCtrl_CTCP2.Hide();
                userCtrl_CDT_CPTC1.Hide();
                userCtrl_ReportChiPhiTheoCa1.Hide();
                userCtrl_ReportCDTTien1.Hide();
                userCtrl_TienConLaiCuoiCa1.Hide();
            }
        }

        private void bt_TongDoanhThuThucCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (userCtrl_Loading usercontrl = new userCtrl_Loading(LoadData))
            {
                usercontrl.ShowDialog(this);
                userCtrl_TienConLaiCuoiCa1.LoadDataTienConLaiTheoCa();
                userCtrl_TienConLaiCuoiCa1.Show();
                userCtrl_TienConLaiCuoiCa1.BringToFront();



                userCtrl_DoanhThu1.Hide();
                userCtrl_DoanhThuTheoCa1.Hide();
                userCtrl_Dashboard1.Hide();
                userCtrl_DTBanHang1.Hide();
                userCtrl_ChiPhi2.Hide();
                userCtrl_ChiPhi2.ResetText();
                userCtrl_CTCP2.Hide();
                userCtrl_CDT1.Hide();
                userCtrl_CDT_CPTC1.Hide();
                userCtrl_ReportChiPhiTheoCa1.Hide();
                userCtrl_ReportCDTTien1.Hide();

            }
        }

        private void bt_CreateDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (userCtrl_Loading usercontrl = new userCtrl_Loading(LoadData))
            {
                usercontrl.ShowDialog(this);
                userCtrl_DoanhThu1.Show();
                userCtrl_DoanhThu1.BringToFront();
                userCtrl_DoanhThu1.LoadDoanhThu();

                userCtrl_DoanhThuTheoCa1.Hide();
                userCtrl_Dashboard1.Hide();
                userCtrl_DTBanHang1.Hide();
                userCtrl_ChiPhi2.Hide();
                userCtrl_ChiPhi2.ResetText();
                userCtrl_CTCP2.Hide();
                userCtrl_CDT1.Hide();
                userCtrl_CDT_CPTC1.Hide();
                userCtrl_ReportChiPhiTheoCa1.Hide();
                userCtrl_ReportCDTTien1.Hide();
                userCtrl_TienConLaiCuoiCa1.Hide();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (userCtrl_Loading usercontrl = new userCtrl_Loading(LoadData))
            {
                usercontrl.ShowDialog(this);
                userCtrl_Dashboard1.Show();
                userCtrl_Dashboard1.BringToFront();

                userCtrl_DoanhThu1.Hide();
                userCtrl_DoanhThuTheoCa1.Hide();
                userCtrl_DTBanHang1.Hide();
                userCtrl_ChiPhi2.Hide();
                userCtrl_ChiPhi2.ResetText();
                userCtrl_CTCP2.Hide();
                userCtrl_CDT1.Hide();
                userCtrl_CDT_CPTC1.Hide();
                userCtrl_ReportChiPhiTheoCa1.Hide();
                userCtrl_ReportCDTTien1.Hide();
                userCtrl_TienConLaiCuoiCa1.Hide();
            }
        }

        private void bt_ChiTietCDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (userCtrl_Loading usercontrl = new userCtrl_Loading(LoadData))
            {
                usercontrl.ShowDialog(this);
                userCtrl_CDT_CPTC1.Show();
                userCtrl_CDT_CPTC1.BringToFront();
                userCtrl_CDT_CPTC1.LoadCTCDT_CPTC();

                userCtrl_DoanhThu1.Hide();
                userCtrl_DoanhThuTheoCa1.Hide();
                userCtrl_Dashboard1.Hide();
                userCtrl_DTBanHang1.Hide();
                userCtrl_ChiPhi2.Hide();
                userCtrl_ChiPhi2.ResetText();
                userCtrl_CTCP2.Hide();
                userCtrl_CDT1.Hide();
                userCtrl_ReportChiPhiTheoCa1.Hide();
                userCtrl_ReportCDTTien1.Hide();
                userCtrl_TienConLaiCuoiCa1.Hide();

            }
        }

        private void bt_BaocaoCDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (userCtrl_Loading usercontrl = new userCtrl_Loading(LoadData))
            {
                userCtrl_ReportCDTTien1.Show();
                userCtrl_ReportCDTTien1.BringToFront();
                userCtrl_ReportCDTTien1.ReloadData();

                userCtrl_DoanhThu1.Hide();
                userCtrl_DoanhThuTheoCa1.Hide();
                userCtrl_Dashboard1.Hide();
                userCtrl_DTBanHang1.Hide();
                userCtrl_ChiPhi2.Hide();
                userCtrl_ChiPhi2.ResetText();
                userCtrl_CTCP2.Hide();
                userCtrl_CDT1.Hide();
                userCtrl_CDT_CPTC1.Hide();
                userCtrl_ReportChiPhiTheoCa1.Hide();
                userCtrl_TienConLaiCuoiCa1.Hide();
            }

        }

        private void bt_BaoCaoCPTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (userCtrl_Loading usercontrl = new userCtrl_Loading(LoadData))
            {
                userCtrl_ReportChiPhiTheoCa1.Show();
                userCtrl_ReportChiPhiTheoCa1.BringToFront();
                userCtrl_ReportChiPhiTheoCa1.ReloadData();

                userCtrl_DoanhThu1.Hide();
                userCtrl_DoanhThuTheoCa1.Hide();
                userCtrl_Dashboard1.Hide();
                userCtrl_DTBanHang1.Hide();
                userCtrl_ChiPhi2.Hide();
                userCtrl_ChiPhi2.ResetText();
                userCtrl_CTCP2.Hide();
                userCtrl_CDT1.Hide();
                userCtrl_CDT_CPTC1.Hide();
                userCtrl_ReportCDTTien1.Hide();
                userCtrl_TienConLaiCuoiCa1.Hide();
            }

        }
    }
}
