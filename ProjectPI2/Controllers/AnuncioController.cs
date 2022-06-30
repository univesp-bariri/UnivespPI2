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
    private readonly Contexto database; 

    public AnuncioController(Contexto database)
        {
            this.database = database; 
        }
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> NovoAnuncio()
    {
        ViewData["id"] = new SelectList(await database.Categorias.ToListAsync(), "id", "nome");
        return View();
    }

        [HttpGet]
        
    public async Task<IActionResult> MeusAnuncios()
    {
        ViewData["id"] = new SelectList(await database.Categorias.ToListAsync(), "id", "nome");
        return View();
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