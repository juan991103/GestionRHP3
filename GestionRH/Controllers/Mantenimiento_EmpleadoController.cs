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
    public class Mantenimiento_EmpleadoController : Controller
    {
        private MaitenanceModuleContainer db = new MaitenanceModuleContainer();

        // GET: Mantenimiento_Empleado
        public ActionResult Index()
        {
            return View(db.Mantenimiento_EmpleadoSet.ToList());
        }

        // GET: Mantenimiento_Empleado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mantenimiento_Empleado mantenimiento_Empleado = db.Mantenimiento_EmpleadoSet.Find(id);
            if (mantenimiento_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(mantenimiento_Empleado);
        }

        // GET: Mantenimiento_Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mantenimiento_Empleado/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo_empleado,Nombre,Apellido,Telefono,Departamento,Fecha_Ingreso,Salario,Estatus,Cargo")] Mantenimiento_Empleado mantenimiento_Empleado)
        {
            if (ModelState.IsValid)
            {
                db.Mantenimiento_EmpleadoSet.Add(mantenimiento_Empleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mantenimiento_Empleado);
        }

        // GET: Mantenimiento_Empleado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mantenimiento_Empleado mantenimiento_Empleado = db.Mantenimiento_EmpleadoSet.Find(id);
            if (mantenimiento_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(mantenimiento_Empleado);
        }

        // POST: Mantenimiento_Empleado/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo_empleado,Nombre,Apellido,Telefono,Departamento,Fecha_Ingreso,Salario,Estatus,Cargo")] Mantenimiento_Empleado mantenimiento_Empleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mantenimiento_Empleado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mantenimiento_Empleado);
        }

        // GET: Mantenimiento_Empleado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mantenimiento_Empleado mantenimiento_Empleado = db.Mantenimiento_EmpleadoSet.Find(id);
            if (mantenimiento_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(mantenimiento_Empleado);
        }

        // POST: Mantenimiento_Empleado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mantenimiento_Empleado mantenimiento_Empleado = db.Mantenimiento_EmpleadoSet.Find(id);
            db.Mantenimiento_EmpleadoSet.Remove(mantenimiento_Empleado);
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
