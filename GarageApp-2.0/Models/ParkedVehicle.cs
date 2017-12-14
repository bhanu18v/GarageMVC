using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
namespace GarageApp_2._0.Models
{
    public class ParkedVehicle
    {
           

        public int Id { get; set; }

       
        public enum VehicleType
        {

            Car,
            Bus,
            Truck,
            Tractor,
            Boat,
            Motorcycle,
            Airplane,

        }

        public VehicleType vehicleType { get; set; }
       

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9'' ']+$", ErrorMessage = "Special characters are not accepted")]
        public string RegistrationNumber { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z'' ']+$", ErrorMessage = "Special characters  & Numbers should not be entered")]
        public string Color { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z'' ']+$", ErrorMessage = "Special characters  & Numbers should not be entered")]
        public string Brand { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9'' ']+$", ErrorMessage = "Special characters  & Numbers should not be entered")]
        public string Model { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Number")]
        public int? NumberOfWheels { get; set; }



        // adding Time Parked Property to set the parked time auto.
        public DateTime TimeParked { get; set; }

        public ParkedVehicle()
        {
            TimeParked = DateTime.Now;
           
        }

      

    }
}