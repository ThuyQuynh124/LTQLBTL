using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQLBTL.Models;

namespace LTQLBTL.Controllers
{
    public class PHIEUDANGKIsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: PHIEUDANGKIs
        public ActionResult Index()
        {
            return View(db.PHIEUDANGKIs.ToList());
        }

        // GET: PHIEUDANGKIs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUDANGKI pHIEUDANGKI = db.PHIEUDANGKIs.Find(id);
            if (pHIEUDANGKI == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUDANGKI);
        }

        // GET: PHIEUDANGKIs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PHIEUDANGKIs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPDK,MaNV,Ngaydk")] PHIEUDANGKI pHIEUDANGKI)
        {
            if (ModelState.IsValid)
            {
                db.PHIEUDANGKIs.Add(pHIEUDANGKI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pHIEUDANGKI);
        }

        // GET: PHIEUDANGKIs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUDANGKI pHIEUDANGKI = db.PHIEUDANGKIs.Find(id);
            if (pHIEUDANGKI == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUDANGKI);
        }

        // POST: PHIEUDANGKIs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPDK,MaNV,Ngaydk")] PHIEUDANGKI pHIEUDANGKI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pHIEUDANGKI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pHIEUDANGKI);
        }

        // GET: PHIEUDANGKIs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUDANGKI pHIEUDANGKI = db.PHIEUDANGKIs.Find(id);
            if (pHIEUDANGKI == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUDANGKI);
        }

        // POST: PHIEUDANGKIs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PHIEUDANGKI pHIEUDANGKI = db.PHIEUDANGKIs.Find(id);
            db.PHIEUDANGKIs.Remove(pHIEUDANGKI);
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
