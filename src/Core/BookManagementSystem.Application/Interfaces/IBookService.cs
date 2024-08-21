using BookManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Application.Dtos.BookDtos;
using BookManagementSystem.Application.Dtos.eDtos;

namespace BookManagementSystem.Application.Interfaces
{
    public interface IBookService
    {
        BookGetDto GetBookById(int bookId);
        IEnumerable<BookAuthorDto> GetAuthorsByBookId(int bookId);
        IEnumerable<BookGetDto> GetAllBooks();
        void CreateBook(BookCreateDto book);
        void UpdateBook(int bookId, BookUpdateDto book);
        void DeleteBook(int bookId);

    }
}
