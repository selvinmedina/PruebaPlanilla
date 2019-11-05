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
    public class TipoDeduccionController : Controller
    {
        private PlanillaEntities db = new PlanillaEntities();

        // GET: TipoDeduccion
        public ActionResult Index()
        {
            return View(db.tbTipoDeduccion.ToList());
        }

        // GET: TipoDeduccion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoDeduccion tbTipoDeduccion = db.tbTipoDeduccion.Find(id);
            if (tbTipoDeduccion == null)
            {
                return HttpNotFound();
            }
            return View(tbTipoDeduccion);
        }

        // GET: TipoDeduccion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDeduccion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tde_IdTipoDedu,tde_Descripcion,tde_UsuarioCrea,tde_FechaCrea,tde_UsuarioModifica,tde_FechaModifica")] tbTipoDeduccion tbTipoDeduccion)
        {
            if (ModelState.IsValid)
            {
                db.tbTipoDeduccion.Add(tbTipoDeduccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbTipoDeduccion);
        }

        // GET: TipoDeduccion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoDeduccion tbTipoDeduccion = db.tbTipoDeduccion.Find(id);
            if (tbTipoDeduccion == null)
            {
                return HttpNotFound();
            }
            return View(tbTipoDeduccion);
        }

        // POST: TipoDeduccion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tde_IdTipoDedu,tde_Descripcion,tde_UsuarioCrea,tde_FechaCrea,tde_UsuarioModifica,tde_FechaModifica")] tbTipoDeduccion tbTipoDeduccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbTipoDeduccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbTipoDeduccion);
        }

        // GET: TipoDeduccion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoDeduccion tbTipoDeduccion = db.tbTipoDeduccion.Find(id);
            if (tbTipoDeduccion == null)
            {
                return HttpNotFound();
            }
            return View(tbTipoDeduccion);
        }

        // POST: TipoDeduccion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbTipoDeduccion tbTipoDeduccion = db.tbTipoDeduccion.Find(id);
            db.tbTipoDeduccion.Remove(tbTipoDeduccion);
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
