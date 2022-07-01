using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjectPI2.Models;
using WebPostgreSQL.Models; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjectPI2.Controllers;

public class HomeController : Controller
{
    private readonly Contexto database; 

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, Contexto database) 
    {
        this.database = database; 
        _logger = logger;
    }

    public async Task<IActionResult> Index(string Pesquisa)
    {
        ViewData["Index"] = Pesquisa;
        var UserQuery = from x in database.Anuncios select x;

        if (!string.IsNullOrEmpty(Pesquisa))
            {
            UserQuery = UserQuery.Where(x => x.categnome.Contains(Pesquisa.ToLower().Replace("ç", "c")));
        }
        return View(await UserQuery.AsNoTracking().ToListAsync());
    }

public async Task<IActionResult> login(string Pesquisa)
    {
        ViewData["login"] = Pesquisa;
        var UserQuery = from x in database.Anuncios select x;

        if (!string.IsNullOrEmpty(Pesquisa))
            {
            UserQuery = UserQuery.Where(x => x.categnome.Contains(Pesquisa.ToLower().Replace("ç", "c")));
        }
        return View(await UserQuery.AsNoTracking().ToListAsync());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}