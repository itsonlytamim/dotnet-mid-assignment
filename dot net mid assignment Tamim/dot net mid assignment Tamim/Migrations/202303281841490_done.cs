namespace dot_net_mid_assignment_Tamim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class done : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CollectRequests", name: "assignedEmployee_id", newName: "Employee_id");
            RenameIndex(table: "dbo.CollectRequests", name: "IX_assignedEmployee_id", newName: "IX_Employee_id");
            AlterColumn("dbo.CollectRequests", "description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CollectRequests", "description", c => c.String(nullable: false));
            RenameIndex(table: "dbo.CollectRequests", name: "IX_Employee_id", newName: "IX_assignedEmployee_id");
            RenameColumn(table: "dbo.CollectRequests", name: "Employee_id", newName: "assignedEmployee_id");
        }
    }
}
