using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Datos.Modelos;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Negocios
{
    public class MantenimientoEntidades
    {
        private RepositorioEntidades repo;
    
        public MantenimientoEntidades(SqlConnection conexion)
        {
            repo = new RepositorioEntidades(conexion);
        }

        public Entidades CrearObjeto(string descripcion, string direccion, string localidad, string tipoEntidad, string tipoDoc, string numeroDoc, string telefono, int idGrupoEntidad, int idTipoEntidad, int LimiteCredito, string userName, string Pass, string rol, string Status, int eliminable, DateTime fecha)
        {
            Entidades entidad = new Entidades {
                Descripcion = descripcion,
                Direccion = direccion,
                Localidad = localidad,
                TipoEntidad = tipoEntidad,
                TipoDocumento = tipoDoc,
                NumeroDocumento = numeroDoc,
                Teléfonos = telefono,
                URLPaginaWeb = "www",
                URLFacebook = "www",
                URLInstagram = "www",
                URLTikTok = "www",
                URLTwitter = "www",
                IdGrupoEntidad = idGrupoEntidad,
                IdTipoEntidad = idTipoEntidad,
                LimiteCredito = LimiteCredito,
                UserNameEntidad = userName,
                PasswordEntidad = Pass,
                RolUserEntidad = rol,
                Comentario = "no comentarios",
                Status = Status,
                NoEliminable = eliminable,
                FechaRegistro = fecha
                };

            return entidad;
        }

        public bool Agregar(Entidades entidad)
        {
            return repo.Agregar(entidad);
        }

        public bool Editar(Entidades entidad)
        {
            return repo.Editar(entidad);
        }

        public bool Eliminar(int id)
        {
            return repo.Eliminar(id);
        }

        public DataTable Listar()
        {
            return repo.Listar();
        }

        public Entidades EnlistarPorId(int id)
        {
            return repo.EnlistarPorId(id);
        }

        public bool UsuarioExiste(string userName)
        {
            return repo.UsuarioExiste(userName);
        }

        public Entidades EnlistarPorUser(string userName)
        {
            return repo.EnlistarPorUser(userName);
        }
    }
}
