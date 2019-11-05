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
    public class SueldosController : Controller
    {
        private PlanillaEntities db = new PlanillaEntities();

        // GET: Sueldos
        public ActionResult Index()
        {
            var tbSueldos = db.tbSueldos.Include(t => t.tbEmpleados);
            return View(tbSueldos.ToList());
        }

        // GET: Sueldos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbSueldos tbSueldos = db.tbSueldos.Find(id);
            if (tbSueldos == null)
            {
                return HttpNotFound();
            }
            return View(tbSueldos);
        }

        // GET: Sueldos/Create
        public ActionResult Create()
        {
            ViewBag.emp_Id = new SelectList(db.tbEmpleados, "emp_Id", "emp_Razoninactivacion");
            return View();
        }

        // POST: Sueldos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "hsue_Id,emp_Id,tmon_Id,hsue_Cantidad,hsue_SueldoAnterior,hsue_UsuarioCrea,hsue_FechaCrea,hsue_UsuarioModifica,hsue_FechaModifica")] tbSueldos tbSueldos)
        {
            if (ModelState.IsValid)
            {
                db.tbSueldos.Add(tbSueldos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.emp_Id = new SelectList(db.tbEmpleados, "emp_Id", "emp_Razoninactivacion", tbSueldos.emp_Id);
            return View(tbSueldos);
        }

        // GET: Sueldos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbSueldos tbSueldos = db.tbSueldos.Find(id);
            if (tbSueldos == null)
            {
                return HttpNotFound();
            }
            ViewBag.emp_Id = new SelectList(db.tbEmpleados, "emp_Id", "emp_Razoninactivacion", tbSueldos.emp_Id);
            return View(tbSueldos);
        }

        // POST: Sueldos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "hsue_Id,emp_Id,tmon_Id,hsue_Cantidad,hsue_SueldoAnterior,hsue_UsuarioCrea,hsue_FechaCrea,hsue_UsuarioModifica,hsue_FechaModifica")] tbSueldos tbSueldos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbSueldos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.emp_Id = new SelectList(db.tbEmpleados, "emp_Id", "emp_Razoninactivacion", tbSueldos.emp_Id);
            return View(tbSueldos);
        }

        // GET: Sueldos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbSueldos tbSueldos = db.tbSueldos.Find(id);
            if (tbSueldos == null)
            {
                return HttpNotFound();
            }
            return View(tbSueldos);
        }

        // POST: Sueldos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbSueldos tbSueldos = db.tbSueldos.Find(id);
            db.tbSueldos.Remove(tbSueldos);
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
