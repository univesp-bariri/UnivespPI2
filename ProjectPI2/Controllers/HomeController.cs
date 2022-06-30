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
        var a = database.Anuncios.AsQueryable();
        if(!string.IsNullOrEmpty(Pesquisa))
            a = a.Where(c => c.categorianome.Contains(Pesquisa));
        a = a.OrderBy( c => c.titulo);

        return View(await a.ToListAsync());
    }


    [HttpGet]
    public async Task<IActionResult> login()
    
    {
        ViewData["id"] = new SelectList(await database.Categorias.ToListAsync(), "id", "nome");
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}