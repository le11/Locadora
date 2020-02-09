using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Sistema_Locadora.Adicionais;
using Sistema_Locadora.Enums;
using Sistema_Locadora.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Locadora.Entities
{
    public class Login
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Telefone { get; set; }
        public double Salario { get; set; }

        public Login(string usuario, string senha)
        {
            Usuario = usuario;
            Hash h = new Hash(SHA512.Create());
            string senha2 = h.CriptografarSenha(senha);
            Senha = senha2;

        }

        public Login()
        {

        }

        public bool checkUser(string user)
        {

            LocadoraContext db = new LocadoraContext();

            string usuario = (from s in db.Login where s.Usuario == user select s.Usuario).SingleOrDefault();

            if (user == usuario)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
