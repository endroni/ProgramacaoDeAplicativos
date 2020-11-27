using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Ana Maria Braga");
            lista.Add("Eliana");
            lista.Add("Xuxa");

            foreach(string nomes in lista)
            {
                Console.WriteLine(nomes);
            }
        }
    }
}

