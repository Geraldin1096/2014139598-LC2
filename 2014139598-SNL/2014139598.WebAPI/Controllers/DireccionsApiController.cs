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
    public class DireccionsApiController : ApiController
    {
        private LineaNuevaDbContext db = new LineaNuevaDbContext();

        // GET: api/DireccionsApi
        public IQueryable<Direccion> GetDireccions()
        {
            return db.Direccions;
        }

        // GET: api/DireccionsApi/5
        [ResponseType(typeof(Direccion))]
        public IHttpActionResult GetDireccion(int id)
        {
            Direccion direccion = db.Direccions.Find(id);
            if (direccion == null)
            {
                return NotFound();
            }

            return Ok(direccion);
        }

        // PUT: api/DireccionsApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDireccion(int id, Direccion direccion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != direccion.DireccionId)
            {
                return BadRequest();
            }

            db.Entry(direccion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DireccionExists(id))
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

        // POST: api/DireccionsApi
        [ResponseType(typeof(Direccion))]
        public IHttpActionResult PostDireccion(Direccion direccion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Direccions.Add(direccion);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (DireccionExists(direccion.DireccionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = direccion.DireccionId }, direccion);
        }

        // DELETE: api/DireccionsApi/5
        [ResponseType(typeof(Direccion))]
        public IHttpActionResult DeleteDireccion(int id)
        {
            Direccion direccion = db.Direccions.Find(id);
            if (direccion == null)
            {
                return NotFound();
            }

            db.Direccions.Remove(direccion);
            db.SaveChanges();

            return Ok(direccion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DireccionExists(int id)
        {
            return db.Direccions.Count(e => e.DireccionId == id) > 0;
        }
    }
}