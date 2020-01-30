namespace Sistema_Locadora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Telefone = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Cpf = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Filmes",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Titulo = c.String(unicode: false),
                        Titulo_Original = c.String(unicode: false),
                        Ator_Principal = c.String(unicode: false),
                        Fornecedor = c.String(unicode: false),
                        AnoDeProducao = c.DateTime(nullable: false, precision: 0),
                        Idioma = c.String(unicode: false),
                        Legenda = c.String(unicode: false),
                        Classificacao = c.String(unicode: false),
                        Genero = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Localizacao = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Locacaos",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        DataRetirada = c.DateTime(nullable: false, precision: 0),
                        DataDevolucao = c.DateTime(nullable: false, precision: 0),
                        Cliente_Codigo = c.Int(),
                        Colaborador_Usuario = c.String(maxLength: 128, storeType: "nvarchar"),
                        Filme_Codigo = c.Int(),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Codigo)
                .ForeignKey("dbo.Logins", t => t.Colaborador_Usuario)
                .ForeignKey("dbo.Filmes", t => t.Filme_Codigo)
                .Index(t => t.Cliente_Codigo)
                .Index(t => t.Colaborador_Usuario)
                .Index(t => t.Filme_Codigo);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Usuario = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Senha = c.String(unicode: false),
                        Nome = c.String(unicode: false),
                        Cargo = c.String(unicode: false),
                        Telefone = c.String(unicode: false),
                        Salario = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Usuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacaos", "Filme_Codigo", "dbo.Filmes");
            DropForeignKey("dbo.Locacaos", "Colaborador_Usuario", "dbo.Logins");
            DropForeignKey("dbo.Locacaos", "Cliente_Codigo", "dbo.Clientes");
            DropIndex("dbo.Locacaos", new[] { "Filme_Codigo" });
            DropIndex("dbo.Locacaos", new[] { "Colaborador_Usuario" });
            DropIndex("dbo.Locacaos", new[] { "Cliente_Codigo" });
            DropTable("dbo.Logins");
            DropTable("dbo.Locacaos");
            DropTable("dbo.Filmes");
            DropTable("dbo.Clientes");
        }
    }
}
