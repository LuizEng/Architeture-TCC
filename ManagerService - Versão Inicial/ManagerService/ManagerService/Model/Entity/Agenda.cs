using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Model.Entity
{
    public class Agenda
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Cliente Cliente { get; set; }
        
        [Required]
        public List<Servico> Servicos { get; set; }

        [Required]
        public DateTime Data { get; set; }

        public double Hora { get; set; }

        public int Status { get; set; }
    }
}
