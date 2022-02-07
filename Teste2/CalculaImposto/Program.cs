using System;
using CalculaImposto.src.entities;

namespace CalculaImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            var valor = Double.Parse(Console.ReadLine());
            Icms. icms = new Icms(valor);

            Console.WriteLine(icms);
        }
    }
}
