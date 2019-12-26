using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class ServicoPagamento
    {
        private IPagavel _pagavel;
        private IPagador _pagador;

        public ServicoPagamento(IPagavel pagavel, IPagador pagador)
        {
            this._pagador = pagador;
            this._pagavel = pagavel;

            this._pagador.setPagavel(pagavel);
        }

        public double Pagar()
        {
            double valor = this._pagador.getSalario();
            Console.WriteLine("Estou pagando um valor" + valor);

            return valor;
        }
    }
}
