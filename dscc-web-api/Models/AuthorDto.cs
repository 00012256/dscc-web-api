﻿using System.ComponentModel.DataAnnotations;

namespace dscc_web_api.Models
{
    public class AuthorDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Biography { get; set; }
    }

}
