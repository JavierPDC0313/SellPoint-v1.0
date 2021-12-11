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
using Capa_Negocios;
using Capa_Datos.Modelos;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        MantenimientoEntidades _mantenimiento;
        private FormLogin()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoEntidades(connection);
        }

        public static FormLogin Instancia { get; set; } = new FormLogin();

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar() == false)
            {
                if (_mantenimiento.UsuarioExiste(tbUser.Text) == true)
                {
                    Entidades entidad = new Entidades();
                    entidad = _mantenimiento.EnlistarPorUser(tbUser.Text);
                    if (entidad.PasswordEntidad == tbContraseña.Text)
                    {
                        MessageBox.Show("Bienvenido");
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Advertencia");
                    }
                }
                else
                {
                    MessageBox.Show("Este usuario no existe", "Advertencia");
                }
            }
        }

        private bool Validar()
        {
            bool isEmpty = true;
            if (tbUser.Text == "")
            {
                MessageBox.Show("Debe insertar su usuario", "Advertencia");
            }
            else if (tbContraseña.Text == "")
            {
                MessageBox.Show("Debe insertar su contraseña", "Advertencia");
            }
            else
            {
                isEmpty = false;
            }

            return isEmpty;
        }
    }
}
