using AutoMapper;
using BookManagementSystem.Application.Dtos.BookDtos;
using BookManagementSystem.Application.Dtos.eDtos;
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
        private readonly IMapper _mapper;
        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public void CreateBook(BookCreateDto bookDto)
        {
            var book = new Book();
            book = _mapper.Map<Book>(bookDto);
            _bookRepository.Create(book);
        }

        public void DeleteBook(int bookid)
        {
            _bookRepository.Delete(bookid);
        }

        public IEnumerable<BookGetDto> GetAllBooks()
        {
            var books = _bookRepository.GetAll();
            return _mapper.Map<IEnumerable<BookGetDto>>(books);
        }
        public IEnumerable<BookAuthorDto> GetAuthorsByBookId(int bookId)
        {
            IEnumerable<Author> authors = _bookRepository.GetAuthorsByBookId(bookId);
            return _mapper.Map<IEnumerable<BookAuthorDto>>(authors);
        }

        public BookGetDto GetBookById(int id)
        {
            Book book = _bookRepository.GetById(id);
            return _mapper.Map<BookGetDto>(book);
        }

        public void UpdateBook(int bookId, BookUpdateDto book)
        {
            Book updatedBook = _mapper.Map<Book>(book);
            _bookRepository.Update(updatedBook);
        }
    }
}
