using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(string delUsuario)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                Login login = (from s in db.Login where s.Usuario == delUsuario select s).SingleOrDefault();
                db.Login.Remove(login);
                db.SaveChanges();
                db.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool Atualizar(Login vLogin, Login nLogin)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();


                vLogin.Senha = nLogin.Senha;
                vLogin.Nome = nLogin.Nome;
                vLogin.Telefone = nLogin.Telefone;
                vLogin.Cargo = vLogin.Cargo;

                db.Entry(vLogin).State = EntityState.Modified;
                db.SaveChanges();
                db.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Login ObterLogin(string obtUsuario)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                Login obtLogin = (from s in db.Login where s.Usuario == obtUsuario select s).SingleOrDefault();
                return obtLogin;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}


