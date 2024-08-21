using BookManagementSystem.Application.Dtos.PublisherDtos;
using BookManagementSystem.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherService _publisherService;

        public PublisherController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        [HttpGet]
        public IEnumerable<PublisherGetDto> Get()
        {
            return (IEnumerable<PublisherGetDto>)_publisherService.GetAllPublishers();
        }

        [HttpGet]
        [Route("{id}")]
        public PublisherGetDto GetById(int id)
        {
            return _publisherService.GetPublisherById(id);
        }


        [HttpPost]
        public void Post([FromBody] PublisherCreateDto publisherDto)
        {
            _publisherService.CreatePublisher(publisherDto);
        }

        [HttpPut]
        [Route("{id}")]
        public void Put(int id, [FromBody] PublisherUpdateDto publisherDto)
        {
            _publisherService.UpdatePublisher(id, publisherDto);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _publisherService.DeletePublisher(id);
        }
    }
}
