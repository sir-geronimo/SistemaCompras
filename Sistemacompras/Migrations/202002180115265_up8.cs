namespace Sistemacompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ItemRequests", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.ItemRequests", new[] { "Employee_Id" });
            RenameColumn(table: "dbo.ItemRequests", name: "Employee_Id", newName: "EmployeeId");
            AlterColumn("dbo.ItemRequests", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.ItemRequests", "EmployeeId");
            AddForeignKey("dbo.ItemRequests", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            DropColumn("dbo.ItemRequests", "RequestedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ItemRequests", "RequestedBy", c => c.Int(nullable: false));
            DropForeignKey("dbo.ItemRequests", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.ItemRequests", new[] { "EmployeeId" });
            AlterColumn("dbo.ItemRequests", "EmployeeId", c => c.Int());
            RenameColumn(table: "dbo.ItemRequests", name: "EmployeeId", newName: "Employee_Id");
            CreateIndex("dbo.ItemRequests", "Employee_Id");
            AddForeignKey("dbo.ItemRequests", "Employee_Id", "dbo.Employees", "Id");
        }
    }
}
