using Manager01;
using ManagerService.Controller;
using ManagerService.Converter;
using ManagerService.Model.Dto;
using ManagerService.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Repository
{
    public class AgendaRepository: SqlController
    {
        private AgendaConverter _converter;

        public AgendaRepository() 
        { 
            _converter = new AgendaConverter();            
        }

        public Agenda GetById(int id) => _converter.SqlToAgenda(GetDataReader("select * from agenda where id = "+ id.ToString()));
        
        public List<AgendaGetAllDto> GetBetweenDate(DateTime dataInicio, DateTime datafim)
        {
            MySqlDataReader reader = GetDataReader("select * from agenda where data between '" + converterData(dataInicio) + "' and '" + converterData(datafim) + "'");

            var list = new List<AgendaGetAllDto>();
            while (reader.Read())
            {
                list.Add(_converter.SqlToAgendaGetAllDto(reader));
            }

            return list;
        }

        public void IncluirAgenda(AgendaPostDto dto, List<int> servicos)
        {
            Insert<AgendaPostDto>(dto, "agenda");
            if (LastInsertId > 0)
            {
                ServicoController servicoController = new ServicoController();
                servicoController.SetServicosAgenda(servicos, LastInsertId);
            }
        }

        public float GetValorServicos(int idAgenda)
        {            
            MySqlDataReader reader = GetDataReader("select sum(valor) from agenda_servico inner join servico on servico.id = fk_servico where fk_agenda = " + idAgenda.ToString());
            reader.Read();
            return float.Parse(reader.GetString(0).Replace(",", "."), CultureInfo.InvariantCulture);
        }

    }
}
