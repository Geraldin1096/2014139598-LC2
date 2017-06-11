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
    public class ContratosController : Controller
    {
        // private LineaTelefonicaCDbContext db = new LineaTelefonicaCDbContext();
        private readonly IUnityOfWork _UnityOfWork;
        public ContratosController()
        {

        }

        public ContratosController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: Contratos
        public ActionResult Index()
        {
            //return View(db.Contratos.ToList());
            return View(_UnityOfWork.Contratos.GetAll());
        }

        // GET: Contratos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contrato contrato = _UnityOfWork.Contratos.Get(id);
            if (contrato == null)
            {
                return HttpNotFound();
            }
            return View(contrato);
        }

        // GET: Contratos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contratos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContratoId,numeroContrato,plazoContrato,formaContrato")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Contratos.Add(contrato);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contrato);
        }

        // GET: Contratos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contrato contrato = _UnityOfWork.Contratos.Get(id);
            if (contrato == null)
            {
                return HttpNotFound();
            }
            return View(contrato);
        }

        // POST: Contratos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContratoId,numeroContrato,plazoContrato,formaContrato")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(contrato).State = EntityState.Modified;
                _UnityOfWork.StateModified(contrato);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contrato);
        }

        // GET: Contratos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contrato contrato = _UnityOfWork.Contratos.Get(id);
            if (contrato == null)
            {
                return HttpNotFound();
            }
            return View(contrato);
        }

        // POST: Contratos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contrato contrato = _UnityOfWork.Contratos.Get(id);
            //db.Contratos.Remove(contrato);
            _UnityOfWork.Contratos.Delete(contrato);
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
