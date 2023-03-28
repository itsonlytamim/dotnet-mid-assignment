namespace dot_net_mid_assignment_Tamim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finishing : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CollectRequests", "Restaurant_id", "dbo.Restaurants");
            DropIndex("dbo.CollectRequests", new[] { "Restaurant_id" });
            RenameColumn(table: "dbo.CollectRequests", name: "Employee_id", newName: "assignedEmployee_id");
            RenameIndex(table: "dbo.CollectRequests", name: "IX_Employee_id", newName: "IX_assignedEmployee_id");
            AddColumn("dbo.CollectRequests", "restaurant_id1", c => c.Int());
            AlterColumn("dbo.CollectRequests", "restaurant_id", c => c.Int(nullable: false));
            CreateIndex("dbo.CollectRequests", "restaurant_id1");
            AddForeignKey("dbo.CollectRequests", "restaurant_id1", "dbo.Restaurants", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CollectRequests", "restaurant_id1", "dbo.Restaurants");
            DropIndex("dbo.CollectRequests", new[] { "restaurant_id1" });
            AlterColumn("dbo.CollectRequests", "restaurant_id", c => c.Int());
            DropColumn("dbo.CollectRequests", "restaurant_id1");
            RenameIndex(table: "dbo.CollectRequests", name: "IX_assignedEmployee_id", newName: "IX_Employee_id");
            RenameColumn(table: "dbo.CollectRequests", name: "assignedEmployee_id", newName: "Employee_id");
            CreateIndex("dbo.CollectRequests", "Restaurant_id");
            AddForeignKey("dbo.CollectRequests", "Restaurant_id", "dbo.Restaurants", "id");
        }
    }
}
