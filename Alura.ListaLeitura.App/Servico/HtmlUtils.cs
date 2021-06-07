using System.IO;

namespace Alura.ListaLeitura.App.Servico
{
    public class HtmlUtils
    {
        public static string CarregaArquivoHtml(string nomeArquivo)
        {
            var nomeCompletoArquivo = $"html/{nomeArquivo}.html";
            using (var arquivo = File.OpenText(nomeCompletoArquivo))
            {
                return arquivo.ReadToEnd();
            }
        }
    }
}