using System;
using System.Globalization;

namespace AreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            
            Console.WriteLine("Entre a lartura e altura do retângulo: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = r.Area();
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));

            double perimetro = r.Perimetro();
            Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));

            double diagonal = r.Diagonal();
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
