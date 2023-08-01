using ManagerService.Model.Entity;
using ManagerService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Service
{
    internal class AgendaService
    {
        private AgendaRepository _repository;

        public AgendaService() => _repository = new AgendaRepository();

        public Agenda GetAgenda(int id) => _repository.GetById(id);
    }
}
