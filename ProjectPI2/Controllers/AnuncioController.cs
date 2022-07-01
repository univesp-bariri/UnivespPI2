using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjectPI2.Models;
using WebPostgreSQL.Models; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


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

    [HttpGet]
    public async Task<IActionResult> NovoAnuncio()
    {
        ViewData["id"] = new SelectList(await database.Categorias.ToListAsync(), "nome", "nome");
        return View();
    }

    public async Task<IActionResult> MeusAnuncios(int Pesquisa)
    {
        ViewData["MeusAnuncios"] = Pesquisa;
        var UserQuery = from x in database.Anuncios select x;
        UserQuery = UserQuery.Where(x => x.usuarioId.Equals(1));
        return View(await UserQuery.AsNoTracking().ToListAsync());
    }



    [HttpGet]
        public async Task<IActionResult> EncontrarAnuncio(int id)
    {
        return View(await database.Anuncios.FindAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> ExcluirAnuncio(int id){
        anuncio ad = await database.Anuncios.FindAsync(id);
        database.Anuncios.Remove(ad);
        await database.SaveChangesAsync();
        return RedirectToAction(nameof(MeusAnuncios));
    }

    public IActionResult Salvar(anuncio anun)
    {
        if(ModelState.IsValid)
            {
                database.Anuncios.Add(anun);
                database.SaveChanges();

                TempData["successAd"] = "As pessoas já podem entrar contato com você.";
                return RedirectToAction("login", "Home");
            }
            return View("../Anuncio/NovoAnuncio");
    }

    }
}