using System;
using System.ComponentModel.DataAnnotations;

namespace ProvaWegen.Dtos
{
    public class RegisterUserDto
    {
        [Required]
        [MinLength(3)]
        public string Username { get; set; }
        
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }

    public class LoginDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }
    }

    public class UserResponseDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}