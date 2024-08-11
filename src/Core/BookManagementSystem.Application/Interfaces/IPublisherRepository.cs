using BookManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Application.Interfaces
{
    public interface IPublisherRepository
    {
        Publisher GetById(int publisherId);
        IEnumerable<Publisher> GetAll();
        void Add(Publisher publisher);
        void Update(Publisher publisher);
        void Delete(int publisherId);
    }
}
