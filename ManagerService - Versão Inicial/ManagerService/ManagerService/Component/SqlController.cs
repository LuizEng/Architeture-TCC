using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager01
{
    internal class SqlController
    {
        private MySQLConnectionManager connection;
        public SqlController()
        {
            this.connection = new MySQLConnectionManager();
        }
        public MySqlDataReader GetDataReader(string command)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(command, connection.GetSqlConnection());
            MySqlDataReader retorno = mySqlCommand.ExecuteReader();
            return retorno;

        }
        public MySqlDataAdapter GetDataAdapter(string command) 
        {
            MySqlCommand mySqlCommand = new MySqlCommand(command, connection.GetSqlConnection());
            MySqlDataAdapter retorno = new MySqlDataAdapter(mySqlCommand);            
            return retorno;
        }

        public void ExecSql(string command)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(command, connection.GetSqlConnection());
            mySqlCommand.ExecuteNonQuery();
        }

        public void Dispose()
        {
            connection.dispose();
        }
    }
}
