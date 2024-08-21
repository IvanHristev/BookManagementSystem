using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Domain.Entities;
using BookManagementSystem.Application.Dtos.AuthorDtos;

namespace BookManagementSystem.Application.Interfaces
{
    public interface IAuthorRepository
    {
        Author GetById(int authorId);
        IEnumerable<Author> GetAll();
        IEnumerable<Book> GetBooksByAuthorId(int authorId);
        void Create(Author author);
        void Update(Author author);
        void Delete(int authorId);
    }
}
