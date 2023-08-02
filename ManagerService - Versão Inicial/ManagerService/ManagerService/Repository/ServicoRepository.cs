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
    public class ServicoRepository: SqlController
    {
        private ServicoConverter _converter;
        public ServicoRepository() => _converter = new ServicoConverter();
        public List<Servico> GetAllServicos()
        {            
            MySqlDataReader sqlDataReader = GetDataReader("select * from servico");

            var list = new List<Servico>();

            while (sqlDataReader.Read())
            {
                list.Add(_converter.SqlToServico(sqlDataReader));
            }

            return list;
        }

        public Servico GetById(int id) => _converter.SqlToServico(GetDataReader("select * from servico where id = " + id.ToString()));

        public List<Servico> GetServicosAgenda(int idAgenda)
        {            
            MySqlDataReader sqlDataReader = GetDataReader("select * from servico inner join agenda_servico on servico.id = fk_servico where fk_agenda = " + idAgenda.ToString());

            var list = new List<Servico>();            
            while (sqlDataReader.Read())
            {
                list.Add(_converter.SqlToServico(sqlDataReader));
            }

            return list;
        }
    }
}

