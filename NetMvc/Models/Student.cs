using System.ComponentModel.DataAnnotations;

namespace NetMvc.Models
{
    public class Student
    {
        [Key]
        
    public string FullName {get; set;}

    public string Address {get; set;}

    public string Email {get; set;}

    public string Phone {get; set;}
    }

}