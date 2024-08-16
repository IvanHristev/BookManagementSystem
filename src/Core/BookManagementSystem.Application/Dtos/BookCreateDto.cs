using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Application.Dtos
{
    public class BookCreateDto
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateOnly PublishDate { get; set; }
        public int PublisherId { get; set; }
    }
}
