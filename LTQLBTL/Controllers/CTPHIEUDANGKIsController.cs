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
    public class CTPHIEUDANGKIsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: CTPHIEUDANGKIs
        public ActionResult Index()
        {
            var cTPHIEUDANGKIs = db.CTPHIEUDANGKIs.Include(c => c.PHIEUDANGKI);
            return View(cTPHIEUDANGKIs.ToList());
        }

        // GET: CTPHIEUDANGKIs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTPHIEUDANGKI cTPHIEUDANGKI = db.CTPHIEUDANGKIs.Find(id);
            if (cTPHIEUDANGKI == null)
            {
                return HttpNotFound();
            }
            return View(cTPHIEUDANGKI);
        }

        // GET: CTPHIEUDANGKIs/Create
        public ActionResult Create()
        {
            ViewBag.MaPDK = new SelectList(db.PHIEUDANGKIs, "MaPDK", "MaNV");
            return View();
        }

        // POST: CTPHIEUDANGKIs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCTPDK,MaPDK,MaKH,SoNguoi,NgayDen,NgayDi")] CTPHIEUDANGKI cTPHIEUDANGKI)
        {
            if (ModelState.IsValid)
            {
                db.CTPHIEUDANGKIs.Add(cTPHIEUDANGKI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaPDK = new SelectList(db.PHIEUDANGKIs, "MaPDK", "MaNV", cTPHIEUDANGKI.MaPDK);
            return View(cTPHIEUDANGKI);
        }

        // GET: CTPHIEUDANGKIs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTPHIEUDANGKI cTPHIEUDANGKI = db.CTPHIEUDANGKIs.Find(id);
            if (cTPHIEUDANGKI == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaPDK = new SelectList(db.PHIEUDANGKIs, "MaPDK", "MaNV", cTPHIEUDANGKI.MaPDK);
            return View(cTPHIEUDANGKI);
        }

        // POST: CTPHIEUDANGKIs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCTPDK,MaPDK,MaKH,SoNguoi,NgayDen,NgayDi")] CTPHIEUDANGKI cTPHIEUDANGKI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cTPHIEUDANGKI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaPDK = new SelectList(db.PHIEUDANGKIs, "MaPDK", "MaNV", cTPHIEUDANGKI.MaPDK);
            return View(cTPHIEUDANGKI);
        }

        // GET: CTPHIEUDANGKIs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTPHIEUDANGKI cTPHIEUDANGKI = db.CTPHIEUDANGKIs.Find(id);
            if (cTPHIEUDANGKI == null)
            {
                return HttpNotFound();
            }
            return View(cTPHIEUDANGKI);
        }

        // POST: CTPHIEUDANGKIs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CTPHIEUDANGKI cTPHIEUDANGKI = db.CTPHIEUDANGKIs.Find(id);
            db.CTPHIEUDANGKIs.Remove(cTPHIEUDANGKI);
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
