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
    public class ServicoController
    {
        private ServicoService _service;
        public ServicoController() => _service = new ServicoService();

        public List<Servico> RetornarServicos() => _service.GetServicos();

        public List<ServicoDto> RetornarServicosDto() => _service.GetAllServicoDto();

        public void IncluirServico(string descricao, float valor, float custo, int idUsuario)
        {            
            _service.IncluirServico(new ServicoPostDto() { Descricao = descricao, Valor = valor, CustoMedio = custo, fk_usuario = idUsuario });
        }

        public void AtualizarServico(int id, string descricao, float valor, float custo)
        {
            _service.AtualizarServico(new ServicoDto() { Id = id, Descricao = descricao, Valor = valor, CustoMedio = custo }); 
        }

        public void ExcluirServico(int id) => _service.RemoverServico(id);

        public void SetServicosAgenda(List<int> servicos, int idAgenda) => _service.SetServicosAgenda(servicos, idAgenda);
    }
}
