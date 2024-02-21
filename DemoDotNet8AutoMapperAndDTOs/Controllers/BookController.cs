using DemoDotNet8AutoMapperAndDTOs.DTOs;
using DemoDotNet8AutoMapperAndDTOs.Models;
using DemoDotNet8AutoMapperAndDTOs.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoDotNet8AutoMapperAndDTOs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookService bookService;

        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet("all-books")]
        public ActionResult<List<RequestDTO>> GetBooks() => Ok(bookService.GetBooks());
        [HttpGet("book/{id}")]
        public ActionResult<ResponseDTO> GetBook(int id) => Ok(bookService.GetBookById(id));

        [HttpDelete("book/{id}")]
        public ActionResult DeleteBook(int id)
        {
            bookService.DeleteBookById(id);
            return Ok("Deleted");
        }

        [HttpPost("book")]
        public ActionResult AddBook(RequestDTO requestDTO)
        {
            bookService.AddBook(requestDTO);
            return Ok("Added");
        }
    }
}
