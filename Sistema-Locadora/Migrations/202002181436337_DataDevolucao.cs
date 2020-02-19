namespace Sistema_Locadora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataDevolucao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locacaos", "DataPrevDevolucao", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.Locacaos", "Devolucao", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.Locacaos", "DataDevolucao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locacaos", "DataDevolucao", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.Locacaos", "Devolucao");
            DropColumn("dbo.Locacaos", "DataPrevDevolucao");
        }
    }
}
