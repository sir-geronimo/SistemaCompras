namespace Sistemacompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brands", "Name", c => c.String(maxLength: 100));
            AddColumn("dbo.Items", "Name", c => c.String(maxLength: 100));
            AddColumn("dbo.Units", "Name", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Units", "Name");
            DropColumn("dbo.Items", "Name");
            DropColumn("dbo.Brands", "Name");
        }
    }
}
