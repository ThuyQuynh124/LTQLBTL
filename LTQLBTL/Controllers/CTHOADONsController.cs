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
    public class CTHOADONsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: CTHOADONs
        public ActionResult Index()
        {
            var cTHOADONs = db.CTHOADONs.Include(c => c.HOADON).Include(c => c.PHIEUDANGKI);
            return View(cTHOADONs.ToList());
        }

        // GET: CTHOADONs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTHOADON cTHOADON = db.CTHOADONs.Find(id);
            if (cTHOADON == null)
            {
                return HttpNotFound();
            }
            return View(cTHOADON);
        }

        // GET: CTHOADONs/Create
        public ActionResult Create()
        {
            ViewBag.MaHD = new SelectList(db.HOADONs, "MaHD", "NhanVienLap");
            ViewBag.MaPDK = new SelectList(db.PHIEUDANGKIs, "MaPDK", "MaNV");
            return View();
        }

        // POST: CTHOADONs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCTHD,MaHD,MaPDK,PHONG,TienPhong,TienDV")] CTHOADON cTHOADON)
        {
            if (ModelState.IsValid)
            {
                db.CTHOADONs.Add(cTHOADON);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaHD = new SelectList(db.HOADONs, "MaHD", "NhanVienLap", cTHOADON.MaHD);
            ViewBag.MaPDK = new SelectList(db.PHIEUDANGKIs, "MaPDK", "MaNV", cTHOADON.MaPDK);
            return View(cTHOADON);
        }

        // GET: CTHOADONs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTHOADON cTHOADON = db.CTHOADONs.Find(id);
            if (cTHOADON == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaHD = new SelectList(db.HOADONs, "MaHD", "NhanVienLap", cTHOADON.MaHD);
            ViewBag.MaPDK = new SelectList(db.PHIEUDANGKIs, "MaPDK", "MaNV", cTHOADON.MaPDK);
            return View(cTHOADON);
        }

        // POST: CTHOADONs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCTHD,MaHD,MaPDK,PHONG,TienPhong,TienDV")] CTHOADON cTHOADON)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cTHOADON).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaHD = new SelectList(db.HOADONs, "MaHD", "NhanVienLap", cTHOADON.MaHD);
            ViewBag.MaPDK = new SelectList(db.PHIEUDANGKIs, "MaPDK", "MaNV", cTHOADON.MaPDK);
            return View(cTHOADON);
        }

        // GET: CTHOADONs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CTHOADON cTHOADON = db.CTHOADONs.Find(id);
            if (cTHOADON == null)
            {
                return HttpNotFound();
            }
            return View(cTHOADON);
        }

        // POST: CTHOADONs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CTHOADON cTHOADON = db.CTHOADONs.Find(id);
            db.CTHOADONs.Remove(cTHOADON);
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
