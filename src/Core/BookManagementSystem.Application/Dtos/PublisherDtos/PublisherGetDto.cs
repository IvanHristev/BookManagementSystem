using BookManagementSystem.Application.Dtos.BookDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Application.Dtos.PublisherDtos
{
    public class PublisherGetDto : PublisherDto
    {
        public int PublisherId { get; set; }
        public string AuthorName { get; set; }
        public IEnumerable<BookGetDto> Books { get; set; }
    }
}
