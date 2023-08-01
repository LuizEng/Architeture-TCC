using ManagerService.Model.Entity;
using ManagerService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Service
{
    public class ClienteService
    {
        private ClienteRepository _clienteRepository;

        public ClienteService() => _clienteRepository = new ClienteRepository();

        public List<Cliente> GetClientes() => _clienteRepository.GetAllClientes();

        public Cliente GetById(int id) => _clienteRepository.GetById(id);
    }
}
