using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Locadora.Entities
{
    public class Cliente
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public override string ToString()
        {
            return "Cod:" + Codigo +
                " Nome:" + Nome +
                " Telefone:" + Telefone +
                " E-mail:" + Email +
                " CPF:" + Cpf;
        }
    }
}
