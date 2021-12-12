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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            LblUser.Text = FormLogin.Instancia.userName;
            LblPass.Text = FormLogin.Instancia.Pass;
        }
    }
}
