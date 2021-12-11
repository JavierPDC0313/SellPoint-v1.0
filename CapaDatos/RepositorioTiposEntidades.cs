using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Datos.Modelos;

namespace Capa_Datos
{
    public class RepositorioTiposEntidades
    {

        private SqlConnection _conexion;

        public 
            RepositorioTiposEntidades(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public bool Agregar(TiposEntidades item)
        {
            SqlCommand comando = new SqlCommand(@"insert into TiposEntidades values(@descripcion, @idGrupoEntidad, @comentario, @status, @noEliminable, @fechaRegistro)", _conexion);

            comando.Parameters.AddWithValue("@descripcion", item.Descripcion);
            comando.Parameters.AddWithValue("@idGrupoEntidad", item.IdGrupoEntidad);
            comando.Parameters.AddWithValue("@comentario", item.Comentario);
            comando.Parameters.AddWithValue("@status", item.Status);
            comando.Parameters.AddWithValue("@noEliminable", item.NoEliminable);
            comando.Parameters.AddWithValue("@fechaRegistro", item.FechaRegistro);

            return EjecutarConsulta(comando);
        }

        public bool Eliminar(int id)
        {
            SqlCommand comando = new SqlCommand("Delete TiposEntidades where IdTipoEntidad = @id", _conexion);

            comando.Parameters.AddWithValue("@id", id);

            return EjecutarConsulta(comando);
        }

        public DataTable Listar()
        {
            SqlDataAdapter comando = new SqlDataAdapter("select * from TiposEntidades", _conexion);

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
