using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos.Modelos;

namespace Capa_Negocios
{
    public class Presentacion
    {
        public string FormateoDocumento(Entidades item)
        {
            string retorno = "";

            if (item.TipoDocumento == "RNC")
            {
                retorno = "B" + Convert.ToString(item.NumeroDocumento);
            }
            else if (item.TipoDocumento == "Cédula")
            {
                retorno = item.NumeroDocumento.Insert(3, "-");
                retorno = retorno.Insert(9, "-");
                retorno.Remove(10);
            }
            else if (item.TipoDocumento == "Pasaporte")
            {
                retorno = item.NumeroDocumento.Remove(7);
            }

            return retorno;
        }
    }
}
