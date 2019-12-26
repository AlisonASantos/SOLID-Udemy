using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O
{
    class Program
    {
        //Principio do Aberto e Fechado
        static void Main(string[] args)
        {
            List<Arquivo> arquivos = new List<Arquivo>();
            ArquivoPDF pdf = new ArquivoPDF();
            ArquivoWord word = new ArquivoWord();

            arquivos.Add(pdf);
            arquivos.Add(word);

            GeradorArquivo gerador = new GeradorArquivo();

            gerador.GerarArquivo(arquivos);

            Console.ReadKey();
        }
    }
}
