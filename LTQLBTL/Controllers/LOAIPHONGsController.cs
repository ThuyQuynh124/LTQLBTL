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
    public class LOAIPHONGsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: LOAIPHONGs
        public ActionResult Index()
        {
            return View(db.LOAIPHONGs.ToList());
        }

        // GET: LOAIPHONGs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAIPHONG lOAIPHONG = db.LOAIPHONGs.Find(id);
            if (lOAIPHONG == null)
            {
                return HttpNotFound();
            }
            return View(lOAIPHONG);
        }

        // GET: LOAIPHONGs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LOAIPHONGs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoai,TenLoai,ChiTiet")] LOAIPHONG lOAIPHONG)
        {
            if (ModelState.IsValid)
            {
                db.LOAIPHONGs.Add(lOAIPHONG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lOAIPHONG);
        }

        // GET: LOAIPHONGs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAIPHONG lOAIPHONG = db.LOAIPHONGs.Find(id);
            if (lOAIPHONG == null)
            {
                return HttpNotFound();
            }
            return View(lOAIPHONG);
        }

        // POST: LOAIPHONGs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoai,TenLoai,ChiTiet")] LOAIPHONG lOAIPHONG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lOAIPHONG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lOAIPHONG);
        }

        // GET: LOAIPHONGs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAIPHONG lOAIPHONG = db.LOAIPHONGs.Find(id);
            if (lOAIPHONG == null)
            {
                return HttpNotFound();
            }
            return View(lOAIPHONG);
        }

        // POST: LOAIPHONGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LOAIPHONG lOAIPHONG = db.LOAIPHONGs.Find(id);
            db.LOAIPHONGs.Remove(lOAIPHONG);
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
