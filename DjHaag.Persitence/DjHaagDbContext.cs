using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DjHaag.Persitence;

public class DjHaagDbContext : DbContext
{
    public DjHaagDbContext(DbContextOptions<DjHaagDbContext> options) : base(options)
    {
    }
    
    public DbSet<Person> Persons { get; set; }

    public DbSet<CompetenceMatrice> CompetenceMatrices { get; set; }

    public DbSet<CategoryTheme> CategoryThemes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompetenceMatrice>().HasData(SeedCompetenceCategories());
        modelBuilder.Entity<CategoryTheme>().HasData(SeedCategoryThemes());
    }

    private List<CategoryTheme> SeedCategoryThemes()
    {
        List<CategoryTheme> categoryThemes;

        using (StreamReader r = new StreamReader("C:\\Users\\per.haagensen\\RiderProjects\\TestDeploy\\DjHaag.Application\\CompetenceMatrice\\CategoryThemes.json"))
        {
            string json = r.ReadToEnd();
            categoryThemes = JsonConvert.DeserializeObject<List<CategoryTheme>>(json);
        }
        return categoryThemes;
    }


    private List<CompetenceMatrice> SeedCompetenceCategories()
    {
        List<CompetenceMatrice> categories;
        using (StreamReader r = new StreamReader("C:\\Users\\per.haagensen\\RiderProjects\\TestDeploy\\DjHaag.Application\\CompetenceMatrice\\CompetenceCategories.json"))
        {
            string json = r.ReadToEnd();
            categories = JsonConvert.DeserializeObject<List<CompetenceMatrice>>(json);
        }
        return categories;
    }
}