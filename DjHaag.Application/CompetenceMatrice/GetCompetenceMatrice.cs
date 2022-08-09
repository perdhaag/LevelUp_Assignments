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

    public async Task<Persitence.CompetenceMatrice>  GetCompetenceMatriceQuery()
    {
        var test = await _dbContext.CompetenceMatrices
            .Where(x => x.CompetenceMatricesCategory == CompetenceMatricesCategory.Microsoft)
            .Include(x => x.CategoryThemes).FirstOrDefaultAsync();

        return test;
    }
}