namespace BBGFrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Boardgames", "Category", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Boardgames", "Category", c => c.Int(nullable: false));
        }
    }
}
