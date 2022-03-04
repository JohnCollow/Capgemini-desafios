using System;
using System.Collections.Generic;

namespace NumerosParesDoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(',');
            List<int> lista = new List<int>();

            int diferenca = int.Parse(Console.ReadLine());
            int quantidade = 0;

            foreach (var item in text)
            {
                lista.Add(int.Parse(item));
            }

            for (int i = 0; i < lista.Count; i++)
            {
                
                    if (lista.Contains(lista[i]+diferenca)) 
                    {
                        quantidade++;
                    }
                
            }


            Console.WriteLine(quantidade);
            Console.ReadLine();

        }
    }
}
