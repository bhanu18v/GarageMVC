using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GarageApp_2._0.Models.ViewModel
{
    public class Receipt
    {
        public int Id { get; set; }
        [DisplayName("Registration Number")]
        public string RegNr { get; set; }
        [DisplayName("Vehicle Type")]
        public string Type { get; set; }
   
        public string Color { get; set; }
        [DisplayName("Parked Time")]
        public DateTime ParkedTime { get; set; }
        [DisplayName("Check Out Time")]
        public DateTime CheckoutTime { get; set; }
        [DisplayName("Total Time In hr/mm")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        public TimeSpan TotalTime { get; set; }
        [DisplayName("AMOUNT")]
        [DisplayFormat(DataFormatString = "{0:#.##}")]
        public double TotalPrice { get; set; }
       


        public Receipt(ParkedVehicle vehicles)
        {
            Id = vehicles.Id;
            RegNr = vehicles.RegistrationNumber;
            Type = vehicles.vehicleType.ToString();
            Color = vehicles.Color;
            ParkedTime = vehicles.TimeParked;
            CheckoutTime = DateTime.Now;

           
        }
    }
}