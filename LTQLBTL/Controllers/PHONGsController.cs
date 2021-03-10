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
    public class PHONGsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: PHONGs
        public ActionResult Index()
        {
            return View(db.PHONGs.ToList());
        }

        // GET: PHONGs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHONG pHONG = db.PHONGs.Find(id);
            if (pHONG == null)
            {
                return HttpNotFound();
            }
            return View(pHONG);
        }

        // GET: PHONGs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PHONGs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhong,TenLoaiPHong,HienTrang,SoNguoi,SoDTPhong")] PHONG pHONG)
        {
            if (ModelState.IsValid)
            {
                db.PHONGs.Add(pHONG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pHONG);
        }

        // GET: PHONGs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHONG pHONG = db.PHONGs.Find(id);
            if (pHONG == null)
            {
                return HttpNotFound();
            }
            return View(pHONG);
        }

        // POST: PHONGs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPhong,TenLoaiPHong,HienTrang,SoNguoi,SoDTPhong")] PHONG pHONG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pHONG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pHONG);
        }

        // GET: PHONGs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHONG pHONG = db.PHONGs.Find(id);
            if (pHONG == null)
            {
                return HttpNotFound();
            }
            return View(pHONG);
        }

        // POST: PHONGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PHONG pHONG = db.PHONGs.Find(id);
            db.PHONGs.Remove(pHONG);
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
