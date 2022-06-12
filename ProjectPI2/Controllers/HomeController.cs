using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjectPI2.Models;
using WebPostgreSQL.Models; // banco de dados

namespace ProjectPI2.Controllers;

public class HomeController : Controller
{
    private readonly Contexto database; // banco de dados

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, Contexto database) //( banco de dados)
    {
        this.database = database; // banco de dados
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
