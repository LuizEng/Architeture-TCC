using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Manager01
{
    public class SqlController
    {
        public int LastInsertId = 0;
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

        private void ExecSql(string command)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(command + "; SELECT LAST_INSERT_ID();", GetConnection());            
            this.LastInsertId = Convert.ToInt32(mySqlCommand.ExecuteScalar());
        }

        public void Insert<T>(T obj, string tableName)
        {
            Type type = typeof(T);
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var propertyNames = new List<string>();
            var propertyValues = new List<string>();             

            foreach (var property in properties)
            {
                propertyNames.Add(property.Name);

                if (property.PropertyType == typeof(DateTime))
                {                    
                    propertyValues.Add($"'{converterData((DateTime)property.GetValue(obj))}'");
                }

                else
                    propertyValues.Add($"'{property.GetValue(obj).ToString().Replace(",", ".")}'");
            }

            string insertStatement = $"INSERT INTO {tableName} ({string.Join(", ", propertyNames)}) VALUES ({string.Join(", ", propertyValues)})";
            ExecSql(insertStatement);            
        }

        public void Update<T>(T obj, string tableName, string idPropertyName)
        {
            Type type = typeof(T);
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var updateStatement = new List<string>();

            foreach (var property in properties)
            {
                if (property.Name != idPropertyName)
                {
                    updateStatement.Add($"{property.Name} = '{property.GetValue(obj)}'");
                }
            }

            int idPropertyValue = (int)type.GetProperty(idPropertyName).GetValue(obj);
            string updateSql = $"UPDATE {tableName} SET {string.Join(", ", updateStatement)} WHERE {idPropertyName} = {idPropertyValue}";
            
            ExecSql(updateSql);
        }

        public void Delete(string tabela, string campoChave, int id)
        {
            ExecSql("delete from " + tabela + " where " + campoChave + " = " + id.ToString());
        }

        public string converterData(DateTime data)
        {
            return data.ToString("yyyy-MM-dd");
        }
    }
}
