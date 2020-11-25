using System;

namespace Pensionado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Cliente[] cli = new Cliente[n];

            for ( int i = 0; i < n; i++ )
            {
                Console.WriteLine("Aluguel #" + (i + 1) + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                cli[quarto] = new Cliente(nome, email);
            }

            Console.WriteLine(cli[0].Nome);
            
        }
    }
}
