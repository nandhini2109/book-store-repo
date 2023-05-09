using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class MyPractice
    {
        [Key]
        public int Id { get; set; }
       
        public string Name  { get; set; }
        public bool Indian { get; set; }
        public float Height { get; set; }
    }
}
