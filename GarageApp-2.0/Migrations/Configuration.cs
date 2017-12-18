namespace GarageApp_2._0.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GarageApp_2._0.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<GarageApp_2._0.DataAccessLayer.GarageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GarageApp_2._0.DataAccessLayer.GarageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
            {

                RegistrationNumber = "AZP123",
                Color = "white",
                Brand = "New",
                Model = "2002",
                NumberOfWheels = 4,
                vehicleType = Models.ParkedVehicle.VehicleType.Tractor

            });
            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
            {

                RegistrationNumber = "MZP123",
                Color = "blue",
                Brand = "Old",
                Model = "2003",
                NumberOfWheels = 8

            });



        }
    }
}
