namespace Sistema_Locadora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FilmeLocado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Filmes", "Locado", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Filmes", "Locado");
        }
    }
}
