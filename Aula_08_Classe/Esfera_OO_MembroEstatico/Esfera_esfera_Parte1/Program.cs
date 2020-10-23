using System;
using System.Globalization;

namespace Esfera_esfera_Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);           

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
