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
        public int Id { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public float CustoMedio { get; set; }
        public int fk_usuario { get; set; }
    }
}
