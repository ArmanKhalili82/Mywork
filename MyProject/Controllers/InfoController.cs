using Business;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers;

[Route("Info")]
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
        var data = await _infoService.GetAll();
        return Ok(data);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = await _infoService.GetById(id);
        return Ok(data);
    }
}
