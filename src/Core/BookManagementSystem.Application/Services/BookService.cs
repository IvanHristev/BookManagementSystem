using BookManagementSystem.Application.Dtos;
using BookManagementSystem.Application.Interfaces;
using BookManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void CreateBook(BookCreateDto bookDto)
        {
            var book = new Book
            {
                //BookId = GenerateBookId(),
                Title = bookDto.Title,
                Genre = bookDto.Genre,
                PublishDate = bookDto.PublishDate,
                PublisherId = bookDto.PublisherId
            };
            _bookRepository.Add(book);
        }

        public void DeleteBook(int id)
        {
            _bookRepository.Delete(id);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetAll();
        }

        public Book GetBookById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.Update(book);
        }
        //private int GenerateBookId() => _bookRepository.GetAll().Count() + 1;
    }
}
