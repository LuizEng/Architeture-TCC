using ManagerService.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Converter
{
    internal class LoginConverter
    {
        public Usuario SqlToUsuario(MySqlDataReader reader)
        {
            if (reader.Read())
            {
                return new Usuario() { Id = reader.GetInt32(0), 
                                       Nome = reader.GetString(1),
                                       Token = reader.GetString(2)};
            }

            return null;
        }
    }
}
