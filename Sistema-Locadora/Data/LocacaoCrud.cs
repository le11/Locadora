using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Locadora.Entities;

namespace Sistema_Locadora.Data
{
    class LocacaoCrud
    {
        public bool Insert(Locacao novaLocacao)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                db.Locacoes.Add(novaLocacao);
                db.SaveChanges();
                db.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Locacao dLocacao)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                db.Locacoes.Remove(dLocacao);
                db.SaveChanges();
                db.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int codLocacao)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                Locacao locacao = (from s in db.Locacoes where s.Codigo == codLocacao select s).SingleOrDefault();
                db.Locacoes.Remove(locacao);
                db.SaveChanges();
                db.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool Atualizar(Locacao vLocacao, Locacao nLocacao)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();


                vLocacao.DataDevolucao = nLocacao.DataDevolucao;
                vLocacao.DataRetirada = nLocacao.DataRetirada;
                vLocacao.Colaborador = nLocacao.Colaborador;
                vLocacao.Filme = nLocacao.Filme;
                vLocacao.Cliente = nLocacao.Cliente;

                db.Entry(vLocacao).State = EntityState.Modified;
                db.SaveChanges();
                db.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Locacao ObterLocacao(int codLocacao)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                Locacao obtLocacao = (from s in db.Locacoes where s.Codigo == codLocacao select s).SingleOrDefault();
                return obtLocacao;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
