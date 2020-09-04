using Microsoft.EntityFrameworkCore;

namespace EFCorePractice
{
    public class MyDbContext : DbContext
    {
        public DbSet<Blog> Blogs {get; set;}
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=TestDatabase.db", options =>
                {
                    
                }
            );
        }
    }
}