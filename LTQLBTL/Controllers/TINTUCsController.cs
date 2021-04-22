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
    public class TINTUCsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: TINTUCs
        public ActionResult Index()
        {
            return View(db.TINTUCs.ToList());
        }

        // GET: TINTUCs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TINTUC tINTUC = db.TINTUCs.Find(id);
            if (tINTUC == null)
            {
                return HttpNotFound();
            }
            return View(tINTUC);
        }

        // GET: TINTUCs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TINTUCs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TieuDe,NoiDung")] TINTUC tINTUC)
        {
            if (ModelState.IsValid)
            {
                db.TINTUCs.Add(tINTUC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tINTUC);
        }

        // GET: TINTUCs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TINTUC tINTUC = db.TINTUCs.Find(id);
            if (tINTUC == null)
            {
                return HttpNotFound();
            }
            return View(tINTUC);
        }

        // POST: TINTUCs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TieuDe,NoiDung")] TINTUC tINTUC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tINTUC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tINTUC);
        }

        // GET: TINTUCs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TINTUC tINTUC = db.TINTUCs.Find(id);
            if (tINTUC == null)
            {
                return HttpNotFound();
            }
            return View(tINTUC);
        }

        // POST: TINTUCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TINTUC tINTUC = db.TINTUCs.Find(id);
            db.TINTUCs.Remove(tINTUC);
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
