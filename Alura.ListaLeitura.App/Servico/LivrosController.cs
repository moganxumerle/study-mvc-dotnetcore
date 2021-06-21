using System.Collections.Generic;
using System.Linq;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alura.ListaLeitura.App.Servico
{
    public class LivrosController : Controller
    {
        public IEnumerable<Livro> Livros { get; set; }

        public IActionResult ParaLer()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Titulo = "Livros Para Ler";
            ViewBag.Livros = _repo.ParaLer.Livros;

            return View("lista");
        }

        public IActionResult Lendo()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Titulo = "Livros Lendo";
            ViewBag.Livros = _repo.Lendo.Livros;

            return View("lista");
        }

        public IActionResult Lidos()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Titulo = "Livros Lidos";
            ViewBag.Livros = _repo.Lidos.Livros;

            return View("lista");
        }

        public string Detalhes(int id)
        {
            var _repo = new LivroRepositorioCSV();
            var livro = _repo.Todos.First(l => l.Id == id);

            return livro.Detalhes();
        }
    }
}