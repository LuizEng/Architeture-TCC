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
    public class ServicoService
    {
        private ServicoRepository _repository;
        public ServicoService() 
        {
            _repository = new ServicoRepository();
        }

        public List<Servico> GetServicos() => _repository.GetAllServicos();
        public List<ServicoDto> GetAllServicoDto() => _repository.GetAllServicoDto();

        public void IncluirServico(ServicoPostDto dto) => _repository.Insert(dto);

        public void AtualizarServico(ServicoDto dto) => _repository.Update(dto);

        public void RemoverServico(int id) => _repository.Delete(id);
    }
}
