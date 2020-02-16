namespace Sistemacompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up3 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Users (Name, Identification, StatusId, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy) Values ('Pepe', 'xxx', 2, GETDATE(), 1, GETDATE(), 1)");
            Sql("INSERT INTO dbo.Departments (Name, StatusId, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy) Values ('Finanzas', 2, GETDATE(), 1, GETDATE(), 1)");
            Sql("INSERT INTO dbo.Employees (UserId, DepartmentId, StatusId, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy) Values (1, 1, 2, GETDATE(), 1, GETDATE(), 1)");
        }
        
        public override void Down()
        {
        }
    }
}
