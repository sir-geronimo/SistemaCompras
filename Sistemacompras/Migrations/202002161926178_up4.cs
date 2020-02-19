namespace Sistemacompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brands", "Description", c => c.String(maxLength: 100));
            AlterColumn("dbo.Status", "Name", c => c.String(maxLength: 100));
            AlterColumn("dbo.Users", "Name", c => c.String(maxLength: 100));
            AlterColumn("dbo.Users", "Identification", c => c.String(maxLength: 100));
            AlterColumn("dbo.Items", "Description", c => c.String(maxLength: 100));
            AlterColumn("dbo.Units", "Description", c => c.String(maxLength: 100));
            AlterColumn("dbo.Providers", "Identification", c => c.String(maxLength: 100));
            AlterColumn("dbo.Providers", "Name", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Providers", "Name", c => c.String());
            AlterColumn("dbo.Providers", "Identification", c => c.String());
            AlterColumn("dbo.Units", "Description", c => c.String());
            AlterColumn("dbo.Items", "Description", c => c.String());
            AlterColumn("dbo.Users", "Identification", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Status", "Name", c => c.String());
            AlterColumn("dbo.Brands", "Description", c => c.String());
        }
    }
}
