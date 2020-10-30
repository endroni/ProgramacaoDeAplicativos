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

<<<<<<< HEAD
            Console.WriteLine(  );
=======
            Console.WriteLine();
            Console.WriteLine();
>>>>>>> cfd0cff9b0e0e522078ba0b416c0e66716d2078c

            double medida = x.Lado1 * y.Lado2;
            Console.WriteLine("Vidro: " + medida.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
