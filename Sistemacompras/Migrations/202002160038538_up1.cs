namespace Sistemacompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "StatusId", c => c.Int());
            CreateIndex("dbo.Employees", "StatusId");
            AddForeignKey("dbo.Employees", "StatusId", "dbo.Status", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "StatusId", "dbo.Status");
            DropIndex("dbo.Employees", new[] { "StatusId" });
            DropColumn("dbo.Employees", "StatusId");
        }
    }
}
