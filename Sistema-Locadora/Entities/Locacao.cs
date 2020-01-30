using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Locadora.Entities
{
    class Locacao
    {
        [Key]
        public int Codigo { get; set; }
        public Filme Filme { get; set; }
        public Cliente Cliente { get; set; }
        public Login Colaborador { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}
