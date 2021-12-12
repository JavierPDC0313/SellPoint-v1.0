using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormAgregarGruposEntidades : Form
    {
        private int Eliminable = 0;

        private MantenimientoGruposEntidades _mantenimiento;
        public FormAgregarGruposEntidades()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoGruposEntidades(connection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validations() == false)
            {
                if (_mantenimiento.Agregar(_mantenimiento.CrearObjeto(TxtDescripcion.Text, TxtComentario.Text, CmbStatus.Text, Eliminable, DtpFecha.Value)))
                {
                    MessageBox.Show("Se ha agregado con éxito", "notificacion");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error inesperado. Intentalo de nuevo", "advertencia");
                }
            }
        }

        private void CkbYes_CheckedChanged(object sender, EventArgs e)
        {
            CkbNo.Checked = false;
            Eliminable = 1;
        }

        private void CkbNo_CheckedChanged(object sender, EventArgs e)
        {
            CkbYes.Checked = false;
            Eliminable = 0;
        }

        private bool Validations()
        {
            bool isEmpty = true;

            if (TxtDescripcion.Text == "")
            {
                MessageBox.Show("Debe insertar una descripcion", "Advertencia");
            }
            else if (TxtComentario.Text == "")
            {
                MessageBox.Show("Debe insertar una direccion", "Advertencia");
            }
            else if (CkbNo.Checked == false && CkbYes.Checked == false)
            {
                MessageBox.Show("Debe seleccionar si es eliminable", "Advertencia");
            }
            else
            {
                isEmpty = false;
            }

            return isEmpty;
        }

        private void FormAgregarGruposEntidades_Load(object sender, EventArgs e)
        {
            CmbStatus.SelectedItem = CmbStatus.FindStringExact("Activa");
        }
    }
}
