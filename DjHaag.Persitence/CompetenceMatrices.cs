namespace DjHaag.Persitence;

public class CompetenceMatrice
{
    public int Id { get; set; }
    
    public CompetenceMatricesCategory CompetenceMatricesCategory { get; set; }
    
    public List<CategoryTheme> CategoryThemes { get; set; } 
}

public enum CompetenceMatricesCategory
{
    Microsoft = 1,
    Metodikk = 2,
    Web = 3,
    FrontendTesting = 4,
    ORM = 5,
    UnittestOrMocking = 6,
    Messaging = 7,
    BuildAndDeploy = 8,
    Cloud = 9,
    SearchAndBigData = 10,
    IoCContainers = 11,
    Security = 12,
    Logging = 13,
    Other = 14
}