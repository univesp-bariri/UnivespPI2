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
        public IActionResult Salvar(usuario user, candidato cand)
        {
            if(ModelState.IsValid)
            {
                _database.Usuarios.Add(user);
                _database.SaveChanges();

                var userCand = new candidato();
                userCand.usuarioId = user.id;
                userCand.Usuario = user;
                _database.Candidatos.Add(userCand);

                var userContr = new contratante();
                userContr.usuarioId = user.id;
                userContr.Usuario = user;
                _database.Contratantes.Add(userContr);

                _database.SaveChanges();
                return Content("Bem sucedido");
            }
            return View("../Cadastro/Cadastro");
        }
    }
}