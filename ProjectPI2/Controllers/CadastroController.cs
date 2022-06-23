using Microsoft.AspNetCore.Mvc;
using ProjectPI2.Models;
using WebPostgreSQL.Models;

namespace ProjectPI2.Controllers
{
    public class CadastroController : Controller
    {
        private readonly Contexto _database;
        public CadastroController(Contexto database)
        {
            _database = database;
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Salvar(usuario user)
        {
            if(ModelState.IsValid)
            {
                _database.Usuarios.Add(user);
                _database.SaveChanges();

                return Content("Bem sucedido");
            }
            return View("../Cadastro/Cadastro");
        }
    }
}