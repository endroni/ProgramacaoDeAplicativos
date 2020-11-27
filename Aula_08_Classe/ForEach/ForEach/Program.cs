using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carros = new string[] { "grand siena", "Camaro", "Fusca" };

        for ( int i = 0; i < carros.Length; i++ )
            {
                Console.WriteLine(carros[i]);
            }
        Console.WriteLine("-------================-------------");

        foreach(string i in carros)
            {
                Console.WriteLine(i);
            }
        }
    }
}
