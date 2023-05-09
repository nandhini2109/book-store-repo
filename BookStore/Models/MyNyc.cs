using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class MyNyc
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }


    }
}



