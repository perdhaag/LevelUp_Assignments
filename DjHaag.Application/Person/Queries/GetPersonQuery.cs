using DjHaag.Application.Person.Commands;
using DjHaag.Persitence;
using Microsoft.EntityFrameworkCore;

namespace DjHaag.Application.Person.Queries;

public class GetPersonQuery
{
    private readonly DjHaagDbContext _dbContext; 
    public GetPersonQuery(DjHaagDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<PersonDto>> GetPersonQueryHandler()
    {
        return await _dbContext.Persons.Select(s => new PersonDto()
        {
            FirstName = s.FirstName,
            LastName = s.LastName
        }).ToListAsync();
    }
}