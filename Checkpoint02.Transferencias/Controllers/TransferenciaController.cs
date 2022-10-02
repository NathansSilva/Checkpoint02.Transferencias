using Checkpoint02.Transferencias.Models;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint02.Transferencias.Controllers
{
    public class TransferenciaController : Controller
    {
        private static List<Transferencia> _lista = new List<Transferencia>();

        private static int _id = 0;

        //Remove
        [HttpPost]
        public IActionResult Remover(Transferencia transferencia)
        {

            var index = _lista.FindIndex(c => c.Codigo == transferencia.Codigo);
            _lista.RemoveAt(transferencia.Codigo);
            TempData["msg"] = "Jogador removido!";
            return RedirectToAction("Index");
        }

        //Edit
        [HttpPost]
        public IActionResult Editar(Transferencia transferencia)
        {
            var index = _lista.FindIndex(c => c.Codigo == transferencia.Codigo);
            _lista[index] = transferencia;
            TempData["msg"] = "Jogador atualizado";
            return RedirectToAction("Index");
        }

        //Edit
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var transferencia = _lista.Find(match => match.Codigo == id);
            return View(transferencia);
        }

        public IActionResult Index()
        {
            return View(_lista);
        }

        //CRUD Cadastrar
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Transferencia transferencia)
        {
            transferencia.Codigo = ++_id;
            _lista.Add(transferencia);
            TempData["cadastro"] = "Jogador cadastrado";
            return RedirectToAction("Cadastrar");
        }

        //Pesquisar
        [HttpPost]
        public IActionResult Pesquisar(string Nome)
        {
            var transferencia = _lista.Find(c => c.Nome == Nome);
            return View(transferencia);
        }

        [HttpGet]
        public IActionResult Pesquisar()
        {

            return View();
        }
    }
}
