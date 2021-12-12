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
    public partial class FormAgregarTipoEntidades : Form
    {
        private int Eliminable = 0;

        private MantenimientoTiposEntidades _mantenimiento1;
        public FormAgregarTipoEntidades()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento1 = new MantenimientoTiposEntidades(connection);
        }
        private bool Validations()
        {
            bool isEmpty = true;

            if (TxtDescripcion.Text == "")
            {
                MessageBox.Show("Debe insertar una descripcion", "Advertencia");
            }
            else
            {
                isEmpty = false;
            }

            return isEmpty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validations() == false)
            {
                if (_mantenimiento1.Agregar(_mantenimiento1.CrearObjeto(1, TxtDescripcion.Text,txtComentario.Text, CmbStatus.Text, Eliminable, DtpFecha.Value)))
                {
                    MessageBox.Show("Se ha agregado con éxito", "notificacion");
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
            CkbNo.Checked = false;
            Eliminable = 0;
        }
    }
}
