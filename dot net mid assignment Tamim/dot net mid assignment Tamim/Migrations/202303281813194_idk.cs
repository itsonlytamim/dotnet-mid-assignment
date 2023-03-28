namespace dot_net_mid_assignment_Tamim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class idk : DbMigration
    {
        
            public override void Up()
            {
                DropIndex("dbo.CollectRequests", new[] { "restaurant_id" });
                DropColumn("dbo.CollectRequests", "restaurant_id");
                AddColumn("dbo.CollectRequests", "restaurant_id1", c => c.Int());
                CreateIndex("dbo.CollectRequests", "restaurant_id1");
                AddForeignKey("dbo.CollectRequests", "restaurant_id1", "dbo.Restaurants", "id");
        }

        public override void Down()
            {
                DropIndex("dbo.CollectRequests", new[] { "restaurant_id1" });
                DropColumn("dbo.CollectRequests", "restaurant_id1");
                AddColumn("dbo.CollectRequests", "restaurant_id", c => c.Int());
                CreateIndex("dbo.CollectRequests", "restaurant_id");
             AddForeignKey("dbo.CollectRequests", "restaurant_id", "dbo.Restaurants", "id");

        }
    }

    }

