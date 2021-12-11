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
    class MantenimientoGruposEntidades
    {
        private RepositorioGruposEntidades repo;
        public MantenimientoGruposEntidades(SqlConnection conexion)
        {
            repo = new RepositorioGruposEntidades(conexion);
        }

        public bool Agregar(GruposEntidades item)
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
