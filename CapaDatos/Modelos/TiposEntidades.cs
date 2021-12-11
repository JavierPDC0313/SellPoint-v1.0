using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Modelos
{
    public class TiposEntidades
    {

        public int IdTipoEntidad { get; set; }

        public string Descripcion { get; set; }

        public int IdGrupoEntidad { get; set; }

        public string Comentario { get; set; }

        public string Status { get; set; }

        public int NoEliminable { get; set; }

        public DateTime FechaRegistro { get; set; }

    }
}

