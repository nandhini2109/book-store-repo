using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Voters

    {
        public string Name { get; set; }

        public string Village { get; set; }
        [Key]
        public int Adhar { get; set; }

      

    }
}     