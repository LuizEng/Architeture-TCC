using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Model.Entity
{
    public class Pagamento
    {
        public int Id { get; set; }

        public Agenda Agenda { get; set; }

        public int TipoPagamento { get; set;}

        public float ValorPago { get; set; }
    }
}
