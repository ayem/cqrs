namespace CQRS.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dashboards",
                c => new
                    {
                        Dashboard_Id = c.Int(nullable: false, identity: true),
                        Dashboard_Title = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Dashboard_Id);
            
            CreateTable(
                "dbo.Gadgets",
                c => new
                    {
                        Gadget_Id = c.Int(nullable: false, identity: true),
                        Gadget_Name = c.String(),
                    })
                .PrimaryKey(t => t.Gadget_Id);
            
            CreateTable(
                "dbo.Dashboard_Gadget",
                c => new
                    {
                        Dashboard_Gadget_Id = c.Int(nullable: false, identity: true),
                        Dashboard_Id = c.Int(nullable: false),
                        Gadget_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Dashboard_Gadget_Id)
                .ForeignKey("dbo.Dashboards", t => t.Dashboard_Id, cascadeDelete: true)
                .ForeignKey("dbo.Gadgets", t => t.Gadget_Id, cascadeDelete: true)
                .Index(t => t.Dashboard_Id)
                .Index(t => t.Gadget_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Dashboard_Gadget", new[] { "Gadget_Id" });
            DropIndex("dbo.Dashboard_Gadget", new[] { "Dashboard_Id" });
            DropForeignKey("dbo.Dashboard_Gadget", "Gadget_Id", "dbo.Gadgets");
            DropForeignKey("dbo.Dashboard_Gadget", "Dashboard_Id", "dbo.Dashboards");
            DropTable("dbo.Dashboard_Gadget");
            DropTable("dbo.Gadgets");
            DropTable("dbo.Dashboards");
        }
    }
}
