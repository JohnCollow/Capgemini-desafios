using System;
using System.Collections.Generic;

namespace Criptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = NoSpace(Console.ReadLine());
            List<string> lista = new List<string>();
            int number = Convert.ToInt32((Math.Ceiling(Math.Sqrt(text.Length))));

            for (int i = 0; i < number; i++)
            {
                string smallText = "";
                for (int j = 0; j < number; j++)
                {
                    if (number*j+i < text.Length)
                    {
                        smallText = smallText.Insert(j, char.ToString(text[number * j + i]));
                    }
                }
                lista.Add(smallText);
            }

            foreach (var item in lista)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        static string NoSpace(string text) 
        {

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    text = text.Replace(" ", "");
                }
            }
            return text;
        }

    }
}
