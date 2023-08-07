using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Model.Dto
{
    public class AgendaPostDto
    {
        public int Fk_cliente { get; set; }

        public DateTime Data { get; set; }

        public float Hora { get; set; }
    }
}
