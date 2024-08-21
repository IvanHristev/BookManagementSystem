using AutoMapper;
using BookManagementSystem.Application.Dtos.AuthorDtos;
using BookManagementSystem.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Domain.Entities;
using BookManagementSystem.Application.Dtos.BookDtos;
using BookManagementSystem.Application.Dtos.eDtos;

namespace BookManagementSystem.Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }
        public void CreateAuthor(AuthorCreateDto authorDto)
        {
            var author = new Author();
            author = _mapper.Map<Author>(authorDto);
            _authorRepository.Create(author);
        }

        public void DeleteAuthor(int authorId)
        {
            _authorRepository.Delete(authorId);
        }

        public IEnumerable<AuthorGetDto> GetAllAuthors()
        {
            var authors = _authorRepository.GetAll();
            return _mapper.Map<IEnumerable<AuthorGetDto>>(authors);
        }

        public IEnumerable<AuthorBookDto> GetBooksByAuthorId(int authorId) 
        {
            IEnumerable<Book> books = _authorRepository.GetBooksByAuthorId(authorId);
            return _mapper.Map<IEnumerable<AuthorBookDto>>(books);
        }
        public AuthorGetDto GetAuthorById(int authorId)
        {
            Author author = _authorRepository.GetById(authorId);
            return _mapper.Map<AuthorGetDto>(author);
        }

        public void UpdateAuthor(int authorId,AuthorUpdateDto authorDto)
        {
            var author = _mapper.Map<Author>(authorDto);
            _authorRepository.Update(author);
        }
    }
}
