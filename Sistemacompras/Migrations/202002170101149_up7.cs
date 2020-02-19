namespace Sistemacompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Providers", "PublicName", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Providers", "PublicName");
        }
    }
}
