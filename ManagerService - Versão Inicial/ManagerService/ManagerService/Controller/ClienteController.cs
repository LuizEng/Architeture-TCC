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

        public ClienteDto RetornarClientePorIdDto(int id) => _clienteService.GetByIdDto(id);

        public bool IsClienteExiste(int id) => _clienteService.GetById(id) != null;

        public List<ClienteDto> RetornarTodosClienteDto() => _clienteService.GetClientesDto();

        public void InserirCliente(string nome, string telefone, string email) => _clienteService.InserirCliente(new ClientePostDto() { Nome = nome, Telefone = telefone, Email = email });

        public void AtualizarCliente(int id, string nome, string telefone, string email) => _clienteService.AtualizarCliente(new ClienteDto() { Id = id, Nome = nome, Telefone = telefone, Email = email });

        public void RemoverCliente(int id) => _clienteService.RemoverCliente(id);
    }
}
