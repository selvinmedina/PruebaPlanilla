using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PruebaPlanilla.Models;

namespace PruebaPlanilla.Controllers
{
    public class CatalogoDeIngresosController : Controller
    {
        private PlanillaEntities db = new PlanillaEntities();

        // GET: CatalogoDeIngresos
        public ActionResult Index()
        {
            return View(db.tbCatalogoDeIngresos.ToList());
        }

        // GET: CatalogoDeIngresos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCatalogoDeIngresos tbCatalogoDeIngresos = db.tbCatalogoDeIngresos.Find(id);
            if (tbCatalogoDeIngresos == null)
            {
                return HttpNotFound();
            }
            return View(tbCatalogoDeIngresos);
        }

        // GET: CatalogoDeIngresos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CatalogoDeIngresos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cin_IdIngreso,cin_DescripcionIngreso,cin_UsuarioCrea,cin_FechaCrea,cin_UsuarioModifica,cin_FechaModifica")] tbCatalogoDeIngresos tbCatalogoDeIngresos)
        {
            if (ModelState.IsValid)
            {
                db.tbCatalogoDeIngresos.Add(tbCatalogoDeIngresos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbCatalogoDeIngresos);
        }

        // GET: CatalogoDeIngresos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCatalogoDeIngresos tbCatalogoDeIngresos = db.tbCatalogoDeIngresos.Find(id);
            if (tbCatalogoDeIngresos == null)
            {
                return HttpNotFound();
            }
            return View(tbCatalogoDeIngresos);
        }

        // POST: CatalogoDeIngresos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cin_IdIngreso,cin_DescripcionIngreso,cin_UsuarioCrea,cin_FechaCrea,cin_UsuarioModifica,cin_FechaModifica")] tbCatalogoDeIngresos tbCatalogoDeIngresos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbCatalogoDeIngresos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbCatalogoDeIngresos);
        }

        // GET: CatalogoDeIngresos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCatalogoDeIngresos tbCatalogoDeIngresos = db.tbCatalogoDeIngresos.Find(id);
            if (tbCatalogoDeIngresos == null)
            {
                return HttpNotFound();
            }
            return View(tbCatalogoDeIngresos);
        }

        // POST: CatalogoDeIngresos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbCatalogoDeIngresos tbCatalogoDeIngresos = db.tbCatalogoDeIngresos.Find(id);
            db.tbCatalogoDeIngresos.Remove(tbCatalogoDeIngresos);
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
