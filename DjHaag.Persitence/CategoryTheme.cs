using System.ComponentModel.DataAnnotations.Schema;

namespace DjHaag.Persitence;

public class CategoryTheme
{
    public int Id { get; set; }
    
    public string Theme { get; set; }

    [ForeignKey("CompetenceMatriceId")]
    public CompetenceMatrice CompetenceMatrice { get; set; }
    public int CompetenceMatriceId { get; set; }
}