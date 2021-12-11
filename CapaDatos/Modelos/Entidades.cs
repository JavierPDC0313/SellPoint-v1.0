using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Modelos
{
    public class Entidades
    {
        public int IdEntidad { get; set; }

        public string Descripcion { get; set; }

        public string Direccion { get; set; }

        public string Localidad { get; set; }

        public string TipoEntidad { get; set; }

        public string TipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string Teléfonos { get; set; }

        public string URLPaginaWeb { get; set; }

        public string URLFacebook { get; set; }

        public string URLInstagram { get; set; }

        public string URLTwitter { get; set; }

        public string URLTikTok { get; set; }

        public int IdGrupoEntidad { get; set; }

        public int IdTipoEntidad { get; set; }

        public int LimiteCredito { get; set; }

        public string UserNameEntidad { get; set; }

        public string PasswordEntidad { get; set; }

        public string RolUserEntidad { get; set; }

        public string Comentario { get; set; }

        public string Status { get; set; }

        public int NoEliminable { get; set; }

        public DateTime FechaRegistro { get; set; }

        public Entidades()
        {
            this.TipoEntidad = "Jurídica";
            this.TipoDocumento = "RNC";
            this.LimiteCredito = 0;
            this.RolUserEntidad = "User";
            this.Status = "Activa";
            this.NoEliminable = 0;
            this.FechaRegistro = DateTime.Now;
        }
    }
}
