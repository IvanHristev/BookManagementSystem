using BookManagementSystem.Application.Dtos.AuthorDtos;
using BookManagementSystem.Application.Interfaces;
using BookManagementSystem.Domain.Entities;
using BookManagementSystem.Persistence.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Persistence.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _context;
        public AuthorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void Delete(int authorId)
        {
            var author = _context.Authors.SingleOrDefault(x => x.AuthorId == authorId);
            if (author != null)
            {
                _context.Authors.Remove(author);
            }
            else
            {
                throw new Exception("This author does not exist");
            }
            _context.SaveChanges();
        }

        public IEnumerable<Author> GetAll()
        {
            return _context.Authors;
        }

        public Author GetById(int authorId)
        {
            return _context.Authors.SingleOrDefault(x => x.AuthorId == authorId);
        }

        public IEnumerable<Book> GetBooksByAuthorId(int authorId)
        {
            return _context.Books
                .Include(b => b.BookAuthors)
                .Where(u => u.BookAuthors.Any(c => c.AuthorId == authorId));
        }
        public void Update(Author author)
        {
            var existingAuthor = _context.Authors.SingleOrDefault(x => x.AuthorId == author.AuthorId);
            if (existingAuthor != null)
            {
                existingAuthor.AuthorId = author.AuthorId;
                existingAuthor.DateOfBirth = author.DateOfBirth;
                existingAuthor.Biography = author.Biography;
                existingAuthor.FirstName = author.FirstName;
                existingAuthor.LastName = author.LastName;
            }
            else
            {
                throw new Exception("This author does not exist");
            }
            _context.SaveChanges();
        }
    }
}
