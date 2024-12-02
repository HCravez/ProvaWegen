using System;
using System.ComponentModel.DataAnnotations;

namespace ProvaWegen.Models
{
    public class TodoTask
    {
        public int Id { get; set; }
        
        [Required]
        [MinLength(3)]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public bool IsCompleted { get; set; }
        
        [Required]
        public string Category { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime? UpdatedAt { get; set; }
        
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}