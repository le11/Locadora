namespace Sistema_Locadora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReCreateLocacao : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("Logins");
            CreateTable(
                "dbo.Locacaos",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        DataRetirada = c.DateTime(nullable: false, precision: 0),
                        DataDevolucao = c.DateTime(nullable: false, precision: 0),
                        Cliente_Codigo = c.Int(),
                        Colaborador_Id = c.Int(),
                        Filme_Codigo = c.Int(),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("Clientes", t => t.Cliente_Codigo)
                .ForeignKey("Logins", t => t.Colaborador_Id)
                .ForeignKey("Filmes", t => t.Filme_Codigo)
                .Index(t => t.Cliente_Codigo)
                .Index(t => t.Colaborador_Id)
                .Index(t => t.Filme_Codigo);
            
            AddColumn("Logins", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("Logins", "Usuario", c => c.String(unicode: false, maxLength: 128, storeType: "nvarchar"));
            AddPrimaryKey("Logins", "Id");
            CreateIndex("Logins", "Usuario", unique: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacaos", "Filme_Codigo", "dbo.Filmes");
            DropForeignKey("dbo.Locacaos", "Colaborador_Id", "dbo.Logins");
            DropForeignKey("dbo.Locacaos", "Cliente_Codigo", "dbo.Clientes");
            DropIndex("Logins", new[] { "Usuario" });
            DropIndex("dbo.Locacaos", new[] { "Filme_Codigo" });
            DropIndex("dbo.Locacaos", new[] { "Colaborador_Id" });
            DropIndex("dbo.Locacaos", new[] { "Cliente_Codigo" });
            DropPrimaryKey("Logins");
            AlterColumn("Logins", "Usuario", c => c.String(nullable: false, maxLength: 128, storeType: "nvarchar"));
            DropColumn("Logins", "Id");
            DropTable("dbo.Locacaos");
            AddPrimaryKey("Logins", "Usuario");
        }
    }
}
