using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using BookManagementSystem.Domain.Entities;

namespace BookManagementSystem.Persistence
{
    public class BookContext: DbContext
    {
        public BookContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthor { get; set; }
    }
}
