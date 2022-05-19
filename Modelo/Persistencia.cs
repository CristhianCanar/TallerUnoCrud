using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class Persistencia
    {
        MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);


        public bool ejecutarCUD(String sql) {
            bool ejecuto = false;
            connection.Open();
            MySqlCommand comando = new MySqlCommand(sql, connection);
            if (comando.ExecuteNonQuery() > 0) {
                ejecuto = true;
            }
            connection.Close();
            return ejecuto;
        }

        public DataSet ejecutoR(String sql)
        {
            DataSet datos = new DataSet();
            connection.Open();
            MySqlDataAdapter miadaptador = new MySqlDataAdapter(sql, connection);

            miadaptador.Fill(datos);
            connection.Close();

            return datos;
        }
        


    }
}