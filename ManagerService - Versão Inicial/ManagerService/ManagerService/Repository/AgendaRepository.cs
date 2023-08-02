using Manager01;
using ManagerService.Converter;
using ManagerService.Model.Dto;
using ManagerService.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Repository
{
    public class AgendaRepository
    {
        private AgendaConverter _converter;

        public AgendaRepository() 
        { 
            _converter = new AgendaConverter();            
        }

        public Agenda GetById(int id)
        {
            SqlController  sqlController = new SqlController();
            MySqlDataReader reader = sqlController.GetDataReader("select * from agenda");

            return _converter.SqlToAgenda(reader);
        }

        public List<AgendaGetAllDto> GetBetweenDate(DateTime dataInicio, DateTime datafim)
        {
            SqlController sqlController = new SqlController();
            MySqlDataReader reader = sqlController.GetDataReader("select * from agenda where data between " + dataInicio.ToShortDateString() + " and " + datafim.ToShortDateString());

            var list = new List<AgendaGetAllDto>();
            while (reader.Read())
            {
                list.Add(_converter.SqlToAgendaGetAllDto(reader));
            }

            return list;
        }
    }
}
