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
    public partial class FormAgregarEntidades : Form
    {
        private int Eliminable = 0;

        private MantenimientoEntidades _mantenimiento;
        public FormAgregarEntidades()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoEntidades(connection);

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText == "RNC")
            {
                TxtNumDocumento.Mask = "000-00000-0";
            }
            else if (comboBox1.SelectedText == "Cedula")
            {
                TxtNumDocumento.Mask = "000-0000000-0";
            }
            else if (comboBox1.SelectedText == "Pasaporte")
            {
                TxtNumDocumento.Mask = "ZAB000000";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CkbNo.Checked = false;
            Eliminable = 1;
        }

        private void CkbNo_CheckedChanged(object sender, EventArgs e)
        {
            CkbYes.Checked = false;
            Eliminable = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validations() == false)
            {
                if (_mantenimiento.Agregar(_mantenimiento.CrearObjeto(TxtDescripcion.Text, TxtDireccion.Text, TxtLocalidad.Text, CmbEntidad.Text, TxtNumDocumento.Text, TxtTelefono.Text, 1, 1, Convert.ToInt32(TxtLimite.Text), TxtUsuario.Text, TxtContraseña.Text, CmbRol.Text, CmbStatus.Text, Eliminable, DtpFecha.Value)))
                {
                    MessageBox.Show("Se ha agregado con éxito","notificacion");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error inesperado. Intentalo de nuevo", "advertencia");
                }
            }
        }

        private bool Validations()
        {
            bool isEmpty = true;

            if (TxtDescripcion.Text == "")
            {
                MessageBox.Show("Debe insertar una descripcion", "Advertencia");
            }
            else if (TxtDireccion.Text == "")
            {
                MessageBox.Show("Debe insertar una direccion", "Advertencia");
            }
            else if (TxtLocalidad.Text == "")
            {
                MessageBox.Show("Debe insertar una localidad", "Advertencia");
            }
            else if (TxtNumDocumento.Text == "")
            {
                MessageBox.Show("Debe insertar un numero de documento", "Advertencia");
            }
            else if (TxtTelefono.Text == "")
            {
                MessageBox.Show("Debe insertar un telefono", "Advertencia");
            }
            else if (TxtUsuario.Text == "")
            {
                MessageBox.Show("Debe insertar un nombre de usuario", "Advertencia");
            }
            else if (TxtContraseña.Text == "")
            {
                MessageBox.Show("Debe insertar una contraseña", "Advertencia");
            }
            else if (TxtLimite.Text == "")
            {
                MessageBox.Show("Debe insertar un limite", "Advertencia");
            }
            else
            {
                isEmpty = false;
            }

            return isEmpty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormAgregarEntidades_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
