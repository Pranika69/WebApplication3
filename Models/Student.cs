using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Student
    {
        internal static int id;

        public int Id { get; set; }
        //[Required]
        //[Display(Name = "Full Name")]

        //public string Name { get; set; }

        public string FullName { get; set; }

        public int RollNO { get; set; }

        public int Class { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }

}
