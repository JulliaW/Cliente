namespace Cliente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteModels",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        CPF = c.String(nullable: false),
                        Telefone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClienteModels");
        }
    }
}
