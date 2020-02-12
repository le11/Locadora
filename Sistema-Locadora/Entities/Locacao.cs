using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Locadora.Entities
{
    class Locacao
    {
        [Key]
        public int Codigo { get; set; }
        public int FilmeId { get; set; }
        [ForeignKey("FilmeId")]
        public Filme Filme { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        public int ColaboradorId { get; set; }
        [ForeignKey("ColaboradorId")]
        public Login Colaborador { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}
