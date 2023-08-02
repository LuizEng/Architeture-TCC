using ManagerService.Model.Dto;
using ManagerService.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Converter
{
    public class ClienteConverter
    {
        public Cliente SqlToCliente(MySqlDataReader mySqlDataReader)
        {
            if (mySqlDataReader.Read())
            {
                return new Cliente() { Id = mySqlDataReader.GetInt32(mySqlDataReader.GetOrdinal("id")) ,
                                       Nome = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("nome")),
                                       Telefone = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("telefone")),
                                       Email = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("email")),
                };
                
            }

            return null;
        }

        public ClienteGetAllDto SqlToClienteGetAllDto(MySqlDataReader mySqlDataReader)
        {
            if (mySqlDataReader.Read())
            {
                return new ClienteGetAllDto()
                {                    
                    Nome = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("nome")),
                    Telefone = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("telefone")),                    
                };

            }
            return null;
        }
    }
}
