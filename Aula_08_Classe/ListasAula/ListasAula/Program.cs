using System;
using System.Collections.Generic;

namespace ListasAula
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animais = new List<string>();

            animais.Add("Vaca");
            animais.Add("Cão");
            animais.Add("Gato");
            animais.Add("Cabra");

            animais.Insert(0, "Peixe");

            foreach(string zoo in animais)
            {
                Console.WriteLine(zoo);
            }

            Console.WriteLine("Essa lista tem " + animais.Count + " animais");

            animais.RemoveRange(1, 3);
            
            Console.WriteLine("-----REMOVENDO------");
            foreach (string zoo in animais)
            {
                Console.WriteLine(zoo);
            }

        }
    }
}
