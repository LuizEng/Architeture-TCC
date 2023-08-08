using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Model.Dto
{
    public class PagamentoPostDto
    {
        public int agenda { get; set; }

        public int tipoPagamento { get; set; }

        public float valor { get; set; }
    }
}
