using HMS_PROJECT;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_M_S
{
    public partial class Welcom_from_sys : MetroForm
    {
        public Welcom_from_sys()
        {
            InitializeComponent();
           // this.TransparencyKey = (BackColor);
        }

        private void Welcom_from_sys_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            metroProgressBar1.Increment(3);

            if (metroProgressBar1.Value == metroProgressBar1.Maximum)
            {
                Login h = new Login();
                this.Hide();
                timer1.Stop();
                
                h.Show();

            } 
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
