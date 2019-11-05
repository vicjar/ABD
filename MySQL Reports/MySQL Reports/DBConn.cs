using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQL_Reports
{
    class DBConn
    {
        string server, port, user, pass, database;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
        MySqlConnection databaseConnection;
       
       public void OpenConn(string server, string port, string user, string pass, string database)
        {
            try
            {
                connectionString = "datasource=" + server + ";port=" + port + ";username=" + user + ";password=" + pass + ";database=" + database + ";";
                databaseConnection = new MySqlConnection(connectionString);
                MessageBox.Show("Se establecio la conexion");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al conectar"+ex);
            }


        }
        
        /*
        //Tu consulta en SQL
        string query = "SELECT * FROM user";

        //Prepara la conexión
        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        commandDatabase.CommandTimeout = 60;    
        MySqlDataReader reader;
        */
    }
}
