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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbUser_Enter(object sender, EventArgs e)
        {
            if (tbUser.Text == "Usuario")
            {
                tbUser.Text = "";
                
            }
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (tbUser.Text == "")
            {
                tbUser.Text = "Usuario";

            }
        }

        private void tbContraseña_Enter(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "Contraseña")
            {
                tbContraseña.Text = "";
                tbContraseña.UseSystemPasswordChar = true;

            }
        }

        private void tbContraseña_Leave(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "")
            {
                tbContraseña.Text = "Contraseña";
                tbContraseña.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
