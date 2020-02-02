using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Locadora.Entities;

namespace Sistema_Locadora.Data
{
    class LoginCrud
    {
        public bool Inserir(Login login)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                db.Login.Add(login);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

