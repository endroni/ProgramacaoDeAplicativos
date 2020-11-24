using System;
using System.Globalization;

namespace VetorMediaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] prod = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // sem construtor
                // prod[i] = new Produto { Nome = nome, Preco = preco };
                prod[i] = new Produto(nome, preco);
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += prod[i].Preco;
            }

            double media = soma / n;
            Console.WriteLine("AVERAGE PRICE " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
