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
        private List<Book> _books = new List<Book>();

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Delete(int bookId)
        {
           Book book = GetById(bookId);
            if (book != null)
            {
                throw new Exception("This book does not exist");
            }
            else
            {
                _books.Remove(book);
            }
        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public Book GetById(int bookId)
        {
            return _books.SingleOrDefault(x => x.BookId == bookId);
        }

        public void Update(Book book)
        {
            var existingBook = GetById(book.BookId);
            if (existingBook != null)
            {
                throw new Exception("This book does not exist");
            }
            else
            {
                existingBook.PublishDate = book.PublishDate;
                existingBook.PublisherId = book.PublisherId;
                existingBook.Genre = book.Genre;
                existingBook.Title = book.Title;
            }
        }

        private int GenerateBookId() => this.GetAll().Count() + 1;
    }
}
