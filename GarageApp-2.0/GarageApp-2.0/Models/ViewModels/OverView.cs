using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageApp_2._0.Models.ViewModels
{
    public class OverView
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string VehicleType { get; set; }
        public string Color { get; set; }
        public DateTime ParkingTime { get; set; }

        public OverView()
        {

        }
        public OverView(ParkedVehicle parkedvehicle)
        {
            Id = parkedvehicle.Id;
            RegistrationNumber = parkedvehicle.RegistrationNumber;
           VehicleType = parkedvehicle.VehicleType.ToString();
            Color = parkedvehicle.Color;
            ParkingTime = parkedvehicle.ParkingTime;

        }

    }

    

}