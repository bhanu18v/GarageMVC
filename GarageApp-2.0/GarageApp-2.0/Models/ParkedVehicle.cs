using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageApp_2._0.Models
{
    public enum VehicleType
    {
        Car,
        Bus,
        Van,
        Airplane,
        Boat

    }
    public class ParkedVehicle
    {
        public int Id { get; set; }
     
        public VehicleType VehicleType { get; set; }
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NoOfWheels { get; set; }
        public DateTime ParkingTime { get; set; }

        public ParkedVehicle()
        {
            ParkingTime = DateTime.Now;
        }

 
    }
}