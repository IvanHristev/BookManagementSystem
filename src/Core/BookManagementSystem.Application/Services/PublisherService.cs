using AutoMapper;
using BookManagementSystem.Application.Dtos.PublisherDtos;
using BookManagementSystem.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Domain.Entities;
using BookManagementSystem.Application.Dtos.BookDtos;

namespace BookManagementSystem.Application.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IPublisherRepository _publisherRepository;
        private readonly IMapper _mapper;
        public PublisherService(IPublisherRepository publisherRepository, IMapper mapper)
        {
            _publisherRepository = publisherRepository;
            _mapper = mapper;
        }
        public void CreatePublisher(PublisherCreateDto publisherDto)
        {
            var publisher = new Publisher();
            publisher = _mapper.Map<Publisher>(publisherDto);
            _publisherRepository.Create(publisher);
        }

        public void DeletePublisher(int publisherId)
        {
            _publisherRepository.Delete(publisherId);
        }

        public IEnumerable<PublisherGetDto> GetAllPublishers()
        {
            var publishers = _publisherRepository.GetAll(); 
            return _mapper.Map<IEnumerable<PublisherGetDto>>(publishers);
        }

        public PublisherGetDto GetPublisherById(int publisherId)
        {
            Publisher publisher = _publisherRepository.GetById(publisherId);
            return _mapper.Map<PublisherGetDto>(publisher);
        }

        public void UpdatePublisher(int publisherId, PublisherUpdateDto publisherDto)
        {
            var publisher = _publisherRepository.GetById(publisherId);
             _mapper.Map<PublisherUpdateDto>(publisher);
            _publisherRepository.Update(publisher);
        }
    }
}
