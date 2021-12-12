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

        private int id;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                if (_mantenimiento.Editar(_mantenimiento.CrearObjeto(id, TxtDescripcion.Text,txtComentario.Text,CmbStatus.Text, Eliminable, DtpFecha.Value)))
                {
                    MessageBox.Show("Editado con exito", "notificacion");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error inesperado. Intentalo de nuevo", "advertencia");
                }
            }
        }

        private void FormEditarElimnar_TiposEntidades_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DgvTiposEntidades.Refresh();
            DgvTiposEntidades.DataSource = _mantenimiento.Listar();
            DgvTiposEntidades.Columns[0].Visible = false;
            DgvTiposEntidades.ClearSelection();
        }

        private void DgvTiposEntidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    id = Convert.ToInt32(DgvTiposEntidades.Rows[e.RowIndex].Cells[0].Value.ToString());


                    entidad = _mantenimiento.EnlistarPorId(id)
    ;
                    TxtDescripcion.Text = entidad.Descripcion;
                    txtComentario.Text = entidad.Comentario;
                    CmbStatus.Text = entidad.Status;
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
            catch
            {
                id = 0;
            }
        }
    }
}
