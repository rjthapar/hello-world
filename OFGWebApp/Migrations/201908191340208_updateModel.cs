namespace OFGWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OFGHomes", "status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OFGHomes", "status", c => c.String());
        }
    }
}
