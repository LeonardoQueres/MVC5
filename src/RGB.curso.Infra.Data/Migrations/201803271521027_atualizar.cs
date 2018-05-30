namespace RGB.curso.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualizar : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.PRODUTOS", newName: "Produto");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Produto", newName: "PRODUTOS");
        }
    }
}
