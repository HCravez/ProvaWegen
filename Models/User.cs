using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ProvaWegen.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Username { get; set; }
        
        [Required]
        public string PasswordHash { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public virtual ICollection<TodoTask> Tasks { get; set; }
    }
}