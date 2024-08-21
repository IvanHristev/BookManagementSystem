using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Application.Dtos.PublisherDtos
{
    public class PublisherCreateDto : PublisherDto
    {
        public int PublisherId { get; set; }
    }
}
