using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_Tjor.Models;

namespace TP04_Tjor.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Paquetes = ORTWorld.Paquetes;
        return View();
    }
}
