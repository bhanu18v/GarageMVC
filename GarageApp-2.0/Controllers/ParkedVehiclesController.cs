using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GarageApp_2._0.DataAccessLayer;
using GarageApp_2._0.Models;
using GarageApp_2._0.Models.ViewModel;

namespace GarageApp_2._0.Controllers
{
    public class ParkedVehiclesController : Controller
    {
        private GarageContext db = new GarageContext();
        public string timeToDisplay { get; set; }

        // GET: ParkedVehicles
        public ActionResult Index(string sortOrder, string searchString)
        {
            List<Overview> pv = new List<Overview>();

      
            ViewBag.RegistrationNumber = String.IsNullOrEmpty(sortOrder) ? "RegistrationNumber" : "";
            ViewBag.Color = String.IsNullOrEmpty(sortOrder) ? "Color" : "";
            ViewBag.ParkedTime = String.IsNullOrEmpty(sortOrder) ? "ParkedTime" : "";
            ViewBag.VehicleType = String.IsNullOrEmpty(sortOrder) ? "VehicleType" : "";
            foreach (var vehicle in db.ParkedVehicles)
            {
                pv.Add(new Overview(vehicle));
            }

            var vm = from s in pv select s;
            if (!string.IsNullOrEmpty(searchString))
            {

                vm = vm.Where(s => s.RegNr.ToLower().Contains(searchString.ToLower()));
                return View(vm.ToList());
            }


            switch (sortOrder)
            {

                case "VehicleType":

                    pv = pv.OrderByDescending(t => t.Type.ToString()).ToList();

                    break;
                case "Color":
                    pv = pv.OrderByDescending(t => t.Color.ToString()).ToList();
                    break;
                case "RegistrationNumber":
                    pv = pv.OrderByDescending(t => t.RegNr).ToList();
                    break;
                case "ParkingTime":
                    pv = pv.OrderByDescending(t => t.ParkedTime).ToList();
                    break;

                default:

                    pv = pv.OrderBy(t => t.RegNr.ToString()).ToList();
                    break;
            }
            return View(pv);



        }






        // GET: ParkedVehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.ParkedVehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Create
        public ActionResult Park()
        {
            return View();
        }

        // POST: ParkedVehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Park([Bind(Include = "Id,VehicleType,RegistrationNumber,Color,Brand,Model,NumberOfWheels,TimeParked")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.ParkedVehicles.Add(parkedVehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parkedVehicle);
        }


      
        public ActionResult Receipt(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ParkedVehicle parkedVehicle = db.ParkedVehicles.Find(id);
            Receipt model = new Receipt(parkedVehicle);

            model.CheckoutTime = DateTime.Now;
            model.TotalTime = model.CheckoutTime - parkedVehicle.TimeParked;

            model.TotalPrice = (model.TotalTime.TotalMinutes / 60) * 10;
            return View(model);

        }

     
        [HttpPost, ActionName("Receipt")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParkedVehicle parkedVehicle = db.ParkedVehicles.Find(id);
            db.ParkedVehicles.Remove(parkedVehicle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
