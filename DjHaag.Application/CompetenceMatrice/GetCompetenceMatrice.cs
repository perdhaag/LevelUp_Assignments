using DjHaag.Persitence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace DjHaag.Application.CompetenceMatrice;

public class GetCompetenceMatrice
{

    private readonly DjHaagDbContext _dbContext;
    public GetCompetenceMatrice(DjHaagDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IIncludableQueryable<Persitence.CompetenceMatrice, List<CategoryTheme>>> GetCompetenceMatriceQuery()
    {
        var test = _dbContext.CompetenceMatrices
            .Include(x => x.CategoryThemes);

        return test;
    }
}