using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TrailerScrapReport : Form
    {
        public TrailerScrapReport()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            try
            {
                string connString = "Server=vagrant-win10\\SQLEXPRESS;Database=AdventureWorks2022;Trusted_Connection=True;";
                string query = "SELECT *  FROM [Production].[vWorkOrderScrapStatistics]";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "vWorkOrderScrapStatistics");

                       
                        ReportDocument reportDoc = new ReportDocument();
                        string appDirectory = Application.StartupPath;
                        string reportPath = Path.Combine(appDirectory, "Reports\\WastageReports", "CrystalReport1.rpt");
                        reportDoc.Load(reportPath);
                        reportDoc.SetDataSource(ds);

                        
                        crystalReportViewer1.ReportSource = reportDoc;
                        crystalReportViewer1.RefreshReport();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message);
            }
        }
    }
}
