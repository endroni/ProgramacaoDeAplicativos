using System;
using System.Globalization;

namespace LajePreMoldada
{
    class Program
    {
        static void Main(string[] args)
        {
            Metragem x, y;

            x = new Metragem();
            y = new Metragem();

            Console.WriteLine("------------- Lajes Confiança ---------------");
            Console.WriteLine();
            Console.WriteLine("                 seu conforto, nossa alegria.");
            Console.WriteLine();
            Console.Write("Qual a medida de um lados:  ");
            x.AlturaLaje = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qual a medida de do outro lado:  ");
            y.LarguraLaje = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double tamanhoLaje = x.AlturaLaje * y.LarguraLaje;
            Console.WriteLine("O sr(a) precisa comprar " + tamanhoLaje.ToString("F2", CultureInfo.InvariantCulture) + " m2 de laje.");

            Console.ReadKey();
        }
    }
}
