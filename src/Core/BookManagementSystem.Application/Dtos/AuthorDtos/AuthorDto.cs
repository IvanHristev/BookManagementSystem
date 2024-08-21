using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Application.Dtos.AuthorDtos
{
    public abstract class AuthorDto
    {
        [Required]
        [MaxLength(15)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(15)]
        public string LastName { get; set; }
        [Required]
        public DateOnly BirthDay { get; set; }
        [Required]
        [MaxLength(200)]
        public string Biography { get; set; }
    }
}
