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
        [Key]
        public int Id { get; set; }

        [Required]
        public Agenda Agenda { get; set; }

        [Required]
        public TipoPagamento TipoPagamento { get; set;}

        [Required]
        public float ValorPago { get; set; }
    }
}
