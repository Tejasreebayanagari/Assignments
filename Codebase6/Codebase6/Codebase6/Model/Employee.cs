using System.ComponentModel.DataAnnotations;

namespace Codebase6.Model
{
    public class Employee
    {
        [Key]
        public int employeeid { get; set; }
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }

        public string Address { get; set; }
        public string Phonenumber { get; set; } 

    }
}
