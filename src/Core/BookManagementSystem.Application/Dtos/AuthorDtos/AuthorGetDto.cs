using BookManagementSystem.Application.Dtos.PublisherDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Application.Dtos.AuthorDtos
{
    public class AuthorGetDto
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public List<PublisherGetDto> Publishers { get; set; }
    }
}
