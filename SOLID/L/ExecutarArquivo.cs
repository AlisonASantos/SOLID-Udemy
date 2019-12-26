using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L
{
    class ExecutarArquivo
    {
        public void Executar(Arquivo arquivo)
        {
            if (arquivo is ArquivoReadOnly)
            {
                arquivo.Ler();
            }
            else
            {
                arquivo.Ler();
                arquivo.Escrever();
            }             
        }
    }
}
