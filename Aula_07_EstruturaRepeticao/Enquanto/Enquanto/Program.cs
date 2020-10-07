using System;
using System.Globalization;

namespace Enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            

            while ( numero > 0 ) {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());            
                
            }

            Console.ReadKey(); /* Só encerra se digitar algo */            
        }
    }
}
