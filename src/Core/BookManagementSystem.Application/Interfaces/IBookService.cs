using BookManagementSystem.Domain.Entities;
using BookManagementSystem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Application.Interfaces
{
    public interface IBookService
    {
        Book GetBookById(int bookId);
        IEnumerable<Book> GetAllBooks();
        void CreateBook(BookCreateDto book);
        void UpdateBook(Book book);
        void DeleteBook(int bookId);

    }
}
