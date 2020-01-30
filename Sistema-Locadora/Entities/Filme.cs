using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Locadora.Enums;

namespace Sistema_Locadora.Entities
{
    class Filme
    {
        [Key]
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Titulo_Original { get; set; }
        public string Ator_Principal { get; set; }
        public string Fornecedor { get; set; }
        public DateTime AnoDeProducao { get; set; }
        public string Idioma { get; set; }
        public string Legenda { get; set; }
        public string Classificacao { get; set; }
        public Generos Genero { get; set; }
        public int Quantidade { get; set; }
        public string Localizacao { get; set; }
    }
}

