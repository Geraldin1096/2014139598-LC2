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
    public class EquipoCelularsApiController : ApiController
    {
        private LineaNuevaDbContext db = new LineaNuevaDbContext();

        // GET: api/EquipoCelularsApi
        public IQueryable<EquipoCelular> GetEquipoCelulars()
        {
            return db.EquipoCelulars;
        }

        // GET: api/EquipoCelularsApi/5
        [ResponseType(typeof(EquipoCelular))]
        public IHttpActionResult GetEquipoCelular(int id)
        {
            EquipoCelular equipoCelular = db.EquipoCelulars.Find(id);
            if (equipoCelular == null)
            {
                return NotFound();
            }

            return Ok(equipoCelular);
        }

        // PUT: api/EquipoCelularsApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEquipoCelular(int id, EquipoCelular equipoCelular)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != equipoCelular.EquipoCelularId)
            {
                return BadRequest();
            }

            db.Entry(equipoCelular).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipoCelularExists(id))
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

        // POST: api/EquipoCelularsApi
        [ResponseType(typeof(EquipoCelular))]
        public IHttpActionResult PostEquipoCelular(EquipoCelular equipoCelular)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EquipoCelulars.Add(equipoCelular);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = equipoCelular.EquipoCelularId }, equipoCelular);
        }

        // DELETE: api/EquipoCelularsApi/5
        [ResponseType(typeof(EquipoCelular))]
        public IHttpActionResult DeleteEquipoCelular(int id)
        {
            EquipoCelular equipoCelular = db.EquipoCelulars.Find(id);
            if (equipoCelular == null)
            {
                return NotFound();
            }

            db.EquipoCelulars.Remove(equipoCelular);
            db.SaveChanges();

            return Ok(equipoCelular);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EquipoCelularExists(int id)
        {
            return db.EquipoCelulars.Count(e => e.EquipoCelularId == id) > 0;
        }
    }
}