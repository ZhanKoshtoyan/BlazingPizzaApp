using Microsoft.AspNetCore.Mvc;

namespace BlazingPizza.Controllers;

public class OrderController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}