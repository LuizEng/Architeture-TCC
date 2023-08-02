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
        [Obsolete("Não se retorna a entidade, se retorna o DTO. Problema disso, são os relacionamentos no model")]
        public Cliente SqlToCliente(MySqlDataReader mySqlDataReader)
        {
            return new Cliente() { Id = mySqlDataReader.GetInt32(mySqlDataReader.GetOrdinal("id")) ,
                                    Nome = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("nome")),
                                    Telefone = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("telefone")),
                                    Email = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("email")),
            };

        }

        public ClienteDto SqlToClienteDto(MySqlDataReader mySqlDataReader)
        {
            return new ClienteDto()
            {
                Id = mySqlDataReader.GetInt32(mySqlDataReader.GetOrdinal("id")),
                Nome = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("nome")),
                Telefone = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("telefone")),
                Email = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("email")),
            };
        }

        public ClienteGetAllDto SqlToClienteGetAllDto(MySqlDataReader mySqlDataReader)
        {
            return new ClienteGetAllDto()
            {                    
                Nome = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("nome")),
                Telefone = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("telefone")),                    
            };

        }
    }
}
