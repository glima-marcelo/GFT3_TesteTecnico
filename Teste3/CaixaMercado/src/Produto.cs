using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaixaMercado.src
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Tipo { get; set; }

        public Produto()
        {
            this.Nome = Nome;
            this.Valor = Valor;
            this.Tipo = Tipo;
        }
    }
}