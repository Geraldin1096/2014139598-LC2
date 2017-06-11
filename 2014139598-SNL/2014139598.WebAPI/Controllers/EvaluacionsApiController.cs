using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using _2014139598_ENT.Entities;
using _2014139598_PER_Persistence;

namespace LineaTelefonica.WebAPI.Controllers
{
    public class EvaluacionsApiController : ApiController
    {
        private LineaNuevaDbContext db = new LineaNuevaDbContext();

        // GET: api/EvaluacionsApi
        public IQueryable<Evaluacion> GetEvaluacions()
        {
            return db.Evaluacions;
        }

        // GET: api/EvaluacionsApi/5
        [ResponseType(typeof(Evaluacion))]
        public IHttpActionResult GetEvaluacion(int id)
        {
            Evaluacion evaluacion = db.Evaluacions.Find(id);
            if (evaluacion == null)
            {
                return NotFound();
            }

            return Ok(evaluacion);
        }

        // PUT: api/EvaluacionsApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEvaluacion(int id, Evaluacion evaluacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != evaluacion.EvaluacionId)
            {
                return BadRequest();
            }

            db.Entry(evaluacion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EvaluacionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/EvaluacionsApi
        [ResponseType(typeof(Evaluacion))]
        public IHttpActionResult PostEvaluacion(Evaluacion evaluacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Evaluacions.Add(evaluacion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = evaluacion.EvaluacionId }, evaluacion);
        }

        // DELETE: api/EvaluacionsApi/5
        [ResponseType(typeof(Evaluacion))]
        public IHttpActionResult DeleteEvaluacion(int id)
        {
            Evaluacion evaluacion = db.Evaluacions.Find(id);
            if (evaluacion == null)
            {
                return NotFound();
            }

            db.Evaluacions.Remove(evaluacion);
            db.SaveChanges();

            return Ok(evaluacion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EvaluacionExists(int id)
        {
            return db.Evaluacions.Count(e => e.EvaluacionId == id) > 0;
        }
    }
}