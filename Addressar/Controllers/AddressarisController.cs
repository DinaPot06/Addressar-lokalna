using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Addressar.Models;

namespace Addressar.Controllers
{
    public class AddressarisController : Controller
    {
        private AddressarContext db = new AddressarContext();

        // GET: Addressaris
        public ActionResult Index()
        {
            return View(db.Addressars.ToList());
        }

        // GET: Addressaris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Addressari addressari = db.Addressars.Find(id);
            if (addressari == null)
            {
                return HttpNotFound();
            }
            return View(addressari);
        }

        // GET: Addressaris/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Addressaris/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Surname,StreetAddress,City,ZipCode,HomePhone,CellPhone,WorkPhone,Email")] Addressari addressari)
        {
            if (ModelState.IsValid)
            {
                db.Addressars.Add(addressari);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addressari);
        }

        // GET: Addressaris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Addressari addressari = db.Addressars.Find(id);
            if (addressari == null)
            {
                return HttpNotFound();
            }
            return View(addressari);
        }

        // POST: Addressaris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Surname,StreetAddress,City,ZipCode,HomePhone,CellPhone,WorkPhone,Email")] Addressari addressari)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addressari).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addressari);
        }

        // GET: Addressaris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Addressari addressari = db.Addressars.Find(id);
            if (addressari == null)
            {
                return HttpNotFound();
            }
            return View(addressari);
        }

        // POST: Addressaris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Addressari addressari = db.Addressars.Find(id);
            db.Addressars.Remove(addressari);
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
