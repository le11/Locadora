using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Locadora.Entities;
using Sistema_Locadora.Enums;
using System.Data.Entity;

namespace Sistema_Locadora.Data
{
    class FilmeCrud
    {
        public bool Insert(Filme novFilme)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                db.Filmes.Add(novFilme);
                db.SaveChanges();
                db.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Filme dFilme)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                db.Filmes.Remove(dFilme);
                db.SaveChanges();
                db.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int codFilme)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                Filme filme = (from s in db.Filmes where s.Codigo == codFilme select s).SingleOrDefault();
                db.Filmes.Remove(filme);
                db.SaveChanges();
                db.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool Atualizar(Filme vFilme, Filme nFilme)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();


                vFilme.AnoDeProducao = nFilme.AnoDeProducao;
                vFilme.Ator_Principal = nFilme.Ator_Principal;
                vFilme.Classificacao = nFilme.Classificacao;
                vFilme.Fornecedor = nFilme.Fornecedor;
                vFilme.Idioma = nFilme.Idioma;
                vFilme.Legenda = nFilme.Legenda;
                vFilme.Localizacao = nFilme.Localizacao;
                vFilme.Quantidade = nFilme.Quantidade;
                vFilme.Titulo = nFilme.Titulo;
                vFilme.Titulo_Original = nFilme.Titulo_Original;
                vFilme.Genero = nFilme.Genero;
                vFilme.Locado = nFilme.Locado;

                db.Entry(vFilme).State = EntityState.Modified;
                db.SaveChanges();
                db.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Filme ObterFilme(int codFilme)
        {
            try
            {
                LocadoraContext db = new LocadoraContext();
                Filme obtFilme = (from s in db.Filmes where s.Codigo == codFilme select s).SingleOrDefault();
                return obtFilme;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<string> RetornaFilmes()
        {
            LocadoraContext db = new LocadoraContext();

            return (from s in db.Filmes select s.Titulo).ToList();

        }

    }
}
