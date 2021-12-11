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
    public class RepositorioEntidades
    {

        public SqlConnection _conexion;
        public RepositorioEntidades(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public bool Agregar(Entidades entidad)
        {
            SqlCommand comando = new SqlCommand(@"insert into Entidades values (@descripcion, @direccion, @localidad, @tipoEntidad,
            @tipoDocumento, @numeroDocumento, @telefono, @urlPaginaWeb, @urlFacebook, @urlInstagram, @urlTwitter, @urlTikTok, @idGrupoEntidad,
            @idTipoEntidad, @limiteCredito, @userNameEntidad, @passwordEntidad, @rolUserEntidad, @comentario, @status, @noEliminable, @fechaRegistro)", _conexion);

            comando.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            comando.Parameters.AddWithValue("@direccion", entidad.Direccion);
            comando.Parameters.AddWithValue("@localidad", entidad.Localidad);
            comando.Parameters.AddWithValue("@tipoEntidad", entidad.TipoEntidad);
            comando.Parameters.AddWithValue("@tipoDocumento", entidad.TipoDocumento);
            comando.Parameters.AddWithValue("@numeroDocumento", entidad.NumeroDocumento);
            comando.Parameters.AddWithValue("@telefono", entidad.Teléfonos);
            comando.Parameters.AddWithValue("@urlPaginaWeb", entidad.URLPaginaWeb);
            comando.Parameters.AddWithValue("@urlFacebook", entidad.URLFacebook);
            comando.Parameters.AddWithValue("@urlInstagram", entidad.URLInstagram);
            comando.Parameters.AddWithValue("@urlTwitter", entidad.URLTwitter);
            comando.Parameters.AddWithValue("@urlTikTok", entidad.URLTikTok);
            comando.Parameters.AddWithValue("@idGrupoEntidad", entidad.IdGrupoEntidad);
            comando.Parameters.AddWithValue("@idTipoEntidad", entidad.IdTipoEntidad);
            comando.Parameters.AddWithValue("@limiteCredito", entidad.LimiteCredito);
            comando.Parameters.AddWithValue("@userNameEntidad", entidad.UserNameEntidad);
            comando.Parameters.AddWithValue("@passwordEntidad", entidad.PasswordEntidad);
            comando.Parameters.AddWithValue("@rolUserEntidad", entidad.RolUserEntidad);
            comando.Parameters.AddWithValue("@comentario", entidad.Comentario);
            comando.Parameters.AddWithValue("@status", entidad.Status);
            comando.Parameters.AddWithValue("@noEliminable", entidad.NoEliminable);
            comando.Parameters.AddWithValue("@fechaRegistro", entidad.FechaRegistro);

            return EjecutarConsulta(comando);
        }

        public bool Eliminar(int id)
        {
            SqlCommand comando = new SqlCommand("Delete Entidades where IdEntidad = @id", _conexion);

            comando.Parameters.AddWithValue("@id", id);

            return EjecutarConsulta(comando);
        }

        public bool Editar(Entidades entidad)
        {
            SqlCommand comando = new SqlCommand(@"Update Entidades set Descripcion = @descripcion, Direccion = @direccion, Localidad = @localidad, TipoEntidad = @tipoEntidad,
            TipoDocumento = @tipoDocumento, NumeroDocumento = @numeroDocumento, Teléfonos = @telefono, URLPaginaWeb = @urlPaginaWeb, URLFacebook = @urlFacebook,
            URLInstagram = @urlInstagram, URLTwitter = @urlTwitter, URLTikTok = @urlTikTok, IdGrupoEntidad = @idGrupoEntidad,
            IdTipoEntidad = @idTipoEntidad, LimiteCredito = @limiteCredito, UserNameEntidad = @userNameEntidad, PasswordEntidad = @passwordEntidad, RolUserEntidad = @rolUserEntidad, 
            Comentario = @comentario, Status = @status, NoEliminable = @noEliminable, FechaIngreso = @fechaRegistro)", _conexion);

            comando.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            comando.Parameters.AddWithValue("@direccion", entidad.Direccion);
            comando.Parameters.AddWithValue("@localidad", entidad.Localidad);
            comando.Parameters.AddWithValue("@tipoEntidad", entidad.TipoEntidad);
            comando.Parameters.AddWithValue("@tipoDocumento", entidad.TipoDocumento);
            comando.Parameters.AddWithValue("@numeroDocumento", entidad.NumeroDocumento);
            comando.Parameters.AddWithValue("@telefono", entidad.Teléfonos);
            comando.Parameters.AddWithValue("@urlPaginaWeb", entidad.URLPaginaWeb);
            comando.Parameters.AddWithValue("@urlFacebook", entidad.URLFacebook);
            comando.Parameters.AddWithValue("@urlInstagram", entidad.URLInstagram);
            comando.Parameters.AddWithValue("@urlTwitter", entidad.URLTwitter);
            comando.Parameters.AddWithValue("@urlTikTok", entidad.URLTikTok);
            comando.Parameters.AddWithValue("@idGrupoEntidad", entidad.IdGrupoEntidad);
            comando.Parameters.AddWithValue("@idTipoEntidad", entidad.IdTipoEntidad);
            comando.Parameters.AddWithValue("@limiteCredito", entidad.LimiteCredito);
            comando.Parameters.AddWithValue("@userNameEntidad", entidad.UserNameEntidad);
            comando.Parameters.AddWithValue("@passwordEntidad", entidad.PasswordEntidad);
            comando.Parameters.AddWithValue("@rolUserEntidad", entidad.RolUserEntidad);
            comando.Parameters.AddWithValue("@comentario", entidad.Comentario);
            comando.Parameters.AddWithValue("@status", entidad.Status);
            comando.Parameters.AddWithValue("@noEliminable", entidad.NoEliminable);
            comando.Parameters.AddWithValue("@fechaRegistro", entidad.FechaRegistro);

            return EjecutarConsulta(comando);
        }

        public DataTable Listar()
        {
            SqlDataAdapter lista = new SqlDataAdapter("select * From Vw_Entidades", _conexion);

            return ObtenerDatos(lista);
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
