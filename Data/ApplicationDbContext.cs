using Cinema.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Movie> Movies { get; set; }
  }
}