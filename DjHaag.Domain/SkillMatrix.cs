using System.Collections.ObjectModel;
using DjHaag.Persitence.Entities;

namespace DjHaag.Domain;

public class SkillMatrix
{
    public int cadidateId { get; private set; }
    
    public List<SkillCategory> SkillCategories { get; set; }
    
    private readonly List<SkillAnswerEntity> _skillAnswerEntities = new List<SkillAnswerEntity>();
    public ReadOnlyCollection<SkillAnswerEntity> SkillAnswers => _skillAnswerEntities.AsReadOnly();
        
    public SkillMatrix(int candidateId, List<SkillCategory> categegoryEntities)
    {
        this.cadidateId = cadidateId;

        foreach (var categegoryEntity in categegoryEntities)
        {
            foreach (var skillEntity in categegoryEntity.Skills)
            {
                _skillAnswerEntities.Add(new SkillAnswerEntity()
                {
                    Id = skillEntity.Id
                });
            }
        }
    }

        public void SetAnswer(int skillId, int value)
        {
            var answer = _skillAnswerEntities.FirstOrDefault(s => s.Id == skillId);

            answer.Score = value;
        }
}

public class SkillCategory
{
    public int Id { get; private set; }
    
    public string Name { get; private set; }
    
    public IEnumerable<SkillEntity> Skills { get; private set; }
}