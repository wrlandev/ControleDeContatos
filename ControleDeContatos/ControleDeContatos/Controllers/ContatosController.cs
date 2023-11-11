using ControleDeContatos.Interfaces;
using ControleDeContatos.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatosController : Controller
    {
        private readonly Icontato _icontato;
        public ContatosController(Icontato contato)
        {
            _icontato = contato;
        }

        public IActionResult Index()
        {
            List<ContatoModel> contatos = _icontato.BuscarTodos();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(ContatoModel contato)
        {
            _icontato.Adicionar(contato);
            return RedirectToAction("Index");
        }

        public IActionResult Detalhes()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }
    }
}
