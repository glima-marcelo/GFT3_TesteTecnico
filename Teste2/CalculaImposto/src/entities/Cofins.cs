using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculaImposto.interfaces;

namespace CalculaImposto.src.entities
{
    public class Cofins : ClasseBase, IImposto
    {
        public Cofins(double Valor) : base(Valor)
        {
            if (this.Valor > 17000)
            {
                this.Taxa = 0.08;
            }
            else
            {
                this.Taxa = 0;
            }
        }

        public double CalcularImposto(double valor, double taxa)
        {
            return valor * ( 1 + taxa);
        }
    }
}