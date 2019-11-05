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
    public class PlanillaDeduccionesController : Controller
    {
        private PlanillaEntities db = new PlanillaEntities();

        // GET: PlanillaDeducciones
        public ActionResult Index()
        {
            var tbTipoPlanillaDetalleDeduccion = db.tbTipoPlanillaDetalleDeduccion.Include(t => t.tbCatalogoDeDeducciones).Include(t => t.tbCatalogoDePlanillas);
            return View(tbTipoPlanillaDetalleDeduccion.ToList());
        }

        // GET: PlanillaDeducciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoPlanillaDetalleDeduccion tbTipoPlanillaDetalleDeduccion = db.tbTipoPlanillaDetalleDeduccion.Find(id);
            if (tbTipoPlanillaDetalleDeduccion == null)
            {
                return HttpNotFound();
            }
            return View(tbTipoPlanillaDetalleDeduccion);
        }

        // GET: PlanillaDeducciones/Create
        public ActionResult Create()
        {
            ViewBag.cde_IdDeducciones = new SelectList(db.tbCatalogoDeDeducciones, "cde_IdDeducciones", "cde_DescripcionDeduccion");
            ViewBag.cpla_IdPlanilla = new SelectList(db.tbCatalogoDePlanillas, "cpla_IdPlanilla", "cpla_DescripcionPlanilla");
            return View();
        }

        // POST: PlanillaDeducciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tpdd_IdPlanillaDetDeduccion,cpla_IdPlanilla,cde_IdDeducciones,tpdd_UsuarioCrea,tpdd_FechaCrea,tpdd_UsuarioModifica,tpdd_FechaModifica")] tbTipoPlanillaDetalleDeduccion tbTipoPlanillaDetalleDeduccion)
        {
            if (ModelState.IsValid)
            {
                db.tbTipoPlanillaDetalleDeduccion.Add(tbTipoPlanillaDetalleDeduccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cde_IdDeducciones = new SelectList(db.tbCatalogoDeDeducciones, "cde_IdDeducciones", "cde_DescripcionDeduccion", tbTipoPlanillaDetalleDeduccion.cde_IdDeducciones);
            ViewBag.cpla_IdPlanilla = new SelectList(db.tbCatalogoDePlanillas, "cpla_IdPlanilla", "cpla_DescripcionPlanilla", tbTipoPlanillaDetalleDeduccion.cpla_IdPlanilla);
            return View(tbTipoPlanillaDetalleDeduccion);
        }

        // GET: PlanillaDeducciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoPlanillaDetalleDeduccion tbTipoPlanillaDetalleDeduccion = db.tbTipoPlanillaDetalleDeduccion.Find(id);
            if (tbTipoPlanillaDetalleDeduccion == null)
            {
                return HttpNotFound();
            }
            ViewBag.cde_IdDeducciones = new SelectList(db.tbCatalogoDeDeducciones, "cde_IdDeducciones", "cde_DescripcionDeduccion", tbTipoPlanillaDetalleDeduccion.cde_IdDeducciones);
            ViewBag.cpla_IdPlanilla = new SelectList(db.tbCatalogoDePlanillas, "cpla_IdPlanilla", "cpla_DescripcionPlanilla", tbTipoPlanillaDetalleDeduccion.cpla_IdPlanilla);
            return View(tbTipoPlanillaDetalleDeduccion);
        }

        // POST: PlanillaDeducciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tpdd_IdPlanillaDetDeduccion,cpla_IdPlanilla,cde_IdDeducciones,tpdd_UsuarioCrea,tpdd_FechaCrea,tpdd_UsuarioModifica,tpdd_FechaModifica")] tbTipoPlanillaDetalleDeduccion tbTipoPlanillaDetalleDeduccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbTipoPlanillaDetalleDeduccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cde_IdDeducciones = new SelectList(db.tbCatalogoDeDeducciones, "cde_IdDeducciones", "cde_DescripcionDeduccion", tbTipoPlanillaDetalleDeduccion.cde_IdDeducciones);
            ViewBag.cpla_IdPlanilla = new SelectList(db.tbCatalogoDePlanillas, "cpla_IdPlanilla", "cpla_DescripcionPlanilla", tbTipoPlanillaDetalleDeduccion.cpla_IdPlanilla);
            return View(tbTipoPlanillaDetalleDeduccion);
        }

        // GET: PlanillaDeducciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoPlanillaDetalleDeduccion tbTipoPlanillaDetalleDeduccion = db.tbTipoPlanillaDetalleDeduccion.Find(id);
            if (tbTipoPlanillaDetalleDeduccion == null)
            {
                return HttpNotFound();
            }
            return View(tbTipoPlanillaDetalleDeduccion);
        }

        // POST: PlanillaDeducciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbTipoPlanillaDetalleDeduccion tbTipoPlanillaDetalleDeduccion = db.tbTipoPlanillaDetalleDeduccion.Find(id);
            db.tbTipoPlanillaDetalleDeduccion.Remove(tbTipoPlanillaDetalleDeduccion);
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
