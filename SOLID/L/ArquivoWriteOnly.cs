using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L
{
    class ArquivoWriteOnly : IArquivoEscrever
    {
        public void Escrever()
        {
            Console.WriteLine("Escrever...");
        }
    }
}
