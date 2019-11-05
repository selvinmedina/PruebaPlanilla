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
    public class CatalogoDeDeduccionesController : Controller
    {
        private PlanillaEntities db = new PlanillaEntities();

        // GET: CatalogoDeDeducciones
        public ActionResult Index()
        {
            var tbCatalogoDeDeducciones = db.tbCatalogoDeDeducciones.Include(t => t.tbTipoDeduccion);
            return View(tbCatalogoDeDeducciones.ToList());
        }

        // GET: CatalogoDeDeducciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCatalogoDeDeducciones tbCatalogoDeDeducciones = db.tbCatalogoDeDeducciones.Find(id);
            if (tbCatalogoDeDeducciones == null)
            {
                return HttpNotFound();
            }
            return View(tbCatalogoDeDeducciones);
        }

        // GET: CatalogoDeDeducciones/Create
        public ActionResult Create()
        {
            ViewBag.tde_IdTipoDedu = new SelectList(db.tbTipoDeduccion, "tde_IdTipoDedu", "tde_Descripcion");
            return View();
        }

        // POST: CatalogoDeDeducciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cde_IdDeducciones,cde_DescripcionDeduccion,tde_IdTipoDedu,cde_PorcentajeColaborador,cde_PorcentajeEmpresa,cde_UsuarioCrea,cde_FechaCrea,cde_UsuarioModifica,cde_FechaModifica")] tbCatalogoDeDeducciones tbCatalogoDeDeducciones)
        {
            if (ModelState.IsValid)
            {
                db.tbCatalogoDeDeducciones.Add(tbCatalogoDeDeducciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.tde_IdTipoDedu = new SelectList(db.tbTipoDeduccion, "tde_IdTipoDedu", "tde_Descripcion", tbCatalogoDeDeducciones.tde_IdTipoDedu);
            return View(tbCatalogoDeDeducciones);
        }

        // GET: CatalogoDeDeducciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCatalogoDeDeducciones tbCatalogoDeDeducciones = db.tbCatalogoDeDeducciones.Find(id);
            if (tbCatalogoDeDeducciones == null)
            {
                return HttpNotFound();
            }
            ViewBag.tde_IdTipoDedu = new SelectList(db.tbTipoDeduccion, "tde_IdTipoDedu", "tde_Descripcion", tbCatalogoDeDeducciones.tde_IdTipoDedu);
            return View(tbCatalogoDeDeducciones);
        }

        // POST: CatalogoDeDeducciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cde_IdDeducciones,cde_DescripcionDeduccion,tde_IdTipoDedu,cde_PorcentajeColaborador,cde_PorcentajeEmpresa,cde_UsuarioCrea,cde_FechaCrea,cde_UsuarioModifica,cde_FechaModifica")] tbCatalogoDeDeducciones tbCatalogoDeDeducciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbCatalogoDeDeducciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.tde_IdTipoDedu = new SelectList(db.tbTipoDeduccion, "tde_IdTipoDedu", "tde_Descripcion", tbCatalogoDeDeducciones.tde_IdTipoDedu);
            return View(tbCatalogoDeDeducciones);
        }

        // GET: CatalogoDeDeducciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCatalogoDeDeducciones tbCatalogoDeDeducciones = db.tbCatalogoDeDeducciones.Find(id);
            if (tbCatalogoDeDeducciones == null)
            {
                return HttpNotFound();
            }
            return View(tbCatalogoDeDeducciones);
        }

        // POST: CatalogoDeDeducciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbCatalogoDeDeducciones tbCatalogoDeDeducciones = db.tbCatalogoDeDeducciones.Find(id);
            db.tbCatalogoDeDeducciones.Remove(tbCatalogoDeDeducciones);
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
