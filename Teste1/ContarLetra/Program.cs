using System;
using System.Collections.Generic;

namespace ContarLetra
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> frase = new List<String>();

            frase.Add("Na minha máquina funciona");
            frase.Add("Eu posso pular o teste");
            frase.Add("Isso não deve demorar");
            
            foreach (string str in frase)
            {
                Console.WriteLine(str);
                string[] ultimaPalavra = str.Split(' ');
                Console.WriteLine(ultimaPalavra[ultimaPalavra.Length - 1].Length);
            }            
        }
    }
}
