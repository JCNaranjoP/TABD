using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosAutomotrices
{
    public class Visita
    {
        public string Fecha { get; set; }
        public string Sede { get; set; }
        public string Servicio { get; set; }

        public Visita()
        {
            Fecha = "";
            Servicio = "";
            Sede = "";
        }
    }
}
