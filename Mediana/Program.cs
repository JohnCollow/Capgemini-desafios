using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediana
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(',');
            List<int> lista = new List<int>();

            if (text.Length % 2 == 0)
            {
                Console.WriteLine("Quantidade de numeros inseridos é par");
            }
            else
            {

                foreach (var item in text)
                {
                    lista.Add(int.Parse(item));
                }

                while (lista.Count > 1)
                {
                    lista.Remove(lista.Max());
                    lista.Remove(lista.Min());
                }

                foreach (var item in lista)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
        }
    }
}
