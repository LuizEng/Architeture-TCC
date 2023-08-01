using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Model.Entity
{
    public class Servico
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }

        [Required]
        public float Valor { get; set; }

        public float CustoMedio { get; set; }
    }
}
