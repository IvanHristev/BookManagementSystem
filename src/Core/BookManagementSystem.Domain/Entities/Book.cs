﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Domain.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateOnly PublishDate { get; set; }
        public int PublisherId { get; set; }
    }
}
