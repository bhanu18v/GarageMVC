namespace GarageApp_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bhanu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParkedVehicles", "ParkingTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ParkedVehicles", "ParkingTime");
        }
    }
}
