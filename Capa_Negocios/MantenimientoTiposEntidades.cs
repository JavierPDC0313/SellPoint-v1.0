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
        public Entidades CrearObjeto(string descripcion, string Comentario,  string Status, int eliminable, DateTime fecha)
        {
            Entidades entidad = new Entidades
            {
                Descripcion = descripcion,
                Comentario = "no comentarios",
                Status = Status,
                NoEliminable = eliminable,
                FechaRegistro = fecha
            };

            return entidad;
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
