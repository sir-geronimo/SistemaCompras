namespace Sistemacompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        StatusId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StatusId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identification = c.String(),
                        Name = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.ItemRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestedBy = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: false)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.UnitId)
                .Index(t => t.StatusId)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        BrandId = c.Int(nullable: false),
                        UnitId = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.BrandId)
                .Index(t => t.UnitId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        StatusId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identification = c.String(),
                        Name = c.String(),
                        StatusId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.PurchaseOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemRequestId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        StatusId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.ItemRequests", t => t.ItemRequestId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.ItemRequestId)
                .Index(t => t.StatusId)
                .Index(t => t.ItemId)
                .Index(t => t.UnitId)
                .Index(t => t.BrandId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseOrders", "UnitId", "dbo.Units");
            DropForeignKey("dbo.PurchaseOrders", "StatusId", "dbo.Status");
            DropForeignKey("dbo.PurchaseOrders", "ItemRequestId", "dbo.ItemRequests");
            DropForeignKey("dbo.PurchaseOrders", "ItemId", "dbo.Items");
            DropForeignKey("dbo.PurchaseOrders", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Providers", "StatusId", "dbo.Status");
            DropForeignKey("dbo.ItemRequests", "UnitId", "dbo.Units");
            DropForeignKey("dbo.ItemRequests", "StatusId", "dbo.Status");
            DropForeignKey("dbo.ItemRequests", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Items", "UnitId", "dbo.Units");
            DropForeignKey("dbo.Units", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Items", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Items", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.ItemRequests", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Departments", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Brands", "StatusId", "dbo.Status");
            DropIndex("dbo.PurchaseOrders", new[] { "BrandId" });
            DropIndex("dbo.PurchaseOrders", new[] { "UnitId" });
            DropIndex("dbo.PurchaseOrders", new[] { "ItemId" });
            DropIndex("dbo.PurchaseOrders", new[] { "StatusId" });
            DropIndex("dbo.PurchaseOrders", new[] { "ItemRequestId" });
            DropIndex("dbo.Providers", new[] { "StatusId" });
            DropIndex("dbo.Units", new[] { "StatusId" });
            DropIndex("dbo.Items", new[] { "StatusId" });
            DropIndex("dbo.Items", new[] { "UnitId" });
            DropIndex("dbo.Items", new[] { "BrandId" });
            DropIndex("dbo.ItemRequests", new[] { "Employee_Id" });
            DropIndex("dbo.ItemRequests", new[] { "StatusId" });
            DropIndex("dbo.ItemRequests", new[] { "UnitId" });
            DropIndex("dbo.ItemRequests", new[] { "ItemId" });
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropIndex("dbo.Departments", new[] { "StatusId" });
            DropIndex("dbo.Brands", new[] { "StatusId" });
            DropTable("dbo.PurchaseOrders");
            DropTable("dbo.Providers");
            DropTable("dbo.Units");
            DropTable("dbo.Items");
            DropTable("dbo.ItemRequests");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
            DropTable("dbo.Status");
            DropTable("dbo.Brands");
        }
    }
}
