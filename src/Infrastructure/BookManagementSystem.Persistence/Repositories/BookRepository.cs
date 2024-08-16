using BookManagementSystem.Application.Interfaces;
using BookManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _context;

        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(int bookId)
        {
            var book = _context.Books.SingleOrDefault(x => x.BookId == bookId);
            if (book != null)
            {
                _context.Books.Remove(book);
            }
            else
            {
                throw new Exception("This book does not exist");
            }
            _context.SaveChanges();
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books;
        }

        public Book GetById(int bookId)
        {
            return _context.Books.SingleOrDefault(x => x.BookId == bookId);
        }

        public void Update(Book book)
        {
            var existingBook = _context.Books.SingleOrDefault(x => x.BookId == book.BookId);
            if (existingBook != null)
            {
                existingBook.PublishDate = book.PublishDate;
                existingBook.PublisherId = book.PublisherId;
                existingBook.Genre = book.Genre;
                existingBook.Title = book.Title;
            }
            else
            {
                throw new Exception("This book does not exist");
            }
            _context.SaveChanges();
        }

        private int GenerateBookId() => this.GetAll().Count() + 1;
    }
}
