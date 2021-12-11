using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos.Modelos;

namespace Capa_Datos
{
    public class RepositorioGruposEntidades
    {
        private SqlConnection _conexion;

        public RepositorioGruposEntidades(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public bool Agregar(GruposEntidades item)
        {
            SqlCommand comando = new SqlCommand(@"insert into GruposEntidades values(@descripcion, @comentario, @status, @noEliminable, @fechaRegistro)", _conexion);

            comando.Parameters.AddWithValue("@descripcion", item.Descripcion);
            comando.Parameters.AddWithValue("@comentario", item.Comentario);
            comando.Parameters.AddWithValue("@status", item.Status);
            comando.Parameters.AddWithValue("@noEliminable", item.NoEliminable);
            comando.Parameters.AddWithValue("@fechaRegistro", item.FechaRegistro);

            return EjecutarConsulta(comando);
        }

        public bool Eliminar(int id)
        {
            SqlCommand comando = new SqlCommand("Delete GrupoEntidades where IdGrupoEntidad = @id", _conexion);

            comando.Parameters.AddWithValue("@id", id);

            return EjecutarConsulta(comando);
        }

        public DataTable Listar()
        {
            SqlDataAdapter comando = new SqlDataAdapter("select * from GruposEntidades", _conexion);

            return ObtenerDatos(comando);
        }

        private bool EjecutarConsulta(SqlCommand command)
        {
            try
            {
                _conexion.Open();
                command.ExecuteNonQuery();
                _conexion.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private DataTable ObtenerDatos(SqlDataAdapter dataAdapter)
        {
            try
            {
                DataTable data = new DataTable();

                _conexion.Open();
                dataAdapter.Fill(data);
                _conexion.Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
