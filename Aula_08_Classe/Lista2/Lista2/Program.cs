using System;
using System.Collections.Generic;

namespace Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Ana Maria Braga");
            lista.Add("Eliana");
            lista.Add("Xuxa");
            lista.Add("Eva");

            lista.Insert(2, "Mara");

            foreach(string nomes in lista)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine(lista.Count);

            string e = lista.Find(x => x[0] == 'E');

            Console.WriteLine("Nome que começa com E: " + e);

            string a = lista.FindLast(x => x[0] == 'E');
            Console.WriteLine(a);

            int posicao1 = lista.FindIndex(x => x[0] == 'E');
            Console.WriteLine(posicao1);
            
            int posicao2 = lista.FindLastIndex(x => x[0] == 'E');
            Console.WriteLine(posicao2);

            List<string> lista2 = lista.FindAll(x => x.Length == 4);

            foreach( string nomes in lista2)
            {
                Console.WriteLine(nomes);
            }

            // lista.Remove("Mara");

            // lista.RemoveAll(x => x[0] == 'E');

            // lista.RemoveAt(1);

            lista.RemoveRange(1,2);

            Console.WriteLine("--------------------");
            foreach (string nomes in lista)
            {
                Console.WriteLine(nomes);
            }
            Console.ReadKey();
        }
    }
}
