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
    public class ServicoRepository
    {
        private ServicoConverter _converter;
        public ServicoRepository() => _converter = new ServicoConverter();
        public List<Servico> GetAllServicos()
        {
            SqlController sqlController = new SqlController();
            MySqlDataReader sqlDataReader = sqlController.GetDataReader("select * from servico");

            var list = new List<Servico>();

            while (sqlDataReader.Read())
            {
                list.Add(_converter.SqlToServico(sqlDataReader));
            }

            return list;
        }

        public Servico GetById(int id)
        {
            SqlController sqlController = new SqlController();
            MySqlDataReader sqlDataReader = sqlController.GetDataReader("select * from servico where id = " + id.ToString());

            return _converter.SqlToServico(sqlDataReader);
        }

        public List<Servico> GetServicosAgenda(int idAgenda)
        {
            SqlController sqlController = new SqlController();
            MySqlDataReader sqlDataReader = sqlController.GetDataReader("select * from servico inner join agenda_servico on servico.id = fk_servico where fk_agenda = " + idAgenda.ToString());

            var list = new List<Servico>();            
            while (sqlDataReader.Read())
            {
                list.Add(_converter.SqlToServico(sqlDataReader));
            }

            return list;
        }
    }
}

