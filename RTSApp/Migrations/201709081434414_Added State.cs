namespace RTSApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedState : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateID = c.Int(nullable: false, identity: true),
                        StateName = c.String(maxLength: 200),
                        StateAbbrev = c.String(),
                    })
                .PrimaryKey(t => t.StateID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.States");
        }
    }
}
