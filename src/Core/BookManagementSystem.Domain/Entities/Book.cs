﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Domain.Entities
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(20)]
        public string Genre { get; set; }
        [Required]
        public DateOnly PublishDate { get; set; }
        [Required]
        public int PublisherId { get; set; }
    }
}
