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
using Capa_Datos.Modelos;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormEditar_EliminarEntidades : Form
    {
        MantenimientoEntidades _mantenimiento;

        private Entidades entidad = new Entidades();

        private int id;

        private int Eliminable = 0;
        public FormEditar_EliminarEntidades()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoEntidades(connection);
        }

        private void FormEditar_EliminarEntidades_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DgvEntidades.DataSource = _mantenimiento.Listar();
            DgvEntidades.Refresh();
            DgvEntidades.ClearSelection();
        }

        private void DgvEntidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(DgvEntidades.Rows[e.RowIndex].Cells[0].Value.ToString());


                entidad = _mantenimiento.EnlistarPorId(id)
;
                TxtDescripcion.Text = entidad.Descripcion;
                TxtDireccion.Text = entidad.Direccion;
                TxtLocalidad.Text = entidad.Localidad;
                CmbEntidad.FindStringExact(entidad.TipoEntidad);
                CmbTipoDoc.FindStringExact(entidad.TipoDocumento);
                TxtNumDoc.Text = entidad.NumeroDocumento;
                TxtUsuario.Text = entidad.UserNameEntidad;
                TxtLimite.Text = Convert.ToString(entidad.LimiteCredito);
                CmbRol.FindStringExact(entidad.RolUserEntidad);
                CmbStatus.FindStringExact(entidad.Status);
                if (entidad.NoEliminable == 0)
                {
                    CkbNo.Checked = true;
                }
                else
                {
                    CkbYes.Checked = true;
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                DialogResult dialogo = new DialogResult();
                dialogo = MessageBox.Show("Estas seguro de que deseas borrar?", "Advertencia", MessageBoxButtons.YesNo);
                
                if (dialogo == DialogResult.Yes)
                {
                    _mantenimiento.Eliminar(id);
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                if(_mantenimiento.Editar(_mantenimiento.CrearObjeto(TxtDescripcion.Text, TxtDireccion.Text, TxtLocalidad.Text, CmbEntidad.Text, CmbTipoDoc.Text, TxtNumDoc.Text, "", 1, 1, Convert.ToInt32(TxtLimite.Text), TxtUsuario.Text, TxtPass.Text, CmbRol.Text, CmbStatus.Text, Eliminable, DtpFecha.Value))) 
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
