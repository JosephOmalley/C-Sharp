using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities1 db = new InsuranceEntities1();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insurees)
        {
            if (ModelState.IsValid)
            {
                insurees.Quote = 50.00m;
                if (DateTime.Now.Year - insurees.DateOfBirth.Year == 19) //checks if person is in their 19th year 
                {
                    if (DateTime.Now.Month <= insurees.DateOfBirth.Month) //checks to see if insuree on their 19th year and if their upcoming birthd month has already happened 
                    {
                        if (DateTime.Now.Month == insurees.DateOfBirth.Month && DateTime.Now.Day > insurees.DateOfBirth.Day) //checks if day of birth hasn't already happened 
                        {
                            insurees.Quote += 100.00m;
                        }
                        else if (DateTime.Now.Month < insurees.DateOfBirth.Month)
                        {
                            insurees.Quote += 100.00m;
                        }
                        
                    }
                }
                else if (DateTime.Now.Year - insurees.DateOfBirth.Year > 19 && DateTime.Now.Year - insurees.DateOfBirth.Year < 26)
                {
                    insurees.Quote += 50.00m;
                }
                else if (DateTime.Now.Year - insurees.DateOfBirth.Year > 26)
                {
                    insurees.Quote += 25.00m;
                }
                else if (DateTime.Now.Year - insurees.DateOfBirth.Year <= 18)
                {
                    insurees.Quote += 100.00m;
                }
                //Handles car year 
                if (insurees.CarYear < 2000)
                {
                    insurees.Quote += 25;
                }
                else if (insurees.CarYear > 2015)
                {
                    insurees.Quote += 25;
                }
                //Handles car Make 
                if (insurees.CarMake.ToLower() == "porsche")
                {
                    insurees.Quote += 25;
                }
                else if (insurees.CarMake.ToLower() == "porsche" && insurees.CarModel.ToLower() == "911 carrera")
                {
                    insurees.Quote += 25;
                }
                if (insurees.SpeedingTickets > 0)
                {
                    for (int i = 0; i < insurees.SpeedingTickets; i++)
                    {
                        insurees.Quote += 10;
                    }
                    
                }
                if (insurees.DUI > 0)
                {
                    insurees.Quote += insurees.Quote * Convert.ToDecimal(.25);
                }
                else if (insurees.CoverageType)
                {
                    insurees.Quote +=  insurees.Quote * Convert.ToDecimal(.50);
                }
                
                db.Insurees.Add(insurees);
                db.SaveChanges();
                return RedirectToAction("GetQuote", new { id = insurees.Id});
            }

            return View(insurees);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insurees)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insurees).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insurees);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurees insurees = db.Insurees.Find(id);
            db.Insurees.Remove(insurees);
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
        
        public ActionResult GetQuote(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            else
            { 

                    return View(insurees);
            }
            
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Admin()
        {

            return View(db.Insurees.ToList());
        }
    }
}
