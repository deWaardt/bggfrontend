namespace BBGFrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Url : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shops", "WebsiteUrl", c => c.String());
            AddColumn("dbo.Shops", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shops", "ImageUrl");
            DropColumn("dbo.Shops", "WebsiteUrl");
        }
    }
}
