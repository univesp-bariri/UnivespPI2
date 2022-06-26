using Microsoft.AspNetCore.Mvc;
using ProjectPI2.Models;
using WebPostgreSQL.Models;

namespace ProjectPI2.Controllers
{
    public class AnuncioController : Controller
    {
    private readonly Contexto database; // banco de dados

    private readonly ILogger<AnuncioController> _logger;

    public AnuncioController(ILogger<AnuncioController> logger, Contexto database) //( banco de dados)
        {
            this.database = database; // banco de dados
            _logger = logger;
        }
    
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult NovoAnuncio()
    {
        return View();
    }
    public IActionResult Salvar(anuncio anun)
    {
        if(ModelState.IsValid)
            {
                database.Anuncio.Add(anun);
                database.SaveChanges();

                return Content("Bem sucedido");
            }
            return View("../Anuncio/Index");
    }

    }
}