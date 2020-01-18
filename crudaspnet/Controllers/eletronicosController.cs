using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using crudaspnet.Models;

namespace crudaspnet.Controllers
{
    public class eletronicosController : Controller
    {
        private contexto db = new contexto();

        // GET: eletronicos
        public ActionResult Index()
        {
            return View(db.Eletronico.ToList());
        }

        // GET: eletronicos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            eletronico eletronico = db.Eletronico.Find(id);
            if (eletronico == null)
            {
                return HttpNotFound();
            }
            return View(eletronico);
        }

        // GET: eletronicos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: eletronicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codigo,aparelho,descricao")] eletronico eletronico)
        {
            if (ModelState.IsValid)
            {
                db.Eletronico.Add(eletronico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eletronico);
        }

        // GET: eletronicos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            eletronico eletronico = db.Eletronico.Find(id);
            if (eletronico == null)
            {
                return HttpNotFound();
            }
            return View(eletronico);
        }

        // POST: eletronicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codigo,aparelho,descricao")] eletronico eletronico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eletronico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eletronico);
        }

        // GET: eletronicos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            eletronico eletronico = db.Eletronico.Find(id);
            if (eletronico == null)
            {
                return HttpNotFound();
            }
            return View(eletronico);
        }

        // POST: eletronicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            eletronico eletronico = db.Eletronico.Find(id);
            db.Eletronico.Remove(eletronico);
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
