using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L
{
    class ArquivoTxt : IArquivoLer, IArquivoEscrever  
    {
        public void Escrever()
        {
            Console.WriteLine("Escrevendo...");
        }

        public void Ler()
        {
            Console.WriteLine("Lendo...");
        }
    }
}
