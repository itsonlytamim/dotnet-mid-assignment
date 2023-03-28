namespace dot_net_mid_assignment_Tamim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CollectRequests", "restaurant_id1", "dbo.Restaurants");
            DropIndex("dbo.CollectRequests", new[] { "restaurant_id1" });
            DropIndex("dbo.CollectRequests", new[] { "Employee_id" });
            DropColumn("dbo.CollectRequests", "restaurant_id");
            RenameColumn(table: "dbo.CollectRequests", name: "restaurant_id1", newName: "restaurant_id");
            AlterColumn("dbo.CollectRequests", "restaurant_id", c => c.Int(nullable: false));
            CreateIndex("dbo.CollectRequests", "employee_id");
            CreateIndex("dbo.CollectRequests", "restaurant_id");
            AddForeignKey("dbo.CollectRequests", "restaurant_id", "dbo.Restaurants", "id", cascadeDelete: true);
            DropColumn("dbo.CollectRequests", "assigned_employee_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CollectRequests", "assigned_employee_id", c => c.Int(nullable: false));
            DropForeignKey("dbo.CollectRequests", "restaurant_id", "dbo.Restaurants");
            DropIndex("dbo.CollectRequests", new[] { "restaurant_id" });
            DropIndex("dbo.CollectRequests", new[] { "employee_id" });
            AlterColumn("dbo.CollectRequests", "restaurant_id", c => c.Int());
            RenameColumn(table: "dbo.CollectRequests", name: "restaurant_id", newName: "restaurant_id1");
            AddColumn("dbo.CollectRequests", "restaurant_id", c => c.Int(nullable: false));
            CreateIndex("dbo.CollectRequests", "Employee_id");
            CreateIndex("dbo.CollectRequests", "restaurant_id1");
            AddForeignKey("dbo.CollectRequests", "restaurant_id1", "dbo.Restaurants", "id");
        }
    }
}
