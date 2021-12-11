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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void atsmInventario_Click(object sender, EventArgs e)
        {
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstudiantes Usuarios = new FormEstudiantes();
            Usuarios.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario usuario = new FormUsuario();
            usuario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin salir = new FormLogin();
            salir.Show();
         //   this.Close();

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.MdiParent = this;
            formAgregar.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
