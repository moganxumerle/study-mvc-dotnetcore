using System.Linq;
using System.Threading.Tasks;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Alura.ListaLeitura.App.Servico
{
    public class CadastroController
    {
        public static Task IncluirNovoLivro(HttpContext context)
        {
            var livro = new Livro
            {
                Titulo = context.Request.Form["titulo"].First(),
                Autor = context.Request.Form["autor"].First(),
            };

            var _repo = new LivroRepositorioCSV();
            _repo.Incluir(livro);

            return context.Response.WriteAsync("Livro cadastrado com sucesso!");
        }

        public static Task CadastrarNovoLivroForm(HttpContext context)
        {
            var html = HtmlUtils.CarregaArquivoHtml("CadastroNovoLivro");
            return context.Response.WriteAsync(html);
        }

        public static Task CadastrarNovoLivro(HttpContext context)
        {
            var livro = new Livro
            {
                Titulo = context.GetRouteValue("nome").ToString(),
                Autor = context.GetRouteValue("autor").ToString()
            };

            var _repo = new LivroRepositorioCSV();
            _repo.Incluir(livro);

            return context.Response.WriteAsync("Livro cadastrado com sucesso!");
        }
    }
}