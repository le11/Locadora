using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Locadora.Adicionais;
using Sistema_Locadora.Entities;
using Sistema_Locadora.Enums;

namespace Sistema_Locadora.Data
{
    class ClienteCrud
    {
        public bool Insert(Cliente novoCliente)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                db.Clientes.Add(novoCliente);
                db.SaveChanges();
                db.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Cliente dCliente)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                db.Clientes.Remove(dCliente);
                db.SaveChanges();
                db.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool Delete(int codCliente)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                Cliente client = (from s in db.Clientes where s.Codigo == codCliente select s).SingleOrDefault();
                db.Clientes.Remove(client);
                db.SaveChanges();
                db.Dispose();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Atualizar(Cliente vCliente, Cliente nCliente)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();


                vCliente.Nome = nCliente.Nome;
                vCliente.Telefone = nCliente.Telefone;
                vCliente.Email = nCliente.Email;
                vCliente.Cpf = nCliente.Cpf;

                db.Entry(vCliente).State = EntityState.Modified;
                db.SaveChanges();
                db.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Cliente ObterCliente(int codCliente)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                Cliente obtCliente = (from s in db.Clientes where s.Codigo == codCliente select s).SingleOrDefault();
                return obtCliente;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<string> RetornaNomeClientes()
        {
            LocadoraContext db = new LocadoraContext();

            return (from s in db.Clientes select s.Nome).ToList();

        }
    }
}
