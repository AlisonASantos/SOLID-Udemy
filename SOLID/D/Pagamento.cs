using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class Pagamento : IPagador
    {
        private IPagavel pagavel;
        public double getSalario()
        {
            return pagavel.getRemuneracao();
        }

        public void setPagavel(IPagavel pagavel)
        {
            this.pagavel = pagavel;
        }
    }
}
