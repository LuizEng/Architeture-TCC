using Manager01;
using ManagerService.Converter;
using ManagerService.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Repository
{
    internal class LoginRepository: SqlController
    {        
        public Usuario GetLogin(string usuario, string senha)
        {
            MySqlDataReader reader = GetDataReader("select * from usuario where nome ='"+ usuario + "' and token = '"+ senha + "'");
            if (reader != null)
            {
                LoginConverter loginConverter = new LoginConverter();
                return loginConverter.SqlToUsuario(reader);
            }
            return null;
        }
    }
}
