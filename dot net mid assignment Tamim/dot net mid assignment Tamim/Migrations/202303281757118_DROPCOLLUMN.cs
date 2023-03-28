namespace dot_net_mid_assignment_Tamim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DROPCOLLUMN : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CollectRequests", "assigned_employee_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CollectRequests", "assigned_employee_id", c => c.Int(nullable: false));

        }
    }
}
