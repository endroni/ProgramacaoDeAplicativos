using System;

namespace Aula_05__04_EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 || 4 != 5; // True
            bool c2 = 2 > 3 && 4 != 5;  // False
            bool c3 = (2 > 3) && (4 != 5);  //False
            bool c4 = !(2 > 3) && (4 != 5); // True
            bool c5 = c1 || c3;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
        }
    }
}
