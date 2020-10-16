using System;
using System.Globalization;

namespace Triangulo_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y; // Declara as variáveis

            x = new Triangulo(); // Faz instanciação
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            double areaY = y.Area();
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.Write("Maior area X");
            }
            else
            {
                Console.Write("Maior area Y");
            }

            Console.ReadKey();
        }
    }
}
