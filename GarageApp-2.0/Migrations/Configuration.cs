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
                vehicleType= Models.ParkedVehicle.VehicleType.Tractor

            });
            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
        {

            RegistrationNumber = "MZP123",
                Color = "blue",
                Brand = "Old",
                Model = "2003",
                NumberOfWheels = 8

            });
            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
        {

            RegistrationNumber = "BHN456",
                Color = "grey",
                Brand = "Benz",
                Model = "1997",
                NumberOfWheels = 4

            });
            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
        {

            RegistrationNumber = "SAI234",
                Color = "grey",
                Brand = "Audi",
                Model = "1998",
                NumberOfWheels = 4

            });
            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
        {

            RegistrationNumber = "FAZ345",
                Color = "pink",
                Brand = "RangeRover",
                Model = "2000",
                NumberOfWheels = 4

            });
            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
        {

            RegistrationNumber = "345",
                Color = "purple",
                Brand = "RangeRover",
                Model = "2000",
                NumberOfWheels = 10

            });



            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
            {

                RegistrationNumber = "YEO5475",
                Color = "Grey",
                Brand = "Volvo",
                Model = "2045e",
                NumberOfWheels = 4,
                vehicleType = Models.ParkedVehicle.VehicleType.Tractor

            });




            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
            {

                RegistrationNumber = "OW354",
                Color = "Black",
                Brand = "Ford",
                Model = "1995",
                NumberOfWheels = 2,
                vehicleType = Models.ParkedVehicle.VehicleType.Motorcycle

            });


            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
            {

                RegistrationNumber = "DOD65",
                Color = "RED",
                Brand = "Ferrari",
                Model = "1989",
                NumberOfWheels = 2,
                vehicleType = Models.ParkedVehicle.VehicleType.Motorcycle

            });

            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
            {

                RegistrationNumber = "SA2487",
                Color = "Brown",
                Brand = "BOING",
                Model = "AIRWAYS",
                NumberOfWheels = 3,
                vehicleType = Models.ParkedVehicle.VehicleType.Airplane

            });


            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
            {

                RegistrationNumber = "QDP66",
                Color = "Yellow",
                Brand = "AirBUS",
                Model = "AIRJET2",
                NumberOfWheels = 3,
                vehicleType = Models.ParkedVehicle.VehicleType.Airplane

            });

            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
            {

                RegistrationNumber = "OE3209",
                Color = "Orange",
                Brand = "Yatchoo",
                Model = "Y293",
                NumberOfWheels = 0,
                vehicleType = Models.ParkedVehicle.VehicleType.Boat

            });

            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
            {

                RegistrationNumber = "XXWE4",
                Color = "Purple",
                Brand = "Titanic",
                Model = "TITA93",
                NumberOfWheels = 0,
                vehicleType = Models.ParkedVehicle.VehicleType.Boat

            });



            context.ParkedVehicles.AddOrUpdate(n => n.RegistrationNumber, new ParkedVehicle()
            {

                RegistrationNumber = "LMSE4",
                Color = "PINK",
                Brand = "Monster",
                Model = "M203A",
                NumberOfWheels = 0,
                vehicleType = Models.ParkedVehicle.VehicleType.Truck

            });








        }
    }
}
