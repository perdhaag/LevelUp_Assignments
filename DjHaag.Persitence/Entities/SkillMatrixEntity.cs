namespace DjHaag.Persitence.Entities;

public class SkillMatrixEntity
{
    public int CandidateId { get; set; }
    
    public IEnumerable<CategoryEntity> CategoryEntities { get; set; }
    
    public MatrixStatus Open { get; set; }

}