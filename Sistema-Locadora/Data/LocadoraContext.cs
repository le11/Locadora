using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Locadora.Entities;

namespace Sistema_Locadora.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class LocadoraContext : DbContext
    {
        public LocadoraContext()
            : base("server=localhost;port=3306;database=locadora;uid=root;password='@@password1@@'") { }


        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}
