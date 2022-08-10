using System.ComponentModel.DataAnnotations.Schema;

namespace DjHaag.Persitence.Entities;

public class SkillEntity
{
    public int Id { get; set; }
    
    public string Name { get; set; }

    [ForeignKey("CompetenceMatriceId")]
    public CategoryEntity Category { get; set; }
    
    public int CompetenceMatriceId { get; set; }
}