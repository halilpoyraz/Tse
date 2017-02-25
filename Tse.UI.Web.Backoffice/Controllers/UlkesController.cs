using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tse.Dal.Backoffice.Model;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class UlkesController : Controller
    {
        private TseBackofficeContext db = new TseBackofficeContext();

        // GET: Ulkes
        public ActionResult Index()
        {
            var ulkeler = db.Ulkeler.Include(u => u.Durum);
            return View(ulkeler.ToList());
        }

        // GET: Ulkes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ulke ulke = db.Ulkeler.Find(id);
            if (ulke == null)
            {
                return HttpNotFound();
            }
            return View(ulke);
        }

        // GET: Ulkes/Create
        public ActionResult Create()
        {
            ViewBag.DurumID = new SelectList(db.Durumlar, "DurumID", "DurumAdi");
            return View();
        }

        // POST: Ulkes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UlkeID,UlkeAdi,DurumID")] Ulke ulke)
        {
            if (ModelState.IsValid)
            {
                db.Ulkeler.Add(ulke);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DurumID = new SelectList(db.Durumlar, "DurumID", "DurumAdi", ulke.DurumID);
            return View(ulke);
        }

        // GET: Ulkes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ulke ulke = db.Ulkeler.Find(id);
            if (ulke == null)
            {
                return HttpNotFound();
            }
            ViewBag.DurumID = new SelectList(db.Durumlar, "DurumID", "DurumAdi", ulke.DurumID);
            return View(ulke);
        }

        // POST: Ulkes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UlkeID,UlkeAdi,DurumID")] Ulke ulke)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ulke).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DurumID = new SelectList(db.Durumlar, "DurumID", "DurumAdi", ulke.DurumID);
            return View(ulke);
        }

        // GET: Ulkes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ulke ulke = db.Ulkeler.Find(id);
            if (ulke == null)
            {
                return HttpNotFound();
            }
            return View(ulke);
        }

        // POST: Ulkes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ulke ulke = db.Ulkeler.Find(id);
            db.Ulkeler.Remove(ulke);
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
