namespace HadwareInventorySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Components",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 150),
                        SerialNumber = c.String(nullable: false, maxLength: 50),
                        Photo = c.Binary(),
                        ComponentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ComponentTypes", t => t.ComponentTypeId, cascadeDelete: true)
                .Index(t => t.ComponentTypeId);
            
            CreateTable(
                "dbo.ComponentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Components", "ComponentTypeId", "dbo.ComponentTypes");
            DropIndex("dbo.Components", new[] { "ComponentTypeId" });
            DropTable("dbo.ComponentTypes");
            DropTable("dbo.Components");
        }
    }
}
