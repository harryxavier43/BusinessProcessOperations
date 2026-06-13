using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Reports
{
    public partial class MainReportsForm : Form
    {
        public MainReportsForm()
        {
            InitializeComponent();
        }

       private void llTrailerScrap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var tsc = new TrailerScrapReport();
            tsc.Show();
        }

        private void llProbyCust_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var tsc = new TrailerScrapReport();
            tsc.Show();
        }
    }
}
