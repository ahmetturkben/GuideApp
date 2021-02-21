﻿using System.ComponentModel.DataAnnotations;

namespace Guide.API.Models
{
    public class Authenticate
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
