using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}