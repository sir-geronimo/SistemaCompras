namespace Sistemacompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Identification = c.String(),
                        StatusId = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Status", t => t.StatusId)
                .Index(t => t.StatusId);
            
            AddColumn("dbo.Employees", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "UserId");
            AddForeignKey("dbo.Employees", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            DropColumn("dbo.Employees", "Identification");
            DropColumn("dbo.Employees", "Name");

            Sql("INSERT INTO dbo.Status (Name, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy) Values ('Inactivo', GETDATE(), 1, GETDATE(), 1)");
            Sql("INSERT INTO dbo.Status (Name, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy) Values ('Activo', GETDATE(), 1, GETDATE(), 1)");
            Sql("INSERT INTO dbo.Status (Name, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy) Values ('Aprobado', GETDATE(), 1, GETDATE(), 1)");
            Sql("INSERT INTO dbo.Status (Name, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy) Values ('Rechazado', GETDATE(), 1, GETDATE(), 1)");
            Sql("INSERT INTO dbo.Status (Name, CreatedDate, CreatedBy, UpdatedDate, UpdatedBy) Values ('Eliminado', GETDATE(), 1, GETDATE(), 1)");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Name", c => c.String());
            AddColumn("dbo.Employees", "Identification", c => c.String());
            DropForeignKey("dbo.Employees", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "StatusId", "dbo.Status");
            DropIndex("dbo.Users", new[] { "StatusId" });
            DropIndex("dbo.Employees", new[] { "UserId" });
            DropColumn("dbo.Employees", "UserId");
            DropTable("dbo.Users");
        }
    }
}
