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
    [Authorize(Roles = "admin")]
    public class THONGTINsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: THONGTINs
        public ActionResult Index()
        {
            return View(db.THONGTINs.ToList());
        }

        // GET: THONGTINs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THONGTIN tHONGTIN = db.THONGTINs.Find(id);
            if (tHONGTIN == null)
            {
                return HttpNotFound();
            }
            return View(tHONGTIN);
        }

        // GET: THONGTINs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: THONGTINs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ThongTinID,TieuDe,NoiDung")] THONGTIN tHONGTIN)
        {
            if (ModelState.IsValid)
            {
                db.THONGTINs.Add(tHONGTIN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tHONGTIN);
        }

        // GET: THONGTINs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THONGTIN tHONGTIN = db.THONGTINs.Find(id);
            if (tHONGTIN == null)
            {
                return HttpNotFound();
            }
            return View(tHONGTIN);
        }

        // POST: THONGTINs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ThongTinID,TieuDe,NoiDung")] THONGTIN tHONGTIN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tHONGTIN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tHONGTIN);
        }

        // GET: THONGTINs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THONGTIN tHONGTIN = db.THONGTINs.Find(id);
            if (tHONGTIN == null)
            {
                return HttpNotFound();
            }
            return View(tHONGTIN);
        }

        // POST: THONGTINs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            THONGTIN tHONGTIN = db.THONGTINs.Find(id);
            db.THONGTINs.Remove(tHONGTIN);
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
