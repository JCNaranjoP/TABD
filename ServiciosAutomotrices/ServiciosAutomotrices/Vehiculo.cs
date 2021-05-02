using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosAutomotrices
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public List<Visita> Visitas { get; set; }


        public Vehiculo()
        {
            Placa = "";
            Marca = "";
            Modelo = 0;
        }
    }
}
