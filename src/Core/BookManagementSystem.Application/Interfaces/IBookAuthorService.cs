using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Application.Dtos.BookDtos;
using BookManagementSystem.Application.Dtos.AuthorDtos;
using BookManagementSystem.Domain.Entities;

namespace BookManagementSystem.Application.Interfaces
{
    public interface IBookAuthorService
    {
        BookAuthor GetBookAuthorById(int bookId, int authorId);
        IEnumerable<BookAuthor> GetAllBookAuthors();
        void CreateBookAuthor(BookCreateDto bookId, AuthorCreateDto authorId);
        void UpdateBookAuthor();
        void DeleteBookAuthor(int bookId, int authorId);
    }
}
