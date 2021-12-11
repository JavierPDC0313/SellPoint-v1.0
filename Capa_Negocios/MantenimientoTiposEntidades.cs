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
    public class MantenimientoTiposEntidades
    {
        private RepositorioTiposEntidades repo;

        public MantenimientoTiposEntidades(SqlConnection conexion)
        {
            repo = new RepositorioTiposEntidades(conexion);
        }

        public bool Agregar(TiposEntidades item)
        {
            return repo.Agregar(item);
        }

        public bool Eliminar(int id)
        {
            return repo.Eliminar(id);
        }

        public DataTable Listar()
        {
            return repo.Listar();
        }
    }
}
