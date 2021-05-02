using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domicilios_JSON
{
    class Hogar
    {
        public int IdHogar { get; set; }
        public string Municipio { get; set; }
        public List<Domicilio> ListaDomicilios { get; set; }

        public Hogar()
        {
            IdHogar = 0;
            Municipio = "";
        }
    }
}
