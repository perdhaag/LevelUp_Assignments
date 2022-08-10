namespace DjHaag.Persitence.Entities;

public class SkillAnswerEntity
{
    public int Id { get; set; }
    
    public SkillMatrixEntity SkillMatrixEntity { get; set; }
    
    public SkillEntity Skill { get; set; }

    public int Score { get; set; }
}