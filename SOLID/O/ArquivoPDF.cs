using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O
{
    class ArquivoPDF : Arquivo
    {
        public override void Gerar()
        {
            Console.WriteLine("Gerei um PDF");
        }
    }
}
