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

        public bool Editar(GruposEntidades entidad)
        {
            SqlCommand comando = new SqlCommand(@"Update GruposEntidades set Descripcion = @descripcion, Comentario = @comentario, Status = @status, NoEliminable = @noEliminable, FechaRegistro = @fechaRegistro where IdGrupoEntidad = @id", _conexion);

            comando.Parameters.AddWithValue("@id", entidad.IdGrupoEntidad);
            comando.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            comando.Parameters.AddWithValue("@comentario", entidad.Comentario);
            comando.Parameters.AddWithValue("@status", entidad.Status);
            comando.Parameters.AddWithValue("@noEliminable", entidad.NoEliminable);
            comando.Parameters.AddWithValue("@fechaRegistro", entidad.FechaRegistro);

            _conexion.Close();


            return EjecutarConsulta(comando);
        }

        public DataTable Listar()
        {
            SqlDataAdapter comando = new SqlDataAdapter("select * from GruposEntidades", _conexion);

            return ObtenerDatos(comando);
        }

        public GruposEntidades EnlistarPorId(int id)
        {
            _conexion.Close();
            try
            {
                _conexion.Open();

                GruposEntidades entidad = new GruposEntidades();

                SqlCommand sqlCommand = new SqlCommand("select * from GruposEntidades where IdGrupoEntidad = @id", _conexion);

                sqlCommand.Parameters.AddWithValue("@id", id);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    entidad.IdGrupoEntidad = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    entidad.Descripcion = dataReader.IsDBNull(1) ? "NULL" : dataReader.GetString(1);
                    entidad.Comentario = dataReader.IsDBNull(2) ? "NULL" : dataReader.GetString(2);
                    entidad.Status = dataReader.IsDBNull(3) ? "NULL" : dataReader.GetString(3);
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
