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
        private FormMenu()
        {
            InitializeComponent();
        }

        public static FormMenu Instancia { get; set; } = new FormMenu();

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void atsmInventario_Click(object sender, EventArgs e)
        {
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstudiantes Usuarios = new FormEstudiantes();
            Usuarios.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario usuario = new FormUsuario();
            usuario.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin.Instancia.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editarEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditar_EliminarEntidades Form = new FormEditar_EliminarEntidades();
            Form.MdiParent = this;
            Form.Show();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormAgregarGruposEntidades Frm = new FormAgregarGruposEntidades();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEditarGruposEntidades Frm = new FormEditarGruposEntidades();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormAgregarTipoEntidades Frm = new FormAgregarTipoEntidades();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAgregarEntidades Frm = new FormAgregarEntidades();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditarElimnar_TiposEntidades Frm = new FormEditarElimnar_TiposEntidades();
            Frm.MdiParent = this;
            Frm.Show();
        }
    }
}
