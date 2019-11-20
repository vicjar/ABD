using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQL_Reports
{
    class DBConn
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
        MySqlConnection databaseConnection;
       
       public void OpenConn(string server, string port, string user, string pass, string database)
        {
            try
            {
                connectionString = "datasource=" + server + ";port=" + port + ";username=" + user
                + ";password=" + pass + ";database=" + database + ";";

                databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
             
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al conectar"+ex);
            }
        }
        public void CloseConn()
        {
            databaseConnection.Close();

        }
        public void Open()
        {
            if (databaseConnection.State.ToString() != "Open")
                databaseConnection.Open();
        }
        public void Use(string db)
        {
            string query = "USE" + db + ";";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
        }
        public string ShowDataBases()
        {
            string query = "SHOW DATABASES;";
            string row="";
            
            try
            {
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            row += reader.GetValue(i).ToString() + ",";
                    }
                }
                else
                {
                    MessageBox.Show("no hay nada");
                }
                CloseConn();
                return row;
            }
            catch (Exception e)
            {
                CloseConn();
                return row;
            }
        }

        public string ShowTables(string db)
        {
            string query = "USE "+db+";\nSHOW TABLES;";
            string row = "";
            Open();
            try
            {
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            row += reader.GetValue(i).ToString() + ",";
                    }
                }
                else
                {
                    MessageBox.Show("no hay nada");
                }
                CloseConn();
                return row;
            }
            catch (Exception e)
            {
                CloseConn();
                return row;
            }
        }
        public string ShowColumns(string db, string table)
        {
            string query = "SELECT COLUMN_NAME FROM information_schema.columns WHERE table_schema='"
            +db+"' AND table_name='"+table+"';";

            string row = "";
            Open();
            try
            {
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            row += reader.GetValue(i).ToString() + ",";
                    }
                }
                else
                {
                    MessageBox.Show("no hay nada");
                }
                CloseConn();
                return row;
            }
            catch (Exception e)
            {
               CloseConn();
                return row;
            }
        }
        public void FillGrid(DataGridView grid, string db)
        {
            Open();
            string query = "SELECT * FROM " + db;
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataAdapter sa = new MySqlDataAdapter();
            sa.SelectCommand = commandDatabase;
            DataTable dt = new DataTable();
            sa.Fill(dt);
            grid.DataSource = dt;
        }
    }
}
