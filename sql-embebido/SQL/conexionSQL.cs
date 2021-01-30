using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_embebido.SQL
{
    class conexionSQL
    {
        static string cadenaConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=registro-pokemon;";
        MySqlConnection conexion = new MySqlConnection(cadenaConexion);

        public string realizarOperación(string query)
        {
            try
            {
                conexion.Open();
                MySqlCommand command = new MySqlCommand(query, conexion);
                MySqlDataReader reader = command.ExecuteReader();
                conexion.Close();
                return "1";
            }
            catch(Exception ex)
            {
                conexion.Close();
                return "0: " + ex.Message;
            }        
        }

        public List<Pokemon> realizarConsulta(string query)
        {
            List<Pokemon> registros = new List<Pokemon>();
            
            try
            {
                conexion.Open();
                MySqlCommand command = new MySqlCommand(query, conexion);
                MySqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    registros.Add(new Pokemon(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                }

                conexion.Close();
                return registros;
            }
            catch (Exception ex)
            {
                conexion.Close();
                return registros;
            }
        }
    }
}
