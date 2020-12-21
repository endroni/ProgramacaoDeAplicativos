using System;
using Avaliacao.Entities;

namespace Avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("Volkswagem", "Passate", 1983);

            Console.WriteLine("Meu primeiro carro foi um " + carro1);
        }
    }
}

