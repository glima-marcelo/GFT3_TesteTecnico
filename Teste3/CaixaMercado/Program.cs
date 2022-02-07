using System;
using CaixaMercado.src;

namespace CaixaMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Caixa> produtos = new List<Caixa>();

            produto.Add(new Caixa("Banana", 0.99, 2, 3));
            produto.Add(new Caixa("Energético", 5.49, 3, 7));
            produto.Add(new Caixa("Arroz", 20.00, 1, 1));
            produto.Add(new Caixa("Chocolate", 4.50, 1, 12));
            produto.Add(new Caixa("Leite", 3.73, 3, 5));
            produto.Add(new Caixa("Abacaxi", 2.40, 2, 1));
            
            foreach (Caixa produto in produtos)
            {
                Console.Write(produto);
                Console.Write(CalculaValorFinal);
            }
            
        }
    }
}
