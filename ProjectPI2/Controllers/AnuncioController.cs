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


        [HttpPost]
        public IActionResult NovoAnuncio(IFormFile formFile)
        {
            try
            {
                string fileName = formFile.FileName;
                fileName = Path.GetFileName(fileName);
                string uploadpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//images", fileName);
                var stream = new FileStream(uploadpath, FileMode.Create);
                formFile.CopyToAsync(stream);
                ViewBag.Message = fileName;
            }

            catch
            {
                ViewBag.Message = "Error ao subir a imagem, recarregue a página!";

            } 
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