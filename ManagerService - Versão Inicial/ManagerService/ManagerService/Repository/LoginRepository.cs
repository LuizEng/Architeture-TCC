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
    internal class LoginRepository
    {        
        public Usuario GetLogin(string usuario, string senha)
        {
            SqlController sqlController = new SqlController();
            MySqlDataReader reader = sqlController.GetDataReader("select * from usuario where nome ='"+ usuario + "' and token = '"+ senha + "'");
            if (reader != null)
            {
                LoginConverter loginConverter = new LoginConverter();
                return loginConverter.SqlToUsuario(reader);
            }
            return null;
        }
    }
}
