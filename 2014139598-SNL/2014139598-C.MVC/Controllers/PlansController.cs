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
    public class PlansController : Controller
    {
        //private LineaTelefonicaCDbContext db = new LineaTelefonicaCDbContext();
        private readonly IUnityOfWork _UnityOfWork;
        public PlansController()
        {

        }

        public PlansController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }


        // GET: Plans
        public ActionResult Index()
        {
            //return View(db.Plans.ToList());
            return View(_UnityOfWork.Plans.GetAll());
        }

        // GET: Plans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = _UnityOfWork.Plans.Get(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            return View(plan);
        }

        // GET: Plans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Plans/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlanId,codigoPlan,topeConsumo,cargoFijo,caracteristicaPlan,TipoPlans")] Plan plan)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Plans.Add(plan);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(plan);
        }

        // GET: Plans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = _UnityOfWork.Plans.Get(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            return View(plan);
        }

        // POST: Plans/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlanId,codigoPlan,topeConsumo,cargoFijo,caracteristicaPlan,TipoPlans")] Plan plan)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(plan).State = EntityState.Modified;
                _UnityOfWork.StateModified(plan);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(plan);
        }

        // GET: Plans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = _UnityOfWork.Plans.Get(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            return View(plan);
        }

        // POST: Plans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Plan plan = _UnityOfWork.Plans.Get(id);
            // db.Plans.Remove(plan);
            _UnityOfWork.Plans.Delete(plan);
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
