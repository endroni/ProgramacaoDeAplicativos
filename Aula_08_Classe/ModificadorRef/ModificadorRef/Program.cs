using System;

namespace ModificadorRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Calculadora.Triplicar( ref x);
            Console.WriteLine(x);
        }
    }
}
