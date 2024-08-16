using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Domain.Entities
{
    public class BookAuthor
    {
        [Key]
        public int BookId { get; set; }
        [Key]
        public int AuthorId { get; set; }
    }
}
