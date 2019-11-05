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
    public class PlanillaIngresosController : Controller
    {
        private PlanillaEntities db = new PlanillaEntities();

        // GET: PlanillaIngresos
        public ActionResult Index()
        {
            var tbTipoPlanillaDetalleIngreso = db.tbTipoPlanillaDetalleIngreso.Include(t => t.tbCatalogoDeIngresos).Include(t => t.tbCatalogoDePlanillas);
            return View(tbTipoPlanillaDetalleIngreso.ToList());
        }

        // GET: PlanillaIngresos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoPlanillaDetalleIngreso tbTipoPlanillaDetalleIngreso = db.tbTipoPlanillaDetalleIngreso.Find(id);
            if (tbTipoPlanillaDetalleIngreso == null)
            {
                return HttpNotFound();
            }
            return View(tbTipoPlanillaDetalleIngreso);
        }

        // GET: PlanillaIngresos/Create
        public ActionResult Create()
        {
            ViewBag.cin_IdIngreso = new SelectList(db.tbCatalogoDeIngresos, "cin_IdIngreso", "cin_DescripcionIngreso");
            ViewBag.cpla_IdPlanilla = new SelectList(db.tbCatalogoDePlanillas, "cpla_IdPlanilla", "cpla_DescripcionPlanilla");
            return View();
        }

        // POST: PlanillaIngresos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tpdi_IdDetallePlanillaIngreso,cin_IdIngreso,cpla_IdPlanilla,tpdi_UsuarioCrea,tpdi_FechaCrea,tpdi_UsuarioModifica,tpdi_FechaModifica")] tbTipoPlanillaDetalleIngreso tbTipoPlanillaDetalleIngreso)
        {
            if (ModelState.IsValid)
            {
                db.tbTipoPlanillaDetalleIngreso.Add(tbTipoPlanillaDetalleIngreso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cin_IdIngreso = new SelectList(db.tbCatalogoDeIngresos, "cin_IdIngreso", "cin_DescripcionIngreso", tbTipoPlanillaDetalleIngreso.cin_IdIngreso);
            ViewBag.cpla_IdPlanilla = new SelectList(db.tbCatalogoDePlanillas, "cpla_IdPlanilla", "cpla_DescripcionPlanilla", tbTipoPlanillaDetalleIngreso.cpla_IdPlanilla);
            return View(tbTipoPlanillaDetalleIngreso);
        }

        // GET: PlanillaIngresos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoPlanillaDetalleIngreso tbTipoPlanillaDetalleIngreso = db.tbTipoPlanillaDetalleIngreso.Find(id);
            if (tbTipoPlanillaDetalleIngreso == null)
            {
                return HttpNotFound();
            }
            ViewBag.cin_IdIngreso = new SelectList(db.tbCatalogoDeIngresos, "cin_IdIngreso", "cin_DescripcionIngreso", tbTipoPlanillaDetalleIngreso.cin_IdIngreso);
            ViewBag.cpla_IdPlanilla = new SelectList(db.tbCatalogoDePlanillas, "cpla_IdPlanilla", "cpla_DescripcionPlanilla", tbTipoPlanillaDetalleIngreso.cpla_IdPlanilla);
            return View(tbTipoPlanillaDetalleIngreso);
        }

        // POST: PlanillaIngresos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tpdi_IdDetallePlanillaIngreso,cin_IdIngreso,cpla_IdPlanilla,tpdi_UsuarioCrea,tpdi_FechaCrea,tpdi_UsuarioModifica,tpdi_FechaModifica")] tbTipoPlanillaDetalleIngreso tbTipoPlanillaDetalleIngreso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbTipoPlanillaDetalleIngreso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cin_IdIngreso = new SelectList(db.tbCatalogoDeIngresos, "cin_IdIngreso", "cin_DescripcionIngreso", tbTipoPlanillaDetalleIngreso.cin_IdIngreso);
            ViewBag.cpla_IdPlanilla = new SelectList(db.tbCatalogoDePlanillas, "cpla_IdPlanilla", "cpla_DescripcionPlanilla", tbTipoPlanillaDetalleIngreso.cpla_IdPlanilla);
            return View(tbTipoPlanillaDetalleIngreso);
        }

        // GET: PlanillaIngresos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoPlanillaDetalleIngreso tbTipoPlanillaDetalleIngreso = db.tbTipoPlanillaDetalleIngreso.Find(id);
            if (tbTipoPlanillaDetalleIngreso == null)
            {
                return HttpNotFound();
            }
            return View(tbTipoPlanillaDetalleIngreso);
        }

        // POST: PlanillaIngresos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbTipoPlanillaDetalleIngreso tbTipoPlanillaDetalleIngreso = db.tbTipoPlanillaDetalleIngreso.Find(id);
            db.tbTipoPlanillaDetalleIngreso.Remove(tbTipoPlanillaDetalleIngreso);
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
