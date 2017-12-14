using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GarageApp_2._0.DataAccessLayer
{
    public class GarageContext : DbContext
    {
        public GarageContext():base("GarageDatabase")
        {

        }
        public DbSet<Models.ParkedVehicle> ParkedVehicles { get; set; }
        //public DbSet<Models.ParkedVehicle> OverviewParkedVehicles { get; set; }
    }
}