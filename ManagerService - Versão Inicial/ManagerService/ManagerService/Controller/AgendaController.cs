using ManagerService.Model.Dto;
using ManagerService.Model.Entity;
using ManagerService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Controller
{
    public class AgendaController
    {
        private AgendaService _service;

        public AgendaController() => _service = new AgendaService();

        public Agenda GetAgenda(int id) => _service.GetAgenda(id);
        
        public List<AgendaGetAllDto> GetAgendaSemana()
        {
            DateTime dataAtual = DateTime.Now;
            
            DateTime inicioSemana = dataAtual.AddDays(-(int)dataAtual.DayOfWeek);
            DateTime fimSemana = inicioSemana.AddDays(6);

            return _service.GetAgendaSemana(inicioSemana, fimSemana);
        }

        public List<AgendaGetAllDto> GetAgendaHoje()
        {
            DateTime dataAtual = DateTime.Now;

            return _service.GetAgendaHoje(dataAtual);
        }

        public void IncluirAgenda(int cliente, DateTime data, float hora, List<int> servicos)
        {           
            _service.IncluirAgenda(new AgendaPostDto() { Fk_cliente = cliente, Data = data, Hora = hora }, servicos);
        }
    }
}
