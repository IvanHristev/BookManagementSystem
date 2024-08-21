using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Application.Dtos.PublisherDtos;
using BookManagementSystem.Application.Interfaces;
using BookManagementSystem.Domain.Entities;
using BookManagementSystem.Persistence.DB;

namespace BookManagementSystem.Persistence.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly ApplicationDbContext _context;
        public PublisherRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
        }

        public void Delete(int publisherId)
        {
            var publisher = _context.Publishers.SingleOrDefault(x => x.PublisherId == publisherId);
            if (publisher != null)
            {
                _context.Publishers.Remove(publisher);
            }
            else
            {
                throw new Exception("This publisher does not exist");
            }
            _context.SaveChanges();
        }

        public IEnumerable<Publisher> GetAll()
        {
            return _context.Publishers;
        }

        public Publisher GetById(int publisherId)
        {
            return _context.Publishers
                .Include(x => x.Books)
                .FirstOrDefault(u => u.PublisherId == publisherId);
        }

        public void Update(Publisher publisher)
        {
            var existingPublisher = _context.Publishers.SingleOrDefault(x => x.PublisherId == publisher.PublisherId);
            if (existingPublisher != null)
            {
                existingPublisher.PublisherId = publisher.PublisherId;
                existingPublisher.Address = publisher.Address;
                existingPublisher.Name = publisher.Name;

            }
            else
            {
                throw new Exception("This publisher does not exist");
            }
            _context.SaveChanges();
        }
    }
}
