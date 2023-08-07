using ManagerService.Model.Dto;
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

        public List<ClienteGetAllDto> GetClientes() => _clienteRepository.GetAllClientes();

        public Cliente GetById(int id) => _clienteRepository.GetById(id);

        public ClienteDto GetByIdDto(int id) => _clienteRepository.GetByIdDto(id);

        public List<ClienteDto> GetClientesDto() => _clienteRepository.GetAllClienteDto();

        public void InserirCliente(ClientePostDto dto) => _clienteRepository.Insert(dto);

        public void AtualizarCliente(ClienteDto dto) => _clienteRepository.Update(dto);

        public void RemoverCliente(int id) => _clienteRepository.Delete(id);

        public ClienteDto GetByNome(string nome) => _clienteRepository.GetByNome(nome);
    }
}
