using BookAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    // https://localhost:7082/api/books
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book{ Id = 1, Author = "Author One", Title = "Book One", Description = "description here" },
            new Book{ Id = 2, Author = "Author Two", Title = "Book Two", Description = "description here" },
            new Book{ Id = 3, Author = "Author Three", Title = "Book Three", Description = "description here" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }
    }
}
