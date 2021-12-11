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
    public class MantenimientoGruposEntidades
    {
        private RepositorioGruposEntidades repo;
        public MantenimientoGruposEntidades(SqlConnection conexion)
        {
            repo = new RepositorioGruposEntidades(conexion);
        }

        public GruposEntidades CrearObjeto(string descripcion, string comentario, string status, int eliminable, DateTime fecha)
        {
            GruposEntidades newItem = new GruposEntidades
            {
                Descripcion = descripcion,
                Comentario = comentario,
                Status = status,
                NoEliminable = eliminable,
                FechaRegistro = fecha
            };

            return newItem;
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
