using BookManagementSystem.Application.Dtos.AuthorDtos;
using BookManagementSystem.Application.Dtos.eDtos;
using BookManagementSystem.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IEnumerable<AuthorGetDto> Get()
        {
            return (IEnumerable<AuthorGetDto>)_authorService.GetAllAuthors();
        }

        [HttpGet]
        [Route("{id}")]
        public AuthorGetDto GetById(int id)
        {
            return _authorService.GetAuthorById(id);
        }

        [HttpGet]
        [Route("{id}\\AuthorBook")]
        public IEnumerable<AuthorBookDto> GetBooksByAuthorId(int id)
        {
            return _authorService.GetBooksByAuthorId(id);
        }

        [HttpPost]
        public void Post([FromBody] AuthorCreateDto authorDto)
        {
            _authorService.CreateAuthor(authorDto);
        }

        [HttpPut]
        [Route("{id}")]
        public void Put(int id, [FromBody] AuthorUpdateDto authorDto)
        {
            _authorService.UpdateAuthor(id, authorDto);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _authorService.DeleteAuthor(id);
        }
    }
}
