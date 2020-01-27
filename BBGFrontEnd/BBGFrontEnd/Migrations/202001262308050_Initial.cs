namespace BBGFrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Boardgames", "MinPlayTime", c => c.Int(nullable: false));
            AddColumn("dbo.Boardgames", "MaxPlayTime", c => c.Int(nullable: false));
            DropColumn("dbo.Boardgames", "PlayTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Boardgames", "PlayTime", c => c.Int(nullable: false));
            DropColumn("dbo.Boardgames", "MaxPlayTime");
            DropColumn("dbo.Boardgames", "MinPlayTime");
        }
    }
}
