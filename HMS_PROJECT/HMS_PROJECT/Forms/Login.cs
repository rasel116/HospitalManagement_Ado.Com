using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HMS_PROJECT;
using HMS_PROJECT.Forms;

namespace HMS_PROJECT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM UserInfo WHERE UserName='" + txtUserName.Text + "' AND UserPassword='" + metroTextBox2.Text + "'", con);
                 DataTable dt = new DataTable();
               
                cmd.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();

                    string role = dt.Rows[0]["UserName"].ToString();


                    switch (role)
                    {
                        case "Belal":
                            Home_patient home_Patient = new Home_patient(dt);
                            home_Patient.Show();
                            this.Close();
                            break;
                        case "Rasel":
                            //Show a different form
                            Home_Doctor home_Doctor = new Home_Doctor(dt);
                            home_Doctor.Show();
                            this.Close();
                            break;
                    }
                }

                else
                {
                    MessageBox.Show("UserName or PassWord INcorrect");
                }
            }
        }
    }
}
