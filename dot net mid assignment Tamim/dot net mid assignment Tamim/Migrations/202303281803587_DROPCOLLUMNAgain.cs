namespace dot_net_mid_assignment_Tamim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DROPCOLLUMNAgain : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CollectRequests", "restaurant_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CollectRequests", "restaurant_id", c => c.Int(nullable: false));
        }
    }
}
