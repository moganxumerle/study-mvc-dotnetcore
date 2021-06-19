using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Alura.ListaLeitura.App.Servico
{
    public class LivrosController
    {
        public static Task ParaLer(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            //var retorno = _repo.ParaLer.ToString();

            var html = HtmlUtils.CarregaArquivoHtml("ListaLivrosParaLer");

            html = CarregaListaLivrosHtml(_repo.ParaLer.Livros, html);

            // Thread.Sleep(new TimeSpan(0, 0, 1));

            // if(context.RequestAborted.IsCancellationRequested)
            // {
            //     Console.WriteLine("Foi Cancelado");
            //     context.Response.StatusCode = 500;
            //     return context.Response.WriteAsync("Deu Timeout!");
            // }

            //Console.WriteLine("Comecando a responder");
            //Thread.Sleep(new TimeSpan(0, 0, 2));
            //Console.WriteLine("Terminando a responder");

            return context.Response.WriteAsync(html);
        }
        public static Task LivrosLendo(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            //return context.Response.WriteAsync(_repo.Lendo.ToString());
            var html = HtmlUtils.CarregaArquivoHtml("ListaLivrosLendo");

            html = CarregaListaLivrosHtml(_repo.Lendo.Livros, html);

            return context.Response.WriteAsync(html);
        }

        public static Task LivrosLidos(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            //return context.Response.WriteAsync(_repo.Lidos.ToString());

            var html = HtmlUtils.CarregaArquivoHtml("ListaLivrosLidos");

            html = CarregaListaLivrosHtml(_repo.Lidos.Livros, html);

            return context.Response.WriteAsync(html);
        }

        public string Detalhes(int id)
        {
            var _repo = new LivroRepositorioCSV();
            var livro = _repo.Todos.First(l => l.Id == id);

            return livro.Detalhes();
        }

        public string Teste()
        {
            return "testando";
        }

        private static string CarregaListaLivrosHtml(IEnumerable<Livro> livros, string html)
        {
            foreach (var livro in livros)
            {
                html = html.Replace("##NOVO-ITEM##", $"<li>{livro.Titulo} - {livro.Autor}</li>##NOVO-ITEM##");
            }
            html = html.Replace("##NOVO-ITEM##", "");

            return html;
        }
    }
}