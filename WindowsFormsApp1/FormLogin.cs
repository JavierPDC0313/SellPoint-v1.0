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

        private void lbUser_Click(object sender, EventArgs e)
        {

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

        private void btnLogin_Click(object sender, EventArgs e)
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
                        FormMenu.Instancia.Show();
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
    }
}
