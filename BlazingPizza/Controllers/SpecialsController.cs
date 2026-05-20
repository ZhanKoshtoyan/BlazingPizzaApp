using Microsoft.AspNetCore.Mvc;

namespace BlazingPizza.Controllers;

public class SpecialsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}