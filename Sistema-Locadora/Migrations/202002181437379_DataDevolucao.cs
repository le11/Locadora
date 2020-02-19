namespace Sistema_Locadora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataDevolucao : DbMigration
    {
        public override void Up()
        {
            AddColumn("Locacaos", "DataPrevDevolucao", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("Locacaos", "Devolucao", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("Locacaos", "DataDevolucao");
        }
        
        public override void Down()
        {
            AddColumn("Locacaos", "DataDevolucao", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("Locacaos", "Devolucao");
            DropColumn("Locacaos", "DataPrevDevolucao");
        }
    }
}
