namespace SportsShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tempMigration : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Products", "ImageUrl", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ImageUrl");
        }
    }
}
