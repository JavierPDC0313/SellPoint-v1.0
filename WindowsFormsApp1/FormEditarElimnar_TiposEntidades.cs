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
using System.Configuration ;
using Capa_Datos.Modelos ;
using System.Data.SqlClient ;
namespace WindowsFormsApp1
{
    public partial class FormEditarElimnar_TiposEntidades : Form
    {
        MantenimientoTiposEntidades _mantenimiento;

        TiposEntidades  entidad  =  new TiposEntidades();

        private int idTipoIdentidad;

        private int Eliminable = 0;


        public FormEditarElimnar_TiposEntidades()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoTiposEntidades(connection);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (idTipoIdentidad >= 0)
            {
                DialogResult dialogo = MessageBox.Show("Estas seguro de que deseas borrar?", "Advertencia", MessageBoxButtons.YesNo);

                if (dialogo == DialogResult.Yes)
                {
                    _mantenimiento.Eliminar(idTipoIdentidad);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idTipoIdentidad >= 0)
            {
                if (_mantenimiento.Editar(_mantenimiento.CrearObjeto(TxtDescripcion.Text,txtComentario.Text,CmbStatus.Text, Eliminable, DtpFecha.Value)))
                {
                    MessageBox.Show("Editado con exito", "notificacion");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error inesperado. Intentalo de nuevo", "advertencia");
                }
            }
        }
    }
}
