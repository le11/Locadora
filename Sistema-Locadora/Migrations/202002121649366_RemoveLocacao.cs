namespace Sistema_Locadora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class RemoveLocacao : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Locacaos", "Cliente_Codigo", "dbo.Clientes");
            DropForeignKey("Locacaos", "Colaborador_Usuario", "dbo.Logins");
            DropForeignKey("Locacaos", "Filme_Codigo", "dbo.Filmes");
            DropIndex("Locacaos", new[] { "Cliente_Codigo" });
            DropIndex("Locacaos", new[] { "Colaborador_Usuario" });
            DropIndex("Locacaos", new[] { "Filme_Codigo" });
            DropPrimaryKey("Logins");
            AddColumn("Logins", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("Logins", "Usuario", c => c.String(unicode: false));
            AddPrimaryKey("Logins", "Id");
            DropTable("Locacaos");
        }

        public override void Down()
        {
            CreateTable(
                "Locacaos",
                c => new
                {
                    Codigo = c.Int(nullable: false, identity: true),
                    DataRetirada = c.DateTime(nullable: false, precision: 0),
                    DataDevolucao = c.DateTime(nullable: false, precision: 0),
                    Cliente_Codigo = c.Int(),
                    Colaborador_Usuario = c.String(maxLength: 128, storeType: "nvarchar"),
                    Filme_Codigo = c.Int(),
                })
                .PrimaryKey(t => t.Codigo);

            DropPrimaryKey("dbo.Logins");
            AlterColumn("dbo.Logins", "Usuario", c => c.String(nullable: false, maxLength: 128, storeType: "nvarchar"));
            DropColumn("dbo.Logins", "Id");
            AddPrimaryKey("Logins", "Usuario");
            CreateIndex("Locacaos", "Filme_Codigo");
            CreateIndex("Locacaos", "Colaborador_Usuario");
            CreateIndex("Locacaos", "Cliente_Codigo");
            AddForeignKey("Locacaos", "Filme_Codigo", "dbo.Filmes", "Codigo");
            AddForeignKey("Locacaos", "Colaborador_Usuario", "dbo.Logins", "Usuario");
            AddForeignKey("Locacaos", "Cliente_Codigo", "Clientes", "Codigo");
        }
    }
}
