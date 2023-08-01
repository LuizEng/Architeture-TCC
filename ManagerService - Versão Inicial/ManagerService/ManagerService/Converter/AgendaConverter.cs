using ManagerService.Model.Entity;
using ManagerService.Repository;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Converter
{
    public class AgendaConverter
    {
        public Agenda SqlToAgenda(MySqlDataReader reader)
        {
            Agenda agenda = new Agenda()
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Data = reader.GetDateTime(reader.GetOrdinal("data"))
            };

            ClienteRepository clienteRepository = new ClienteRepository();
            agenda.Cliente = clienteRepository.GetById(reader.GetInt32(reader.GetOrdinal("fk_cliente")));

            ServicoRepository servicoRepository = new ServicoRepository();
            agenda.Servicos = servicoRepository.GetServicosAgenda(agenda.Id);

            return agenda;
        }
    }
}
