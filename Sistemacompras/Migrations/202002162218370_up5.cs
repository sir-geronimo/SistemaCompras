namespace Sistemacompras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Username", c => c.String(maxLength: 100));
            AddColumn("dbo.Users", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.Users", "Username");
        }
    }
}
