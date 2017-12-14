using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageApp_2._0.Models.ViewModel
{
    public class Receipt
    {
        public int Id { get; set; }
        public string RegNr { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public DateTime ParkedTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public double TotalTime { get; set; }
        public double TotalPrice { get; set; }
        public string timeToDis { get; set; }


        public Receipt(ParkedVehicle vehicles)
        {
            Id = vehicles.Id;
            RegNr = vehicles.RegistrationNumber;
            Type = vehicles.vehicleType.ToString();
            Color = vehicles.Color;
            ParkedTime = vehicles.TimeParked;
            CheckoutTime = ParkedTime.AddMinutes(5);

           
        }
    }
}