using System;
using System.Threading.Tasks;
using DjHaag.Persitence;
using Microsoft.EntityFrameworkCore;

namespace DjHaag.Application.Person.Commands;

public class AddPersonCommand
{
    private readonly DjHaagDbContext _dbContext;

    public AddPersonCommand(DjHaagDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<PersonDto> AddPersonCommandHandler(PersonDto person)
    {
        var personToAdd = new Persitence.Person()
        {
            FirstName = person.FirstName,
            LastName = person.LastName
        };
        await CheckIfPersonAlreadyExists(personToAdd);
        await _dbContext.AddAsync(personToAdd);
        await _dbContext.SaveChangesAsync();
        return person;
    }

    public async Task CheckIfPersonAlreadyExists(Persitence.Person person)
    {
        if (await _dbContext.Persons.AnyAsync(x =>
                x.FirstName.ToLower() == person.FirstName.ToLower() &&
                x.LastName.ToLower() == person.LastName.ToLower()))
        {
            throw new ArgumentException("Person is allready added");
        }
    }
}