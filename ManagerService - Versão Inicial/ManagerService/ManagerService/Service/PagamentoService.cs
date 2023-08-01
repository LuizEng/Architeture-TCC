using ManagerService.Model.Entity;
using ManagerService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Service
{
    public class PagamentoService
    {
        private PagamentoRepository _repository;

        public PagamentoService() => _repository = new PagamentoRepository();

        public Pagamento GetPagamento(int id) => _repository.GetById(id);
    }
}
