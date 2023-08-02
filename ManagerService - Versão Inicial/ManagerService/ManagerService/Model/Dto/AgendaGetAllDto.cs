using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Model.Dto
{
    public class AgendaGetAllDto
    {
        public String Cliente { get; set; }

        public String Servicos { get; set; }

        public DateTime Data { get; set; }

        public double Hora { get; set; }

    }
}
