using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            //app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();

            // var routeBuilder = new RouteBuilder(app);

            // routeBuilder.MapRoute("Livros/ParaLer", ExibirLivros.LivrosParaLer);
            // routeBuilder.MapRoute("Livros/Lendo", ExibirLivros.LivrosLendo);
            // routeBuilder.MapRoute("Livros/Lidos", ExibirLivros.LivrosLidos);
            // routeBuilder.MapRoute("Livros/Detalhes/{id:int}", ExibirLivros.DetalhesLivro);
            // routeBuilder.MapRoute("cadastro/novolivro/{nome}/{autor}", CadastrarLivros.CadastrarNovoLivro);
            // routeBuilder.MapRoute("cadastro/novolivro", CadastrarLivros.CadastrarNovoLivroForm);
            // routeBuilder.MapRoute("cadastro/incluir", CadastrarLivros.IncluirNovoLivro);

            // var rotas = routeBuilder.Build();

            // app.UseRouter(rotas);

            //app.Run(Roteamento);
        }

        // public Task Roteamento(HttpContext context)
        // {
        //     var _repo = new LivroRepositorioCSV();

        //     var resourcePath = new Dictionary<string, RequestDelegate>()
        //     {
        //         {"/Livros/ParaLer",  LivrosParaLer},
        //         {"/Livros/Lendo",  LivrosLendo },
        //         {"/Livros/Lidos",  LivrosLidos},
        //     };

        //     if (resourcePath.ContainsKey(context.Request.Path))
        //     {
        //         var method = resourcePath[context.Request.Path];
        //         return method.Invoke(context);
        //     }

        //     context.Response.StatusCode = 404;
        //     return context.Response.WriteAsync("Endpoint nao encontrado!");
        // }
    }
}