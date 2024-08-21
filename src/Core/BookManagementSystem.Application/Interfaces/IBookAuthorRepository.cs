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
        IEnumerable<BookAuthor> GetAll();
        void Add(BookAuthor bookAuthor);
        void DeleteByAuthorId(int artistId);
        void DeleteByBookId(int bookId);
    }
}
