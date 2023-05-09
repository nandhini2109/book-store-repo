using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class MyPraveen
    {
        [Key]
        public int Rullnumber { get; set; }
        public string Name { get; set; }
    }
}
