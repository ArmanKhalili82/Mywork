using Microsoft.EntityFrameworkCore;
using Models.Data;
using Models.Models;

namespace Business;

public class InfoService : IInfoService
{
    private ApplicationDbContext _context;
    public InfoService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Info>> GetAll()
    {
        var data = await _context.infos.OrderBy(x => x.Name).ToListAsync();
        return data;
    }

    public async Task<List<Info>> GetById(int id)
    {
        var data = await _context.infos.Where(s => s.Id == id).ToListAsync();
        return data;
    }
}