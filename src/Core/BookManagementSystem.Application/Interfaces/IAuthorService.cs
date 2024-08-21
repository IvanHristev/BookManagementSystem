using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Application.Dtos.AuthorDtos;
using BookManagementSystem.Application.Dtos.eDtos;
using BookManagementSystem.Domain.Entities;

namespace BookManagementSystem.Application.Interfaces
{
    public interface IAuthorService
    {
        AuthorGetDto GetAuthorById(int authorId);
        IEnumerable<AuthorBookDto> GetBooksByAuthorId(int authorId);
        IEnumerable<AuthorGetDto> GetAllAuthors();
        void CreateAuthor(AuthorCreateDto author);
        void UpdateAuthor(int authorId, AuthorUpdateDto author);
        void DeleteAuthor(int authorId);
    }
}
