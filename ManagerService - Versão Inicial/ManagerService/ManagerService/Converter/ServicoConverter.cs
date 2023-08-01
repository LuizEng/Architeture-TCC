using ManagerService.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Converter
{
    internal class ServicoConverter
    {
        public Servico SqlToServico(MySqlDataReader reader)
        {
            if (reader.Read())
            {
                return new Servico()
                {
                    Id = reader.GetInt32(0),
                    Descricao = reader.GetString(1),
                    Valor = reader.GetFloat(2),
                };
            }

            return null;
        }
    }
}
