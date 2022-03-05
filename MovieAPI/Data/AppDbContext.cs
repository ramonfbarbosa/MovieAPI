using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;

namespace MovieAPI.Data
{
    public class AppDbContext : DbContext 
    { 
        
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieTheater> MoviesTheater { get; set; }
        public DbSet<Address> Address { get; set; }

    }
}
