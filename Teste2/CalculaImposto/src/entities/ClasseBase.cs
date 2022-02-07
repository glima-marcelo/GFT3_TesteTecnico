using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculaImposto.interfaces;

namespace CalculaImposto.src.entities
{
    public class ClasseBase
    {
        public double Valor { get; set; }
        public double Taxa { get; set; }

        public ClasseBase(double Valor)
        {
            this.Valor = Valor;
            this.Taxa = Taxa;
        }
    }
}