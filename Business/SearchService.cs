using Microsoft.EntityFrameworkCore;
using Models.Data;
using Models.Models;

namespace Business;

public class SearchService : ISearchService
{
    private ApplicationDbContext _context;
    public SearchService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Country>> GetCountriesByName(string name)
    {
        var data = await _context.Countries.Where(x => x.Name.Contains(name)).ToListAsync();
        return data;
    }

    public async Task<List<City>> GetCitiesByCountryId(int countryId)
    {
        var data = await _context.Cities.Where(s => s.CountryId == countryId).ToListAsync();
        return data;
    }
}