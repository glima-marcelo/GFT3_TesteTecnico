using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaixaMercado.src
{
    public class Caixa : Produto
    {
        public int Quantidade { get; set; }
    }

    public Caixa(Produto Nome, Produto Valor, Produto Tipo, int Quantidade)
    {
        Produto.Nome = Nome;
        Produto.Valor = Valor;
        Produto.Tipo = Tipo;
        this.Quantidade = Quantidade;
    }

    public double CalculaValorFinal(Produto Produto, int Quantidade)
    {
        switch(Produto.Tipo)
        {
            case 1:
            return Produto.Valor * Quantidade * 0.9;
            break;
            case 2:
            return Produto.Valor * Quantidade * 0.8;
            break;
            case 3:
            if (this.Quantidade > 5)
            {
                return Produto.Valor * Quantidade * 0.9;
            }
            else
            {
                return Produto.Valor * Quantidade;
            }
            break;
        }

       public override string ToString()
        {
            Produto.Nome + " - " + Produto.Valor + " - " + Produto.Tipo + " - " + this.Quantidade + " - " + CalculaValorFinal;
        } 
    }

}