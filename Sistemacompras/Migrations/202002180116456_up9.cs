namespace Sistemacompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ItemRequests", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.ItemRequests", new[] { "EmployeeId" });
            AlterColumn("dbo.ItemRequests", "EmployeeId", c => c.Int());
            CreateIndex("dbo.ItemRequests", "EmployeeId");
            AddForeignKey("dbo.ItemRequests", "EmployeeId", "dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemRequests", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.ItemRequests", new[] { "EmployeeId" });
            AlterColumn("dbo.ItemRequests", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.ItemRequests", "EmployeeId");
            AddForeignKey("dbo.ItemRequests", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
