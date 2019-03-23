using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GestionRH.Models;

namespace GestionRH.Controllers
{
    public class Mantenimiento_DepartamentoController : Controller
    {
        private MaitenanceModuleContainer db = new MaitenanceModuleContainer();

        // GET: Mantenimiento_Departamento
        public ActionResult Index()
        {
            return View(db.Mantenimiento_DepartamentoSet.ToList());
        }

        // GET: Mantenimiento_Departamento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mantenimiento_Departamento mantenimiento_Departamento = db.Mantenimiento_DepartamentoSet.Find(id);
            if (mantenimiento_Departamento == null)
            {
                return HttpNotFound();
            }
            return View(mantenimiento_Departamento);
        }

        // GET: Mantenimiento_Departamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mantenimiento_Departamento/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo_Departamento,Nombre")] Mantenimiento_Departamento mantenimiento_Departamento)
        {
            if (ModelState.IsValid)
            {
                db.Mantenimiento_DepartamentoSet.Add(mantenimiento_Departamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mantenimiento_Departamento);
        }

        // GET: Mantenimiento_Departamento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mantenimiento_Departamento mantenimiento_Departamento = db.Mantenimiento_DepartamentoSet.Find(id);
            if (mantenimiento_Departamento == null)
            {
                return HttpNotFound();
            }
            return View(mantenimiento_Departamento);
        }

        // POST: Mantenimiento_Departamento/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo_Departamento,Nombre")] Mantenimiento_Departamento mantenimiento_Departamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mantenimiento_Departamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mantenimiento_Departamento);
        }

        // GET: Mantenimiento_Departamento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mantenimiento_Departamento mantenimiento_Departamento = db.Mantenimiento_DepartamentoSet.Find(id);
            if (mantenimiento_Departamento == null)
            {
                return HttpNotFound();
            }
            return View(mantenimiento_Departamento);
        }

        // POST: Mantenimiento_Departamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mantenimiento_Departamento mantenimiento_Departamento = db.Mantenimiento_DepartamentoSet.Find(id);
            db.Mantenimiento_DepartamentoSet.Remove(mantenimiento_Departamento);
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
