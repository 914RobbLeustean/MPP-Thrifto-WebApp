﻿// DTOs/LoginDto.cs
using System.ComponentModel.DataAnnotations;

namespace ThriftoServer.DTOs
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}