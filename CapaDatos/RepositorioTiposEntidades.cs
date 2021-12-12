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
        public bool Editar(TiposEntidades entidad)
        {
            SqlCommand comando = new SqlCommand(@"Update TiposEntidades set Descripcion = @descripcion, IdGrupoEntidad = @idGrupoEntidad, Comentario = @comentario, Status = @status, NoEliminable = @noEliminable, FechaRegistro = @fechaRegistro where IdTipoEntidad = @id", _conexion);

            comando.Parameters.AddWithValue("@id", entidad.IdTipoEntidad);
            comando.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            comando.Parameters.AddWithValue("@idGrupoEntidad", entidad.IdGrupoEntidad);
            comando.Parameters.AddWithValue("@comentario", entidad.Comentario);
            comando.Parameters.AddWithValue("@status", entidad.Status);
            comando.Parameters.AddWithValue("@noEliminable", entidad.NoEliminable);
            comando.Parameters.AddWithValue("@fechaRegistro", entidad.FechaRegistro);

            _conexion.Close();


            return EjecutarConsulta(comando);
        }

        public DataTable Listar()
        {
            SqlDataAdapter comando = new SqlDataAdapter("select * from TiposEntidades", _conexion);

            return ObtenerDatos(comando);
        }

        public TiposEntidades EnlistarPorId(int id)
        {
            _conexion.Close();
            try
            {
                _conexion.Open();

                TiposEntidades entidad = new TiposEntidades();

                SqlCommand sqlCommand = new SqlCommand("select * from TiposEntidades where IdTipoEntidad = @id", _conexion);

                sqlCommand.Parameters.AddWithValue("@id", id);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    entidad.IdTipoEntidad = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    entidad.Descripcion = dataReader.IsDBNull(1) ? "NULL" : dataReader.GetString(1);
                    entidad.IdGrupoEntidad = dataReader.IsDBNull(2) ? 0 : dataReader.GetInt32(2);
                    entidad.Comentario = dataReader.IsDBNull(3) ? "NULL" : dataReader.GetString(3);
                    entidad.Status = dataReader.IsDBNull(4) ? "NULL" : dataReader.GetString(4);
                    entidad.NoEliminable = 1;
                    entidad.FechaRegistro = DateTime.Now;
                }

                dataReader.Close();
                dataReader.Dispose();

                _conexion.Close();

                return entidad;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
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
                Console.Write(e.Message);
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
