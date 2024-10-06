using BookAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BookAPI.Services;
using System.Collections.Generic;

namespace BookAPI.Controllers
{
    // https://localhost:7082/api/books
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;
        
        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_bookService.GetBooks());
        }
    }
}
