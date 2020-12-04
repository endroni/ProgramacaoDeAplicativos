using System;
using System.Collections.Generic;

namespace ListaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos esportes você quer adicionar? ");
            int n = int.Parse(Console.ReadLine());

            List<Esportes> esporte = new List<Esportes>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Esporte # " + i + 1);
                Console.Write("Digite o Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Digite o Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Investimento R$ ");
                double investimento = double.Parse(Console.ReadLine());

                esporte.Add(new Esportes(id, nome, investimento));
            }
            Console.Clear();

            foreach (Esportes esp in esporte)
            {
                Console.WriteLine(esp);
            }
        }
    }
}
