using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BartenderLabelCleanup;
using WindowsFormsApp1.JobCosting;
using WindowsFormsApp1.KPI;
using WindowsFormsApp1.ProductionStatistics;
using WindowsFormsApp1.Reports;

namespace WindowsFormsApp1
{
    public partial class BootLoader : Form
    {
        public BootLoader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainReportsForm mrf = new MainReportsForm();
            mrf.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var bcleanup = new BarCleanup();
            bcleanup.Show();
        }

        private void btnProductionStatsViewer_Click(object sender, EventArgs e)
        {
            var prodStats = new ProductionStatisticsForm();
            prodStats.Show();
        }

        private void btnCosting_Click(object sender, EventArgs e)
        {
            var jbCosting = new JobCostingForm();
            jbCosting.Show();
        }

        private void btnKPI_Click(object sender, EventArgs e)
        {
            var kpi = new KPIForm();
            kpi.Show();
        }
    }
}
