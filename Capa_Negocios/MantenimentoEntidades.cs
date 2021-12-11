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
    
    }
}
