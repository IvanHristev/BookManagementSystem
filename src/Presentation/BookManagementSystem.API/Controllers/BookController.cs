using Microsoft.AspNetCore.Mvc;
using BookManagementSystem.Application.Interfaces;
using BookManagementSystem.Domain.Entities;
using BookManagementSystem.Application.Dtos;
using BookManagementSystem.Application.Dtos.BookDtos;
using BookManagementSystem.Application.Dtos.eDtos;

namespace BookManagementSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IEnumerable<BookGetDto> Get()
        {
            return (IEnumerable<BookGetDto>)_bookService.GetAllBooks();
        }

        [HttpGet]
        [Route("{id}")]
        public BookGetDto GetById(int id)
        {
            return _bookService.GetBookById(id);
        }

        [HttpGet]
        [Route("{id}\\BookAuthor")]
        public IEnumerable<BookAuthorDto> GetAuthorsByBookId(int id)
        {
            return _bookService.GetAuthorsByBookId(id);
        }

        [HttpPost]
        public void Post([FromBody] BookCreateDto bookDto)
        {
            _bookService.CreateBook(bookDto);
        }

        [HttpPut]
        [Route("{id}")]
        public void Put(int id, [FromBody] BookUpdateDto bookDto)
        {
            _bookService.UpdateBook(id, bookDto);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _bookService.DeleteBook(id);
        }
    }
}
