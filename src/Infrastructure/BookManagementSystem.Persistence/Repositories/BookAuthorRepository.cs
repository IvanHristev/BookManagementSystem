using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Application.Interfaces;
using BookManagementSystem.Domain.Entities;
using BookManagementSystem.Persistence.DB;

namespace BookManagementSystem.Persistence.Repositories
{
    public class BookAuthorRepository : IBookAuthorRepository
    {
        private readonly ApplicationDbContext _context;

        public void Add(BookAuthor bookAuthor)
        {
            _context.BookAuthors.Add(bookAuthor);
            _context.SaveChanges();
        }

        public void DeleteByAuthorId(int authorId)
        {
            var bookAuthor = _context.BookAuthors.FirstOrDefault(u => u.AuthorId == authorId);
            if (bookAuthor != null)
            {
                _context.BookAuthors.Remove(bookAuthor);
            }
            _context.SaveChanges();
        }

        public void DeleteByBookId(int bookId)
        {
            var bookAuthor = _context.BookAuthors.FirstOrDefault(u => u.BookId == bookId);
            if (bookAuthor != null)
            {
                _context.BookAuthors.Remove(bookAuthor);
            }
            _context.SaveChanges();
        }

        public IEnumerable<BookAuthor> GetAll()
        {
            return _context.BookAuthors;
        }
    }
}
