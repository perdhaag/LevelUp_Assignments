using Microsoft.EntityFrameworkCore;

namespace DjHaag.Persitence;

public class DjHaagDbContext : DbContext
{
    public DjHaagDbContext(DbContextOptions<DjHaagDbContext> options) : base(options)
    {
    }
    
    public DbSet<Person> Persons { get; set; }
}