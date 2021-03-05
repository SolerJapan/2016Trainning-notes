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

using prj_CsWebSpa_02.Models;


namespace prj_CsWebSpa_02.Controllers
{
    [RoutePrefixAttribute("api/authors")]
    public class AuthorsController : ApiController
    {
        // fields
        private tDbcxt m_oDbcxt = new tDbcxt();


        // GET: api/authors
        [RouteAttribute("")]
        public IQueryable<tAuthor> GetAuthors()
        {
            return this.m_oDbcxt.tAuthors;
        }


        // GET: api/authors/5
        [RouteAttribute("{id:int}")]
        [ResponseTypeAttribute(typeof(tAuthor))]
        public async Task<IHttpActionResult> GetAuthor(int id)
        {
            tAuthor oAuthor = await this.m_oDbcxt.tAuthors.FindAsync(id);
            if (oAuthor == null)
            {
                return base.NotFound();
            }

            return base.Ok(oAuthor);
        }


        // PUT: api/authors/5
        [RouteAttribute("{id:int}")]
        [ResponseTypeAttribute(typeof(void))]
        public async Task<IHttpActionResult> PutAuthor(int id, tAuthor oAuthor)
        {
            if (!base.ModelState.IsValid)
            {
                return base.BadRequest(base.ModelState);
            }

            if (id != oAuthor.p_iAuthorId)
            {
                return base.BadRequest();
            }

            this.m_oDbcxt.Entry(oAuthor).State = EntityState.Modified;

            try
            {
                await this.m_oDbcxt.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.bAuthorExists(id))
                {
                    return base.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return base.StatusCode(HttpStatusCode.NoContent);
        }


        // POST: api/authors
        [RouteAttribute("")]
        [ResponseTypeAttribute(typeof(tAuthor))]
        public async Task<IHttpActionResult> PostAuthor(tAuthor oAuthor)
        {
            if (!base.ModelState.IsValid)
            {
                return base.BadRequest(base.ModelState);
            }

            this.m_oDbcxt.tAuthors.Add(oAuthor);
            await this.m_oDbcxt.SaveChangesAsync();

            return base.CreatedAtRoute("DefaultApi", new { id = oAuthor.p_iAuthorId }, oAuthor);
        }


        // DELETE: api/authors/5
        [RouteAttribute("{id:int}")]
        [ResponseTypeAttribute(typeof(tAuthor))]
        public async Task<IHttpActionResult> DeleteAuthor(int id)
        {
            tAuthor oAuthor = await this.m_oDbcxt.tAuthors.FindAsync(id);
            if (oAuthor == null)
            {
                return base.NotFound();
            }

            this.m_oDbcxt.tAuthors.Remove(oAuthor);
            await this.m_oDbcxt.SaveChangesAsync();

            return base.Ok(oAuthor);
        }


        private bool bAuthorExists(int id)
        {
            return this.m_oDbcxt.tAuthors.Count(auth => auth.p_iAuthorId == id) > 0;
        }


        protected override void Dispose(bool bDisposing)
        {
            if (bDisposing)
            {
                if (this.m_oDbcxt != null)
                {
                    this.m_oDbcxt.Dispose();
                    this.m_oDbcxt = null;
                }
            }
            base.Dispose(bDisposing);
        }


    } // class

} // ns
