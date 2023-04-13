using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        
        }

       public  DbSet<Actor> Actors { set; get; }
        public DbSet<Cinema> Cinemas { set; get; }
        public DbSet<Movie> Movies { set; get; }

        public DbSet<Producer> Producers { set; get; }  
    }
}
