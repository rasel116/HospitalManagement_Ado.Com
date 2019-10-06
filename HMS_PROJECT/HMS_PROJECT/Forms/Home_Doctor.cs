using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;
using HMS_PROJECT.Reports;

namespace HMS_PROJECT.Forms
{
    public partial class Home_Doctor : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
         

        public Home_Doctor(DataTable dt)
        {
           

            InitializeComponent();
            CachedCrystalReport1 rpt = new CachedCrystalReport1();
            crystalReportViewer1.ReportSource = rpt;


        }

      

        private void Home_Doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMS_ProjectDBDataSet5.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hMS_ProjectDBDataSet5.Doctor);

        }

        private void metroButton1_ForeColorChanged(object sender, EventArgs e)
        {
            
        }
    }
}
