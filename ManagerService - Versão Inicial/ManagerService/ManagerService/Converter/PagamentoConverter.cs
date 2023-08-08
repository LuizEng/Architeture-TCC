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
    public class PagamentoConverter
    {
        public Pagamento SqlToPagamento(MySqlDataReader reader)
        {
            Pagamento pagamento = new Pagamento() { Id = reader.GetInt32(reader.GetOrdinal("id")),
                                                    ValorPago = reader.GetFloat(reader.GetOrdinal("valorPago")),
                                                    TipoPagamento = reader.GetInt32(reader.GetOrdinal("tipoPagamento"))
            };
            
            AgendaRepository agendaRepository = new AgendaRepository();

            pagamento.Agenda = agendaRepository.GetById(reader.GetInt16(reader.GetOrdinal("fk_agenda")));

            return pagamento;
        }
    }
}
