using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O
{
    class GeradorArquivo
    {
        public void GerarArquivo(IList<Arquivo> arquivos)
        {
            foreach (var arquivo in arquivos)
            {
                arquivo.Gerar();
            }
        }
    }
}
