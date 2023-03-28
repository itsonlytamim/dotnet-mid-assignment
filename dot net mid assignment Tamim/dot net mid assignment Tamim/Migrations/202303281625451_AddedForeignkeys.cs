namespace dot_net_mid_assignment_Tamim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignkeys : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CollectRequests", "AssignedEmployee_id", c => c.Int());
            AlterColumn("dbo.CollectRequests", "Restaurant_id", c => c.Int());
            AlterColumn("dbo.CollectRequests", "description", c => c.String(nullable: false));
            CreateIndex("dbo.CollectRequests", "AssignedEmployee_id");
            CreateIndex("dbo.CollectRequests", "Restaurant_id");
            AddForeignKey("dbo.CollectRequests", "AssignedEmployee_id", "dbo.Employees", "id");
            AddForeignKey("dbo.CollectRequests", "Restaurant_id", "dbo.Restaurants", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CollectRequests", "Restaurant_id", "dbo.Restaurants");
            DropForeignKey("dbo.CollectRequests", "AssignedEmployee_id", "dbo.Employees");
            DropIndex("dbo.CollectRequests", new[] { "Restaurant_id" });
            DropIndex("dbo.CollectRequests", new[] { "AssignedEmployee_id" });
            AlterColumn("dbo.CollectRequests", "description", c => c.String());
            AlterColumn("dbo.CollectRequests", "Restaurant_id", c => c.Int(nullable: false));
            DropColumn("dbo.CollectRequests", "AssignedEmployee_id");
        }
    }
}
