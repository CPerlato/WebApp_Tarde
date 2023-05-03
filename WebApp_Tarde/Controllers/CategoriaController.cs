using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde.Controllers
{
    public class CategoriaController : Controller
    {

        private Contexto contexto;

        public CategoriaController(Contexto db)
        {
            contexto = db;
        }
        public IActionResult Lista()
        {
            return View(contexto.categoria.ToList());
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SalvarDados(CategoriaEntidade dados)
        {
            contexto.categoria.Add(dados);
            contexto.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
