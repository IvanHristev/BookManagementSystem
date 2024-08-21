using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Domain.Entities
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Author Author { get; set; }
        public ICollection<Book> Books { get; set;} = new List<Book>();
    }
}
