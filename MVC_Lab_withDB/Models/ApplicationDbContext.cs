using Microsoft.EntityFrameworkCore;

namespace MVC_Lab_withDB.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) : base(Options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author()
                {
                    AuthorID = 1,
                    FirstName = "first",
                    LastName = "Last"
                },
               new Author()
               {
                   AuthorID = 2,
                   FirstName = "second",
                   LastName = "Last"
               }

                );
        }


    }
}
