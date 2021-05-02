using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domicilios_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Domicilio> lista = AccesoDatos.ObtieneListaDomicilios(2);

            lista.ForEach(c => AccesoDatos.ObtieneListaDomicilios(2).Add(c));

            foreach(var i in lista)
            {
                Console.WriteLine(i.Agente);
            }
            Console.ReadKey();
        }
    }
}
