using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace GarageApp_2._0.DataAccessLayer
{
    public class GarageContext : DbContext
    {
        public GarageContext() : base ("GarageDatabase")
        {
            // Blank Constructor
        }

        public DbSet<Models.ParkedVehicle> ParkedVehicles { get; set; } // A table in our Database which is called Parked-Vehicles


    }
}