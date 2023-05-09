using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Voters> India { get; set; }
        public DbSet<MyPraveen> Praveen { get; set; }
        public DbSet<MyIndians> Indians{ get; set; }
        public DbSet<MySchool> Schools { get; set; }
        public DbSet<MyPractice> Practice { get; set; }
        public DbSet<MyNyc> Nyc { get; set; }


    }


   

}
