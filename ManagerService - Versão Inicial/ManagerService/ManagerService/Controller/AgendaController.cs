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
    }
}
