using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuChi
{
    public partial class userCtrl_Loading : Form
    {
        public Action Worker { set; get; }

        public userCtrl_Loading(Action worker)
        {
            InitializeComponent();
            if (worker == null)
                throw new AggregateException();
            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); },TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
