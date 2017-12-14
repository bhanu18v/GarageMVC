using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GarageApp_2._0;
using GarageApp_2._0.Models;


namespace GarageApp_2._0.Models.ViewModel
{
    public class Overview
    {
        public int Id { get; set; }
        public string RegNr { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public DateTime ParkedTime { get; set; }
       

        public Overview(ParkedVehicle vehicles)
        {
            Id = vehicles.Id;
            RegNr = vehicles.RegistrationNumber;
            Type = vehicles.vehicleType.ToString(); 
            Color = vehicles.Color;
            ParkedTime = vehicles.TimeParked;
            
        }
    }
}