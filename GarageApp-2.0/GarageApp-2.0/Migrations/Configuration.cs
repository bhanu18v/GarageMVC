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
              //  VehicleType = "Car",
                RegistrationNumber = "AZP123",
                Color = "White",
                Brand = "New",
                Model = "2002",
                NoOfWheels = 4,
               
            });
            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
            {
              //  VehicleType = "Bus",
                RegistrationNumber = "MZP123",
                Color = "Blue",
                Brand = "Old",
                Model = "2003",
                NoOfWheels = 8

            });



        }


    }
}
