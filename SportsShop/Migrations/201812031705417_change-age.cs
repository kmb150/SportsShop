namespace SportsShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 25),
                        LastName = c.String(nullable: false, maxLength: 25),
                        Email = c.String(nullable: false, maxLength: 25),
                        Age = c.Int(nullable: false),
                        FullAddress = c.String(nullable: false, maxLength: 100),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
