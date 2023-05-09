using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class MyIndians
    {
        public string Name { get; set; }

        [Key]
        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime DOB { get; set; }


        public Boolean Indian { get; set; }

        public Boolean AccountVerified { get; set; }

        public string Location { get; set; }

        public string Height { get; set; }

        public DateTime LastUpdatedDateTime { get; set; } = DateTime.Now;


        public DateTime CreatedDateTime { get; set; } = DateTime.Now;


}

}