using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2014139598_PER_Persistence;
using _2014139598_ENT.Entities.IRepositories;
using _2014139598_ENT.Entities;

namespace _2014139598C.MVC.Controllers
{
    public class EquipoCelularsController : Controller
    {
      //  private LineaTelefonicaCDbContext db = new LineaTelefonicaCDbContext();
        private readonly IUnityOfWork _UnityOfWork;
        public EquipoCelularsController()
        {

        }

        public EquipoCelularsController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }


        // GET: EquipoCelulars
        public ActionResult Index()
        {
            //return View(db.EquipoCelulars.ToList());
            return View(_UnityOfWork.EquipoCelulars.GetAll());
        }

        // GET: EquipoCelulars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = _UnityOfWork.EquipoCelulars.Get(id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            return View(equipoCelular);
        }

        // GET: EquipoCelulars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipoCelulars/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EquipoCelularId,marcaEquipo,modeloEquipo,colorEquipo,imei,precio")] EquipoCelular equipoCelular)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.EquipoCelulars.Add(equipoCelular);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipoCelular);
        }

        // GET: EquipoCelulars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = _UnityOfWork.EquipoCelulars.Get(id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            return View(equipoCelular);
        }

        // POST: EquipoCelulars/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EquipoCelularId,marcaEquipo,modeloEquipo,colorEquipo,imei,precio")] EquipoCelular equipoCelular)
        {
            if (ModelState.IsValid)
            {
                // db.Entry(equipoCelular).State = EntityState.Modified;
                _UnityOfWork.StateModified(equipoCelular);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipoCelular);
        }

        // GET: EquipoCelulars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = _UnityOfWork.EquipoCelulars.Get (id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            return View(equipoCelular);
        }

        // POST: EquipoCelulars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EquipoCelular equipoCelular = _UnityOfWork.EquipoCelulars.Get(id);
            // db.EquipoCelulars.Remove(equipoCelular);
            _UnityOfWork.EquipoCelulars.Delete(equipoCelular);
            _UnityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _UnityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
