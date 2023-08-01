using ManagerService.Model.Entity;
using ManagerService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Service
{
    public class ServicoService
    {
        private ServicoRepository _repository;
        public ServicoService() 
        {
            _repository = new ServicoRepository();
        } 

        public List<Servico> GetServicos()
        {
            return _repository.GetAllServicos();
        }
    }
}
