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
using _2014139598_ENT.Entities.IRepositories;
using _2014139598_ENT.Entities.EntitiesDTO;
using AutoMapper;

namespace LineaTelefonica.WebAPI.Controllers
{
    public class AdministrarLineasApiController : ApiController
    {
        //private MovieStoreContext db = new MovieStoreContext();
        private readonly IUnityOfWork _UnityOfWork;

        public AdministrarLineasApiController()
        {

        }

        public AdministrarLineasApiController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: api/GenresApi
        //public IQueryable<Genre> GetGenres()
        //{
        //	return db.Genres;
        //}

        // GET api/GenresApi
        [HttpGet]
        public IHttpActionResult Get()
        {
            //La capa de persistencia no debe ser modificada, porque es única para todo canal de atencion de la aplicacion
            //por lo tanto, a nivel de controlador se debe de hacer las modificaciones.
            var AdministrarLineas = _UnityOfWork.AdministrarLineas.GetAll();

            if (AdministrarLineas == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            var AdministrarLineasDTO = new List<AdministrarLineaDTO>();

            foreach (var administrarLinea in AdministrarLineas)
                AdministrarLineasDTO.Add(Mapper.Map<AdministrarLinea, AdministrarLineaDTO>(administrarLinea));

            return Ok(AdministrarLineasDTO);
        }

        // GET: api/GenresApi/5
        //[ResponseType(typeof(Genre))]
        //public IHttpActionResult GetGenre(int id)
        //{
        //	Genre genre = db.Genres.Find(id);
        //	if (genre == null)
        //	{
        //		return NotFound();
        //	}

        //	return Ok(genre);
        //}

        // GET api/<controller>/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var administrarLinea = _UnityOfWork.AdministrarLineas.Get(id);

            if (administrarLinea == null)
                return NotFound();

            return Ok(Mapper.Map<AdministrarLinea, AdministrarLineaDTO>(administrarLinea));
        }

        // PUT: api/GenresApi/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutGenre(int id, Genre genre)
        //{
        //	if (!ModelState.IsValid)
        //	{
        //		return BadRequest(ModelState);
        //	}

        //	if (id != genre.GenreId)
        //	{
        //		return BadRequest();
        //	}

        //	db.Entry(genre).State = EntityState.Modified;

        //	try
        //	{
        //		db.SaveChanges();
        //	}
        //	catch (DbUpdateConcurrencyException)
        //	{
        //		if (!GenreExists(id))
        //		{
        //			return NotFound();
        //		}
        //		else
        //		{
        //			throw;
        //		}
        //	}

        //	return StatusCode(HttpStatusCode.NoContent);
        //}
        [HttpPut]
        public IHttpActionResult Update(int id, AdministrarLineaDTO administrarLineaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var administrarLineaInPersistence = _UnityOfWork.AdministrarLineas.Get(id);
            if (administrarLineaInPersistence == null)
                return NotFound();

            Mapper.Map<AdministrarLineaDTO, AdministrarLinea>(administrarLineaDTO, administrarLineaInPersistence);

            _UnityOfWork.SaveChanges();

            return Ok(administrarLineaDTO);
        }


        // POST: api/GenresApi
        //[ResponseType(typeof(Genre))]
        //public IHttpActionResult PostGenre(Genre genre)
        //{
        //	if (!ModelState.IsValid)
        //	{
        //		return BadRequest(ModelState);
        //	}

        //	db.Genres.Add(genre);
        //	db.SaveChanges();

        //	return CreatedAtRoute("DefaultApi", new { id = genre.GenreId }, genre);
        //}
        [HttpPost]
        public IHttpActionResult Create(AdministrarLineaDTO administrarLineaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var administrarLinea = Mapper.Map<AdministrarLineaDTO, AdministrarLinea>(administrarLineaDTO);

            _UnityOfWork.AdministrarLineas.Add(administrarLinea);
            _UnityOfWork.SaveChanges();

            administrarLineaDTO.AdministrarLineaId = administrarLinea.AdministrarLineaId;

            return Created(new Uri(Request.RequestUri + "/" + administrarLinea.AdministrarLineaId), administrarLineaDTO);
        }

        // DELETE: api/GenresApi/5
        //[ResponseType(typeof(Genre))]
        //public IHttpActionResult DeleteGenre(int id)
        //{
        //	Genre genre = db.Genres.Find(id);
        //	if (genre == null)
        //	{
        //		return NotFound();
        //	}

        //	db.Genres.Remove(genre);
        //	db.SaveChanges();

        //	return Ok(genre);
        //}
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var administrarLineaInDataBase = _UnityOfWork.AdministrarLineas.Get(id);
            if (administrarLineaInDataBase == null)
                return NotFound();

            _UnityOfWork.AdministrarLineas.Delete(administrarLineaInDataBase);
            _UnityOfWork.SaveChanges();

            return Ok();
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