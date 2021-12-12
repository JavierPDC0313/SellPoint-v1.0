using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SplashForm : Form
    {

        int cli = 0;

        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (this.Opacity > 0)
            {
                this.Opacity -= 0.00002;

            }
            this.Hide();
            FormLogin.Instancia.Show();
            timer1.Stop();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 10000;
            timer1.Start();
        }
    }
}
