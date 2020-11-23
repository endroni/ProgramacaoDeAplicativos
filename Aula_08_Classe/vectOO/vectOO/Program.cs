using System;
using System.Globalization;

namespace vectOO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            double total = 0.0;

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                total += vect[i];
            }
            double media = total / n;
            Console.WriteLine("AVERAGE HEIGHT = " +media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
