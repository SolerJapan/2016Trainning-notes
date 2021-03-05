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

using prj_CsWebSpa.Models;
using prj_CsWebSpa_02.Models;

namespace prj_CsWebSpa_02.Controllers
{
    [RoutePrefixAttribute("api/books")]
    public class BooksController : ApiController
    {
        // fields
        private tDbcxt m_oDbcxt = new tDbcxt();


        //// GET: api/books
        //[RouteAttribute( "" )]
        //public IQueryable<tBook> GetBooks()
        //{
        //  return this.m_oDbcxt.p_oDbsetOfBook;

        //  // eager loading
        //  //return this.m_oDbcxt.p_oDbsetOfBook.Include( bk => bk.p_oAuthor );
        //}


        //// GET: api/books/5
        //[RouteAttribute( "{id:int}" )]
        //[ResponseTypeAttribute( typeof(tBook) )]
        //public async Task<IHttpActionResult> GetBook( int id )
        //{
        //  tBook oBook = await this.m_oDbcxt.p_oDbsetOfBook.FindAsync( id );

        //  // eager loading
        //  //tBook oBook = await this.m_oDbcxt.p_oDbsetOfBook.Include( bk => bk.p_oAuthor )
        //  //                                                .FirstOrDefaultAsync( bk => bk.p_iBookId == id );

        //  if( oBook == null )
        //  {
        //    return base.NotFound();
        //  }

        //  return base.Ok( oBook );
        //}


        // GET api/books
        [RouteAttribute("")]
        public IQueryable<tDtoBook> GetBooks()
        {
            IQueryable<tDtoBook> oIQrybleOfBook =
                from bk in this.m_oDbcxt.tBooks.Include(bk => bk.p_oAuthor)
                select new tDtoBook()
                {
                    p_iBookId = bk.p_iBookId,
                    p_oStrTitle = bk.p_oStrTitle,
                    p_oStrAuthorName = bk.p_oAuthor.p_oStrName
                };

            return oIQrybleOfBook;
        }


        // GET api/books/5
        [RouteAttribute("{id:int}", Name = "MyGetBook")]
        [ResponseTypeAttribute(typeof(tDtoBookDets))]
        public async Task<IHttpActionResult> GetBook(int id)
        {
            tDtoBookDets oDtoBookDets =
                await this.m_oDbcxt.tBooks
                                   .Include(bk => bk.p_oAuthor)
                                   .Select(bk => new tDtoBookDets()
                                   {
                                       p_iBookId = bk.p_iBookId,
                                       p_oStrTitle = bk.p_oStrTitle,
                                       p_iPubYear = bk.p_iPubYear,
                                       p_dPrice = bk.p_dPrice,
                                       p_oStrAuthorName = bk.p_oAuthor.p_oStrName,
                                       p_oStrGenre = bk.p_oStrGenre
                                   })
                                   .FirstOrDefaultAsync(bk => bk.p_iBookId == id);

            if (oDtoBookDets == null)
            {
                return base.NotFound();
            }

            return base.Ok(oDtoBookDets);
        }


        // PUT: api/books/5
        [RouteAttribute("{id:int}")]
        [ResponseTypeAttribute(typeof(void))]
        public async Task<IHttpActionResult> PutBook(int id, tBook oBook)
        {
            if (!base.ModelState.IsValid)
            {
                return base.BadRequest(base.ModelState);
            }

            if (id != oBook.p_iBookId)
            {
                return base.BadRequest();
            }

            this.m_oDbcxt.Entry(oBook).State = EntityState.Modified;

            try
            {
                await this.m_oDbcxt.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.bBookExists(id))
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


        //// POST: api/books
        //[RouteAttribute( "" )]
        //[ResponseTypeAttribute( typeof(tBook) )]
        //public async Task<IHttpActionResult> PostBook( tBook oBook )
        //{
        //  if( ! base.ModelState.IsValid )
        //  {
        //    return base.BadRequest( base.ModelState );
        //  }

        //  this.m_oDbcxt.p_oDbsetOfBook.Add( oBook );
        //  await this.m_oDbcxt.SaveChangesAsync();

        //  return base.CreatedAtRoute( "DefaultApi", new { id = oBook.p_iBookId }, oBook );
        //}


        // POST: api/books
        [RouteAttribute("")]
        [ResponseTypeAttribute(typeof(tDtoBook))]
        public async Task<IHttpActionResult> PostBook(tBook oBook)
        {
            if (!base.ModelState.IsValid)
            {
                return base.BadRequest(base.ModelState);
            }

            this.m_oDbcxt.tBooks.Add(oBook);
            await this.m_oDbcxt.SaveChangesAsync();

            // explicit load navprop author
            this.m_oDbcxt.Entry(oBook).Reference(bk => bk.p_oAuthor).Load();

            tDtoBook oDtoBook = new tDtoBook()
            {
                p_iBookId = oBook.p_iBookId,
                p_oStrTitle = oBook.p_oStrTitle,
                p_oStrAuthorName = oBook.p_oAuthor.p_oStrName
            };

            bool bHasRoute = this.Configuration.Routes.ContainsKey("MyGetBook");
            string oStrRouteName = (bHasRoute) ? "MyGetBook" : "DefaultApi";
            return base.CreatedAtRoute(oStrRouteName, new { id = oBook.p_iBookId }, oDtoBook);
        }


        // DELETE: api/books/5
        [RouteAttribute("{id:int}")]
        [ResponseTypeAttribute(typeof(tBook))]
        public async Task<IHttpActionResult> DeleteBook(int id)
        {
            tBook oBook = await this.m_oDbcxt.tBooks.FindAsync(id);
            if (oBook == null)
            {
                return base.NotFound();
            }

            this.m_oDbcxt.tBooks.Remove(oBook);
            await this.m_oDbcxt.SaveChangesAsync();

            return base.Ok(oBook);
        }


        private bool bBookExists(int id)
        {
            return this.m_oDbcxt.tBooks.Count(bk => bk.p_iBookId == id) > 0;
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
