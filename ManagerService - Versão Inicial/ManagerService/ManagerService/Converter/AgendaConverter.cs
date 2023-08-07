using ManagerService.Model.Dto;
using ManagerService.Model.Entity;
using ManagerService.Repository;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        public AgendaGetAllDto SqlToAgendaGetAllDto(MySqlDataReader reader)
        {
            AgendaGetAllDto dto = new AgendaGetAllDto() { Data = reader.GetDateTime(reader.GetOrdinal("data")),
                                                          Hora = reader.GetFloat(reader.GetOrdinal("hora"))};

            ClienteRepository clienteRepository = new ClienteRepository();
            Cliente cliente = clienteRepository.GetById(reader.GetInt32(reader.GetOrdinal("fk_cliente")));

            dto.Cliente = cliente.Nome;

            ServicoRepository servicoRepository = new ServicoRepository();
            List<Servico> servicos = servicoRepository.GetServicosAgenda(reader.GetInt32(reader.GetOrdinal("id")));

            dto.Servicos = string.Join(", ", servicos.Select(s => s.Descricao));

            return dto;
        }
    }
}
