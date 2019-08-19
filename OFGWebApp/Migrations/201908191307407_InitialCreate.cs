namespace OFGWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OFGHomes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        userId = c.String(),
                        jiraNumber = c.Int(nullable: false),
                        applicationDescription = c.String(),
                        status = c.String(),
                        functionalitiesToImplement = c.String(),
                        expectedUatDeliveryDate = c.DateTime(nullable: false),
                        prodDeploymentDate = c.DateTime(nullable: false),
                        pendingInfo = c.String(),
                        comments = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OFGHomes");
        }
    }
}
