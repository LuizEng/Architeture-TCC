using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Model.Dto
{
    public class ServicoPostDto
    {
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public float CustoMedio { get; set; }
        public int fk_usuario { get; set; }
    }
}
