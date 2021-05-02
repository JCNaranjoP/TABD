using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Configuration;
using System.Text;
using Newtonsoft.Json;

namespace ServiciosAutomotrices
{
    public class AccesoDatos
    {
        /// <summary>
        /// Obtiene la cadena de conexión a la DB a partir del archivo de configuración de la App
        /// </summary>
        private static string ObtenerCadenaConexion(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        /// <summary>
        /// Obtiene una lista con las placas de los vehiculos - Utiliza Dapper
        /// </summary>
        public static List<string> ObtenerPlacas()
        {
            string cadenaConexion = ObtenerCadenaConexion("DBServicios");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                //Solo obtiene las placas de los vehiculos con servicios registrados
                var salida = cxnDB.Query<string>("select distinct placa_vehiculo placa from visitas order by placa_vehiculo", new DynamicParameters());
                return salida.ToList();
            }
        }

        private static List<Visita> ObtieneListaVisitasVehiculo(string placaVehiculo)
        {
            string cadenaConexion = ObtenerCadenaConexion("DBServicios");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                string sentenciaSQL = "select distinct vt.fecha, sd.nombre sede, sv.nombre servicio " +
                    "from visitas vt inner join sedes sd on vt.codigo_sede = sd.codigo inner join servicios sv on " +
                    "vt.codigo_servicio = sv.codigo where vt.placa_vehiculo = @p_placa order by 1";


                //la placa se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@p_placa", placaVehiculo, DbType.String, ParameterDirection.Input);
                var salida = cxnDB.Query<Visita>(sentenciaSQL, parametrosSentencia);

                return salida.ToList();
            }
        }

        /// <summary>
        /// Obtiene un objeto vehiculo a partir de la identificación dada por la placa
        /// </summary>
        /// <param name="placaVehiculo">placa del vehiculo</param>
        /// <returns>el vehiculo registrado</returns>
        public static Vehiculo ObtieneVehiculo(string placaVehiculo)
        {
            Vehiculo vehiculoResultado = new Vehiculo();

            string cadenaConexion = ObtenerCadenaConexion("DBServicios");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "select placa, marca, modelo from vehiculos where placa = @p_placa";

                //La placa se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@p_placa", placaVehiculo, DbType.String, ParameterDirection.Input);

                var salida = cxnDB.Query<Vehiculo>(sentenciaSQL, parametrosSentencia);

                //validamos cuantos registros devuelve la lista
                if (salida.ToArray().Length != 0)
                { 
                    vehiculoResultado = salida.First();
                    vehiculoResultado.Visitas = ObtieneListaVisitasVehiculo(placaVehiculo);
                }

                return vehiculoResultado;
            }
        }

        public static string ObtieneJsonDBVehiculos()
        {
            string cadenaConexion = ObtenerCadenaConexion("DBServicios");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {

                // se define la sentencia SQL a utilizar, pero sin concatenar el id
                string sentenciaSQL = "select placa, marca, modelo from vehiculos order by placa";

                var salida = cxnDB.Query<Vehiculo>(sentenciaSQL, new DynamicParameters());

                List<Vehiculo> losVehiculos = salida.ToList();

                //actualizamos la lista de visitas de cada vehiculo en la lista
                foreach (Vehiculo unVehiculo in losVehiculos)                
                    unVehiculo.Visitas = ObtieneListaVisitasVehiculo(unVehiculo.Placa);
                
                string jsonResultado = JsonConvert.SerializeObject(losVehiculos, Formatting.Indented);

                return jsonResultado;
            }
        }

        public static string ObtieneJsonVehiculo(string placaVehiculo)
        {
            Vehiculo elVehiculo = ObtieneVehiculo(placaVehiculo);

            string jsonVehiculo = JsonConvert.SerializeObject(elVehiculo, Formatting.Indented);
            return jsonVehiculo;
        }

        public static DataTable ObtieneTotalMarca()
        {
            DataTable tablaResultado = new DataTable();

            string cadenaConexion = ObtenerCadenaConexion("DBServicios");

            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                string sentenciaSQL = "select distinct vh.marca nombre_marca, count(distinct vt.placa_vehiculo) total_marca from visitas vt inner join vehiculos vh on vt.placa_vehiculo = vh.placa group by vh.marca";

                SQLiteDataAdapter daMarcas = new SQLiteDataAdapter(sentenciaSQL, cxnDB);
                daMarcas.Fill(tablaResultado);
                return tablaResultado;
            }
        }

        public static DataTable ObtieneTotalSede()
        {
            DataTable tablaResultado = new DataTable();

            string cadenaConexion = ObtenerCadenaConexion("DBServicios");

            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                string sentenciaSQL = "select distinct sd.nombre nombre_sede, count(vt.fecha) total_sede from visitas vt " + 
                    " join sedes sd on vt.codigo_sede = sd.codigo group by sd.nombre order by 2 desc";

                SQLiteDataAdapter daSedes = new SQLiteDataAdapter(sentenciaSQL, cxnDB);
                daSedes.Fill(tablaResultado);
                return tablaResultado;
            }
        }

        public static DataTable ObtieneTotalServicio()
        {
            DataTable tablaResultado = new DataTable();

            string cadenaConexion = ObtenerCadenaConexion("DBServicios");

            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                string sentenciaSQL = "select distinct sv.nombre nombre_servicio, count(vt.fecha) total_servicio from visitas vt " +
                    " join servicios sv on vt.codigo_servicio = sv.codigo group by sv.nombre order by 2 desc";

                SQLiteDataAdapter daServicios = new SQLiteDataAdapter(sentenciaSQL, cxnDB);
                daServicios.Fill(tablaResultado);
                return tablaResultado;
            }
        }

        public static DataTable ObtieneServiciosPlaca(string placaVehiculo)
        {
            DataTable tablaResultado = new DataTable();
            string cadenaConexion = ObtenerCadenaConexion("DBServicios");

            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                string sentenciaSQL = "select distinct vt.fecha fecha_servicio, sd.nombre sede_servicio, sv.nombre nombre_servicio " +
                   "from visitas vt inner join sedes sd on vt.codigo_sede = sd.codigo inner join servicios sv on " +
                   "vt.codigo_servicio = sv.codigo where vt.placa_vehiculo = @p_placa order by 1";

                SQLiteParameter paramPlaca = new SQLiteParameter("p_placa", DbType.String, 6);
                paramPlaca.Value = placaVehiculo;

                SQLiteDataAdapter daServiciosPlaca = new SQLiteDataAdapter(sentenciaSQL, cxnDB);
                daServiciosPlaca.SelectCommand.Parameters.Add(paramPlaca);

                daServiciosPlaca.Fill(tablaResultado);

                return tablaResultado;
            }
        }
    }
}


