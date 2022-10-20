using LibraryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryService.Controllers
{
    public class BookController : ApiController
    {
        public List<Book> books = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "The Cat In The Hat",
                Author = "Dr. Seuss",
                PublicationYear = 2010,
                CallNumber = "CatHat"
            },
            new Book()
            {
                Id = 2,
                Title = "Harry Potter",
                Author = "J.K. Rowling",
                PublicationYear = 2005,
                CallNumber = "HarryPotter"
            }
        };
        

        // GET api/books
        public IEnumerable<Book> Get()
        {
            return books;
        }

        public IHttpActionResult Get(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if(book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
    }
}
