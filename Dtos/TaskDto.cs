using System;
using System.ComponentModel.DataAnnotations;

namespace ProvaWegen.Dtos
{
    public class CreateTaskDto
    {
        [Required]
        [MinLength(3)]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        [Required]
        public string Category { get; set; }
    }

    public class UpdateTaskDto
    {
        [MinLength(3)]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public string Category { get; set; }
        
        public bool? IsCompleted { get; set; }
    }
}