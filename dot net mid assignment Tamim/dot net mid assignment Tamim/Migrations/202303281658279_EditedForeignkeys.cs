namespace dot_net_mid_assignment_Tamim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedForeignkeys : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.CollectRequests", new[] { "Restaurant_id" });
            RenameColumn(table: "dbo.CollectRequests", name: "AssignedEmployee_id", newName: "Employee_id");
            RenameIndex(table: "dbo.CollectRequests", name: "IX_AssignedEmployee_id", newName: "IX_Employee_id");
            AlterColumn("dbo.CollectRequests", "Restaurant_id", c => c.Int());
            AlterColumn("dbo.CollectRequests", "restaurant_id", c => c.Int(nullable: false));
            CreateIndex("dbo.CollectRequests", "Restaurant_id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.CollectRequests", new[] { "Restaurant_id" });
            AlterColumn("dbo.CollectRequests", "restaurant_id", c => c.Int());
            AlterColumn("dbo.CollectRequests", "Restaurant_id", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.CollectRequests", name: "IX_Employee_id", newName: "IX_AssignedEmployee_id");
            RenameColumn(table: "dbo.CollectRequests", name: "Employee_id", newName: "AssignedEmployee_id");
            CreateIndex("dbo.CollectRequests", "Restaurant_id");
        }
    }
}
