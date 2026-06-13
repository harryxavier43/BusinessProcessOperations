using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.BartenderLabelCleanup
{
    public partial class BarCleanup : Form
    {
        public BarCleanup()
        {
            InitializeComponent();

           var blc =  new BartenderDAL();
           MessageBox.Show(blc.Test().ToString());
        }
    }
}
