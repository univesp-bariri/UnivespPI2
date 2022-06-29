using Microsoft.AspNetCore.Mvc;
using ProjectPI2.Models;
using WebPostgreSQL.Models;

namespace ProjectPI2.Controllers
{
    public class AnuncioController : Controller
    {
    private readonly Contexto database; 

    public AnuncioController(Contexto database)
        {
            this.database = database; 
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

                TempData["successAd"] = "As pessoas já podem entrar contato com você.";
                return RedirectToAction("login", "Home");
            }
            return View("../Anuncio/NovoAnuncio");
    }

    }
}