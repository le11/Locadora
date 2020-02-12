﻿namespace Sistema_Locadora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReCreateLogin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Usuario = c.String(unicode: false),
                        Senha = c.String(unicode: false),
                        Nome = c.String(unicode: false),
                        Cargo = c.String(unicode: false),
                        Telefone = c.String(unicode: false),
                        Salario = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Logins");
        }
    }
}
