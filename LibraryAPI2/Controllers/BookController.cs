using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using LibraryAPI2.Context;

namespace LibraryAPI2.Controllers
{
    public class BookController : ApiController
    {

        [HttpGet, Route("API/BookSearch")]
        public IHttpActionResult GetBook([FromUri]string title = null, [FromUri] string author = null, [FromUri] string genre = null)
        {
            using (var db = new LibraryContext())
            {
                var query = db.Books.Include(i => i.Author).Include(i => i.Genre);


                if (!String.IsNullOrEmpty(title))
                {
                    query = query.Where(w => w.Title.ToLower().Contains(title.ToLower()));
                }

                if (!String.IsNullOrEmpty(author))
                {
                    query = query.Where(w => w.Author.Name.ToLower().Contains(author.ToLower()));
                }

                if (!String.IsNullOrEmpty(genre))
                {
                    query = query.Where(w => w.Genre.Name.ToLower().Contains(genre.ToLower()));
                }

                var results = query.ToList();

                if (results.Count == 0)
                {
                    return NotFound();
                }

                else
                {
                    return Ok(results);
                }

            }
        }

        [HttpGet, Route("API/Status")]
        public IHttpActionResult GetAllCheckedIn()
        {
            using (var db = new LibraryContext())
            {
                var query = db.Books.AsQueryable();
                query = query.Where(w => w.IsCheckedOut == false);
                return Ok(query.ToList());
            }
        }

    }
}
