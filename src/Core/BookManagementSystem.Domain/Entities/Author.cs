using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Domain.Entities
{
    public class Author
    {
        
        [Key]
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Biography { get; set; }

        public Author author { get; set; }
        public ICollection<Publisher> Publishers { get; set; }
        public ICollection<Book> Books { get; set;}
        public ICollection<BookAuthor> BookAuthors { get; set;}
    }
}
