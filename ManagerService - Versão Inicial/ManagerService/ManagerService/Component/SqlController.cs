using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager01
{
    public class SqlController
    {        
        private MySqlConnection GetConnection()
        {
            MySQLConnectionManager connection = new MySQLConnectionManager();
            return connection.GetSqlConnection();
        }
        public MySqlDataReader GetDataReader(string command)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(command, GetConnection());
            MySqlDataReader retorno = mySqlCommand.ExecuteReader();
            return retorno;

        }
        public MySqlDataAdapter GetDataAdapter(string command) 
        {
            MySqlCommand mySqlCommand = new MySqlCommand(command, GetConnection());
            MySqlDataAdapter retorno = new MySqlDataAdapter(mySqlCommand);            
            return retorno;
        }

        public void ExecSql(string command)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(command, GetConnection());
            mySqlCommand.ExecuteNonQuery();
        }
    }
}
