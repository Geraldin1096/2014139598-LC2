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
    public class EvaluacionsController : Controller
    {
       // private LineaTelefonicaCDbContext db = new LineaTelefonicaCDbContext();
        private readonly IUnityOfWork _UnityOfWork;
        public EvaluacionsController()
        {

        }

        public EvaluacionsController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: Evaluacions
        public ActionResult Index()
        {
            //return View(db.Evaluacions.ToList());
            return View(_UnityOfWork.Evaluacions.GetAll());
        }

        // GET: Evaluacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = _UnityOfWork.Evaluacions.Get(id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            return View(evaluacion);
        }

        // GET: Evaluacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluacions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EvaluacionId,numeroEvaluacion,documento,fechaEvaluacion,EstadoEvaluacion,TipoEvaluacion")] Evaluacion evaluacion)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Evaluacions.Add(evaluacion);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(evaluacion);
        }

        // GET: Evaluacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = _UnityOfWork.Evaluacions.Get(id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            return View(evaluacion);
        }

        // POST: Evaluacions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EvaluacionId,numeroEvaluacion,documento,fechaEvaluacion,EstadoEvaluacion,TipoEvaluacion")] Evaluacion evaluacion)
        {
            if (ModelState.IsValid)
            {
                // db.Entry(evaluacion).State = EntityState.Modified;
                _UnityOfWork.StateModified(evaluacion);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evaluacion);
        }

        // GET: Evaluacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = _UnityOfWork.Evaluacions.Get(id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            return View(evaluacion);
        }

        // POST: Evaluacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evaluacion evaluacion = _UnityOfWork.Evaluacions.Get(id);
            //db.Evaluacions.Remove(evaluacion);
            _UnityOfWork.Evaluacions.Delete(evaluacion);
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
