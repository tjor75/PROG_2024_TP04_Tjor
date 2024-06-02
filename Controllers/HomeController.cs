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
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
                
        return View();
    }
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {
        bool formatoValido = Destino > 0 && Hotel > 0 && Aereo > 0 && Destino > 0 && Destino <= ORTWorld.ListaDestinos.Count && Hotel <= ORTWorld.ListaHoteles.Count && Aereo <= ORTWorld.ListaAereos.Count && Excursion <= ORTWorld.ListaExcursiones.Count;
        Paquete nuevoPaquete;

        if (formatoValido)
        { 
            if (ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino-1], new Paquete(ORTWorld.ListaHoteles[Hotel-1], ORTWorld.ListaAereos[Aereo-1], ORTWorld.ListaExcursiones[Excursion-1])))
                return RedirectToAction("Index");
            else
            {
                ViewBag.Error = "Ya existe un paquete para esta ciudad";

                ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
                ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
                ViewBag.ListaAereos = ORTWorld.ListaAereos;
                ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;

                return View("SelectPaquete");
            }
        }
        else
        {
            ViewBag.Error = "Se ingresaron destinos invalidos";
            
            ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
            ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
            ViewBag.ListaAereos = ORTWorld.ListaAereos;
            ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;

            return View("SelectPaquete");
        }
    }
}
