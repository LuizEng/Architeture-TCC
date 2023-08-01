using ManagerService.Model.Entity;
using ManagerService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Controller
{
    public class PagamentoController
    {
        private PagamentoService _service;

        public PagamentoController() => _service = new PagamentoService();

        public Pagamento GetPagamento(int id) => _service.GetPagamento(id);

    }
}
