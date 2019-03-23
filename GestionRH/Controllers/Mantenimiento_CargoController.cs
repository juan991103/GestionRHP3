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
    public class Mantenimiento_CargoController : Controller
    {
        private MaitenanceModuleContainer db = new MaitenanceModuleContainer();

        // GET: Mantenimiento_Cargo
        public ActionResult Index()
        {
            return View(db.Mantenimiento_CargoSet.ToList());
        }

        // GET: Mantenimiento_Cargo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mantenimiento_Cargo mantenimiento_Cargo = db.Mantenimiento_CargoSet.Find(id);
            if (mantenimiento_Cargo == null)
            {
                return HttpNotFound();
            }
            return View(mantenimiento_Cargo);
        }

        // GET: Mantenimiento_Cargo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mantenimiento_Cargo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo_Cargo,Nombre_Cargo")] Mantenimiento_Cargo mantenimiento_Cargo)
        {
            if (ModelState.IsValid)
            {
                db.Mantenimiento_CargoSet.Add(mantenimiento_Cargo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mantenimiento_Cargo);
        }

        // GET: Mantenimiento_Cargo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mantenimiento_Cargo mantenimiento_Cargo = db.Mantenimiento_CargoSet.Find(id);
            if (mantenimiento_Cargo == null)
            {
                return HttpNotFound();
            }
            return View(mantenimiento_Cargo);
        }

        // POST: Mantenimiento_Cargo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo_Cargo,Nombre_Cargo")] Mantenimiento_Cargo mantenimiento_Cargo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mantenimiento_Cargo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mantenimiento_Cargo);
        }

        // GET: Mantenimiento_Cargo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mantenimiento_Cargo mantenimiento_Cargo = db.Mantenimiento_CargoSet.Find(id);
            if (mantenimiento_Cargo == null)
            {
                return HttpNotFound();
            }
            return View(mantenimiento_Cargo);
        }

        // POST: Mantenimiento_Cargo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mantenimiento_Cargo mantenimiento_Cargo = db.Mantenimiento_CargoSet.Find(id);
            db.Mantenimiento_CargoSet.Remove(mantenimiento_Cargo);
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
