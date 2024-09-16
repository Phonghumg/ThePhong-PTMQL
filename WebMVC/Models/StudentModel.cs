using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    
    public class Student
    {
        
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }
}
