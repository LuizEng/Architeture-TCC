using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Model.Entity
{
    public enum TipoPagamento
    {
        Dinheiro,
        Pix,
        Cartao_Credito,
        Cartao_Debito,
        PicPay,
        PayPal,
        APrazo
    }
    public class Pagamento
    {
        public int Id { get; set; }

        public Agenda Agenda { get; set; }

        public TipoPagamento TipoPagamento { get; set;}

        public float ValorPago { get; set; }
    }
}
