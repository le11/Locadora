namespace Sistema_Locadora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReCreateLocacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Locacaos",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        FilmeId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        ColaboradorId = c.Int(nullable: false),
                        DataRetirada = c.DateTime(nullable: false, precision: 0),
                        DataDevolucao = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("Logins", t => t.ColaboradorId, cascadeDelete: true)
                .ForeignKey("Filmes", t => t.FilmeId, cascadeDelete: true)
                .Index(t => t.FilmeId)
                .Index(t => t.ClienteId)
                .Index(t => t.ColaboradorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Locacaos", "FilmeId", "Filmes");
            DropForeignKey("Locacaos", "ColaboradorId", "Logins");
            DropForeignKey("Locacaos", "ClienteId", "Clientes");
            DropIndex("Locacaos", new[] { "ColaboradorId" });
            DropIndex("Locacaos", new[] { "ClienteId" });
            DropIndex("Locacaos", new[] { "FilmeId" });
            DropTable("Locacaos");
        }
    }
}
