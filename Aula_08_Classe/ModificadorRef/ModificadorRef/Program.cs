using System;

namespace ModificadorRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Calculadora.Triplicar(x);

            Console.WriteLine(x);
        }
    }
}
