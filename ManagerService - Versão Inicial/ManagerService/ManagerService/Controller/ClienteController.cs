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
    public class ClienteController
    {
        private ClienteService _clienteService;

        public ClienteController() => _clienteService = new ClienteService();

        public List<ClienteGetAllDto> RetornarTodosClientes() => _clienteService.GetClientes();

        public Cliente RetornarClientePorId(int id) => _clienteService.GetById(id);

        public bool IsClienteExiste(int id) => _clienteService.GetById(id) != null;
    }
}
