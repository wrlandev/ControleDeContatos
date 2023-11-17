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
            if (ModelState.IsValid)
            {
                _icontato.Adicionar(contato);
                return RedirectToAction("Index");
            }

            return View(contato);
        }

        public IActionResult Detalhes()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            ContatoModel contato = _icontato.BuscarPorId(id);
            return View(contato);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                _icontato.Atualizar(contato);
                return RedirectToAction("Index");
            }

            return View(contato);

        }

        public IActionResult Deletar(int id)
        {
            ContatoModel contato = _icontato.BuscarPorId(id);
            return View(contato);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apagar(int id)
        {
            _icontato.Apagar(id);
            return RedirectToAction("Index");
        }
    }
}
