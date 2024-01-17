using Microsoft.EntityFrameworkCore;
using MyProject.Data;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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