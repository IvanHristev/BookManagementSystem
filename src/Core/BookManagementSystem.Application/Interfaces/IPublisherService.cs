using BookManagementSystem.Application.Dtos.PublisherDtos;
using BookManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Domain.Entities;

namespace BookManagementSystem.Application.Interfaces
{
    public interface IPublisherService
    {
        PublisherGetDto GetPublisherById(int publisherId);
        IEnumerable<PublisherGetDto> GetAllPublishers();
        void CreatePublisher(PublisherCreateDto publisher);
        void UpdatePublisher(int publisherId, PublisherUpdateDto publisher);
        void DeletePublisher(int publisherId);
    }
}
