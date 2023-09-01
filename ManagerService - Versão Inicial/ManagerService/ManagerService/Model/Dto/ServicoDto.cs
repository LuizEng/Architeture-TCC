using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Model.Dto
{
    public class ServicoDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public float CustoMedio { get; set; }
        public string usuario { get; set; }
    }
}
