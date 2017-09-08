namespace RTSApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carriers",
                c => new
                    {
                        CarrierID = c.Int(nullable: false, identity: true),
                        MCNumber = c.String(maxLength: 50),
                        DOTNumber = c.Int(nullable: false),
                        Address1 = c.String(maxLength: 200),
                        Address2 = c.String(),
                        City = c.String(),
                        StateID = c.Int(nullable: false),
                        Zip = c.String(maxLength: 20),
                        Email = c.String(maxLength: 200),
                        WebURL = c.String(),
                        Active = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CarrierID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carriers");
        }
    }
}
