using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    interface IPagador
    {
        void setPagavel(IPagavel pagavel);

        double getSalario();
    }
}
