using ManagerService.Model.Entity;
using ManagerService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Controller
{
    public class ServicoController
    {
        private ServicoService _service;
        public ServicoController() 
        {
            _service = new ServicoService();
        }

        public List<Servico> RetornarServicos()
        {
            return _service.GetServicos();
        }
    }
}
