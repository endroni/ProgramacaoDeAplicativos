using System;

namespace Multiplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Vezes valor; //Declaração de variável
            valor = new Vezes(); // Instanciação            

            Console.Write("Digite o primeiro valor: ");
            valor.numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            valor.numero2 = double.Parse(Console.ReadLine());

            double resultado = valor.Produto();

            Console.WriteLine($"A multiplicação de {valor.numero1} x {valor.numero2} = {resultado} ");
        }
    }
}




