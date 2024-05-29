using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PROG_2024_TP04_Tjor.Models;

namespace PROG_2024_TP04_Tjor.Controllers;

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
    public IActionResult SelectPaquete()
    {
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.Paquetes = ORTWorld.Paquetes;
        
        return View();
    }
}
