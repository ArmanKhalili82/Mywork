using Business;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProject.Data;
using MyProject.Models;

namespace MyProject.Controllers;

public class InfoController : Controller
{
    private IInfoService _infoService;
    public InfoController(IInfoService infoService)
    {
        _infoService = infoService;
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll(string name)
    {
        var data = _infoService.GetAll();
        return Ok(data);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = _infoService.GetById(id);
        return Ok(data);
    }

    [HttpGet("Search")]
    public async Task<IActionResult> Search()
    {
        var db = new ApplicationDbContext();
        var name = Console.ReadLine();
        var data = await db.infos.Where(x => x.Name.Contains(name)).ToListAsync();
        return Ok(data);
    }
}
