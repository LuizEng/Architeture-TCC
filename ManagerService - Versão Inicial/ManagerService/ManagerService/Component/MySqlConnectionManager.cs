using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager01
{
    public class MySQLConnectionManager
    {        
        private MySqlConnection connection;
        private string connectionString;

        public MySQLConnectionManager()
        {
            connectionString = $"server=127.0.0.1;port=3306;user=root;password=manager;database=managerservice;";
            connection = new MySqlConnection(connectionString);
            OpenConnection();
        }                    

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao conectar: " + ex.Message);
                return false;
            }
        }

        public void dispose()
        {
            connection.Close();
        }

        public MySqlConnection GetSqlConnection() 
        { 
            return connection;
        }
    }
}
