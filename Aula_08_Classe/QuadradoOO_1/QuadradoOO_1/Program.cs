using System;

namespace QuadradoOO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando variável do tipo Quadrado
            Quadrado a, b;

            // Instanciando as variáveis 
            a = new Quadrado();
            b = new Quadrado();

            Console.Write("Entre com a altura: ");
            a.A = double.Parse(Console.ReadLine());

            Console.Write("Entre com a base: ");
            b.B = double.Parse(Console.ReadLine());

            double area = a.A * b.B;

            Console.WriteLine("O sr. precisa comprar " + area + " m2 de piso");

        }
    }
}
