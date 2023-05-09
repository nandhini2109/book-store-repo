using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class MyNyc
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }


    }
}



