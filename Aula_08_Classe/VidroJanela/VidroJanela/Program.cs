using System;
using System.Globalization;

namespace VidroJanela
{
    class Program
    {
        static void Main(string[] args)
        {
            Vidro x, y;

            x = new Vidro();
            y = new Vidro();            

            Console.WriteLine("Entre com as medidas da janela: ");
            x.Lado1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.Lado2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(  );

            double medida = x.Lado1 * y.Lado2;
            Console.WriteLine("Vidro: " + medida.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
