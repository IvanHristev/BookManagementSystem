using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Application.Dtos.BookDtos
{
    public class BookCreateDto : BookDto
    {
        [Required]
        public int BookId { get; set; }
        [Required]
        public int PublisherId { get; set; }
    }
}
