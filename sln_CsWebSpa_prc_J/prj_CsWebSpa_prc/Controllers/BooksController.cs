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
    public class BooksController : ApiController
    {
        private tDbcxt db = new tDbcxt();

        // GET: api/Books
        public IQueryable<tDtoBook> GetBooks()
        {
            IQueryable<tDtoBook> oIQrybleOfBook =
                from bk in this.m_oDbcxt.p_oDbsetOfBook.Include(bk => bk.p_oAuthor)
                select new tDtoBook()
                {
                    p_iBookId = bk.p_iBookId,
                    p_oStrTitle = bk.p_oStrTitle,
                    p_oStrAuthorName = bk.p_oAuthor.p_oStrName
                };

            return oIQrybleOfBook;
        }

        // GET: api/Books/5
        [ResponseType(typeof(tBook))]
        public async Task<IHttpActionResult> GettBook(int id)
        {
            tBook tBook = await db.p_oDbsetOfBook.FindAsync(id);
            if (tBook == null)
            {
                return NotFound();
            }

            return Ok(tBook);
        }

        // PUT: api/Books/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PuttBook(int id, tBook tBook)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tBook.p_iBookId)
            {
                return BadRequest();
            }

            db.Entry(tBook).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tBookExists(id))
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

        // POST: api/Books
        [ResponseType(typeof(tBook))]
        public async Task<IHttpActionResult> PosttBook(tBook tBook)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.p_oDbsetOfBook.Add(tBook);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tBook.p_iBookId }, tBook);
        }

        // DELETE: api/Books/5
        [ResponseType(typeof(tBook))]
        public async Task<IHttpActionResult> DeletetBook(int id)
        {
            tBook tBook = await db.p_oDbsetOfBook.FindAsync(id);
            if (tBook == null)
            {
                return NotFound();
            }

            db.p_oDbsetOfBook.Remove(tBook);
            await db.SaveChangesAsync();

            return Ok(tBook);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tBookExists(int id)
        {
            return db.p_oDbsetOfBook.Count(e => e.p_iBookId == id) > 0;
        }
    }
}