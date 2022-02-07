using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculaImposto.interfaces;

namespace CalculaImposto.src.entities
{
    public class Ipi : ClasseBase, IImposto
    {
        public Ipi(double Valor) : base(Valor)
        {
            if (this.Valor >= 25000)
            {
                this.Taxa = 0.10;
            }
            else
            {
                this.Taxa = 0.05;
            }
        }

        public double CalcularImposto(double valor, double taxa)
        {
            return valor * ( 1 + taxa);
        }
    }
}