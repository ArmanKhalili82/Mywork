using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
