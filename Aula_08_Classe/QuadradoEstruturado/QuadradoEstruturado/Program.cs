using System;
using System.Globalization;

namespace QuadradoEstruturado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um lado: ");
            double lado1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o outro: ");
            double lado2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = lado1 * lado2;

            Console.WriteLine("O sr. precisa comprar " + area.ToString("F2", CultureInfo.InvariantCulture) + " m2 de laje");
        }
    }
}
