using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domicilios_JSON
{
    class Domicilio
    {
        public string Fecha { get; set; }
        public int Agente { get; set; }
        public string Mediopago { get; set; }
        public string Mediotransporte { get; set; }
        public string Plataforma { get; set; }
        public string Tipodomicilio { get; set; }

        public Domicilio()
        {
            Fecha = "";
            Agente = 0;
            Mediopago = "";
            Mediotransporte = "";
            Plataforma = "";
            Tipodomicilio = "";
        }
    }
}
