using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculaImposto.interfaces;

namespace CalculaImposto.src.entities
{
    public class Icms : ClasseBase, IImposto
    {
        public Icms(double Valor) : base(Valor)
        {
            this.Taxa = 0.3;
        }

        public double CalcularImposto(double valor, double taxa)
        {
            return valor * ( 1 + taxa);
        }

        /*public double ValorImposto()
        {
            return CalcularImposto;
        }*/
    }
}