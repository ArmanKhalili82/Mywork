using Business;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers;

[Route("Info")]
public class InfoController : Controller
{
    private ISearchService _infoService;
    public InfoController(ISearchService infoService)
    {
        _infoService = infoService;
    }

    [HttpGet("GetCountriesByName/{name}")]
    public async Task<IActionResult> GetAll(string name)
    {
        var data = await _infoService.GetCountriesByName(name);
        return Ok(data);
    }

    [HttpGet("GetCitiesByCountryId/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = await _infoService.GetCitiesByCountryId(id);
        return Ok(data);
    }
}
