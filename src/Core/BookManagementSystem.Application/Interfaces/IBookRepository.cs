using BookManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Application.Dtos.BookDtos;

namespace BookManagementSystem.Application.Interfaces
{
    public interface IBookRepository
    {
        Book GetById(int bookId);
        IEnumerable<Book> GetAll();
        IEnumerable<Author> GetAuthorsByBookId(int bookId);
        void Create(Book book);
        void Update(Book book);
        void Delete(int bookId);
    }
}
