using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using prj_CsWebSpa_prc.Models;

namespace prj_CsWebSpa_prc.Controllers
{
    public class AuthorsController : ApiController
    {
        private tDbcxt db = new tDbcxt();

        // GET: api/Authors
        public IQueryable<tAuthor> GettAuthors()
        {
            return db.p_oDbsetOfAuth;
        }

        // GET: api/Authors/5
        [ResponseType(typeof(tAuthor))]
        public async Task<IHttpActionResult> GettAuthor(int id)
        {
            tAuthor tAuthor = await db.p_oDbsetOfAuth.FindAsync(id);
            if (tAuthor == null)
            {
                return NotFound();
            }

            return Ok(tAuthor);
        }

        // PUT: api/Authors/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PuttAuthor(int id, tAuthor tAuthor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tAuthor.p_iAuthorId)
            {
                return BadRequest();
            }

            db.Entry(tAuthor).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tAuthorExists(id))
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

        // POST: api/Authors
        [ResponseType(typeof(tAuthor))]
        public async Task<IHttpActionResult> PosttAuthor(tAuthor tAuthor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.p_oDbsetOfAuth.Add(tAuthor);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tAuthor.p_iAuthorId }, tAuthor);
        }

        // DELETE: api/Authors/5
        [ResponseType(typeof(tAuthor))]
        public async Task<IHttpActionResult> DeletetAuthor(int id)
        {
            tAuthor tAuthor = await db.p_oDbsetOfAuth.FindAsync(id);
            if (tAuthor == null)
            {
                return NotFound();
            }

            db.p_oDbsetOfAuth.Remove(tAuthor);
            await db.SaveChangesAsync();

            return Ok(tAuthor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tAuthorExists(int id)
        {
            return db.p_oDbsetOfAuth.Count(e => e.p_iAuthorId == id) > 0;
        }
    }
}