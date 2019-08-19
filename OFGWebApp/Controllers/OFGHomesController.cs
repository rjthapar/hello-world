using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OFGWebApp.Models;

namespace OFGWebApp.Controllers
{
    public class OFGHomesController : Controller
    {
        private OFGWebAppContext db = new OFGWebAppContext();

        // GET: OFGHomes
        public ActionResult Index()
        {
            return View(db.OFGHomes.ToList());
        }

        // GET: OFGHomes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OFGHome oFGHome = db.OFGHomes.Find(id);
            if (oFGHome == null)
            {
                return HttpNotFound();
            }
            return View(oFGHome);
        }

        // GET: OFGHomes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OFGHomes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,userId,jiraNumber,applicationDescription,status,functionalitiesToImplement,expectedUatDeliveryDate,prodDeploymentDate,pendingInfo,comments")] OFGHome oFGHome)
        {
            if (ModelState.IsValid)
            {
                db.OFGHomes.Add(oFGHome);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oFGHome);
        }

        // GET: OFGHomes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OFGHome oFGHome = db.OFGHomes.Find(id);
            if (oFGHome == null)
            {
                return HttpNotFound();
            }
            return View(oFGHome);
        }

        // POST: OFGHomes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,userId,jiraNumber,applicationDescription,status,functionalitiesToImplement,expectedUatDeliveryDate,prodDeploymentDate,pendingInfo,comments")] OFGHome oFGHome)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oFGHome).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oFGHome);
        }

        // GET: OFGHomes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OFGHome oFGHome = db.OFGHomes.Find(id);
            if (oFGHome == null)
            {
                return HttpNotFound();
            }
            return View(oFGHome);
        }

        // POST: OFGHomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OFGHome oFGHome = db.OFGHomes.Find(id);
            db.OFGHomes.Remove(oFGHome);
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
