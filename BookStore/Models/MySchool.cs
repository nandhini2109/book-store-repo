using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class MySchool
    {
        [Key]
        public int StudentID { get; set; }
        public string Firstname { get; set; }

        public string Surname { get; set; }
        public int Age { get; set; }

        public string Gender { get; set; }

        public int Telephone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Guardian { get; set; }


    }
}
