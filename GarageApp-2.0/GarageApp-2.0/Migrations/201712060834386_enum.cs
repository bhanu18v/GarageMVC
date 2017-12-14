namespace GarageApp_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _enum : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ParkedVehicles", "VehicleType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ParkedVehicles", "VehicleType", c => c.String());
        }
    }
}
