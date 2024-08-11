using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Domain.Entities;

namespace BookManagementSystem.Application.Interfaces
{
    public interface IAuthorRepository
    {
        Author GetById(int authorId);
        IEnumerable<Author> GetAll();
        void Add(Author author);
        void Update(Author author);
        void Delete(int authorId);
    }
}
