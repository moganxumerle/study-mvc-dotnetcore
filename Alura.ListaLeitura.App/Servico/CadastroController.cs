using System.Linq;
using System.Threading.Tasks;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Alura.ListaLeitura.App.Servico
{
    public class CadastroController
    {
        public string Incluir(Livro livro)
        {
            var _repo = new LivroRepositorioCSV();
            _repo.Incluir(livro);

            return "Livro cadastrado com sucesso!";
        }

        public IActionResult ExibeFormulario()
        {
            var html = new ViewResult
            {
                ViewName = "formulario"
            };

            return html;
        }
    }
}