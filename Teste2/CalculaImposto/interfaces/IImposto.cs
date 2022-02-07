using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaImposto.interfaces
{
    public interface IImposto
    {
        double CalcularImposto(double valor, double taxa);
    }
}