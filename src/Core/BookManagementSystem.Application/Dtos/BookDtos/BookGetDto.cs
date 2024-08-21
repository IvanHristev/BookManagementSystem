using BookManagementSystem.Application.Dtos.AuthorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Application.Dtos.BookDtos
{
    public class BookGetDto : BookDto
    {
        public int BookId { get; set; }
        public string PublisherName { get; set; }
        public List<AuthorGetDto> Authors { get; set; }
    }
}
