using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectPI2.Models;
using WebPostgreSQL.Models; // banco de dados
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        // var anuncios = database.Anuncio.Where(a => a.disponibilidade == true).ToString();
        return View();
    }

    public IActionResult login()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}