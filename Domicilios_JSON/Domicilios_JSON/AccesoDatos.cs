using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Configuration;
using System.Text;
using Newtonsoft.Json;

namespace Domicilios_JSON
{
    class AccesoDatos
    {
        /// <summary>
        /// Obtiene la cadena de conexión a la DB a partir del archivo de configuración de la App
        /// </summary>
        private static string ObtenerCadenaConexion(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        /// <summary>
        /// Obtiene los domicilios de un hogar
        /// </summary>
        public static List<Domicilio> ObtieneListaDomicilios(int id_hogar)
        {
            string cadenaConexion = ObtenerCadenaConexion("DBDomicilios");

            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                string sentenciaSQL = "select id_municipio from hogares where id_hogar = @id_hogar";


                //El id_hogar se asigna como parametro de la sentencia, 
                DynamicParameters parametrosSentencia = new DynamicParameters();
                parametrosSentencia.Add("@id_hogar", id_hogar, DbType.Int64, ParameterDirection.Input);
                var salida = cxnDB.Query<Domicilio>(sentenciaSQL, parametrosSentencia);

                return salida.ToList();
            }
        }

    }

}
