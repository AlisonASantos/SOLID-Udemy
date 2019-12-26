using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class Funcionario : IPagavel
    {
        private string cargo;
        private double salario;
        private double comissao;

        public double GetSalario()
        {
            return this.salario + this.GetComissao();
        }

        public double GetComissao()
        {
            return this.comissao;
        }

        public String GetCargo()
        {
            return cargo;
        }

        public void SetSalario(double valor)
        {
            this.salario = valor;
        }

        public double getRemuneracao()
        {
            double remuneracao = this.salario;

            if (this.GetCargo() == "Representante") return remuneracao + comissao;

            return remuneracao;
        }
    }
}
