using BookManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Application.Interfaces
{
    public interface IBookAuthorRepository
    {
        BookAuthor GetById(int bookId, int authorId);
        IEnumerable<BookAuthor> GetAll();
        void Add(Book book, Author author);
        void Delete(int bookId, int authorId);
    }
}
