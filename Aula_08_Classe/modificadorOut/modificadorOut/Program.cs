using System;

namespace modificadorOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triplo;
            Calculadora.Triplo(a, out triplo);
            Console.WriteLine(triplo);
        }
    }
}
